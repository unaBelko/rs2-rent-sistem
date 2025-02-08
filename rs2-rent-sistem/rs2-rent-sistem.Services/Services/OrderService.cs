using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Models.rs2_rent_sistem.Model.Reports;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class OrderService : BaseService<Order, Database.Order, OrderSearchObject>, IOrderService
    {
        private readonly ICartService _cartService;
        private readonly IModel _channel;

        public OrderService(RentSistemDbContext context, IMapper mapper, ICartService cartService, ConnectionFactory factory) : base(context, mapper)
        {
            var connection = factory.CreateConnection();
            _channel = connection.CreateModel();
            _channel.QueueDeclare(queue: "reservationQueue",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            _cartService = cartService;
        }

        public async Task<List<object>> GetAll(DateTime? startDate, DateTime? endDate, string reportType)
        {
            var query = _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Equipment)
                .Include(o => o.User)
                .AsNoTracking();

            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(o => o.DatePlaced >= startDate.Value && o.DatePlaced <= endDate.Value);
            }

            var orders = await query.ToListAsync();

            return reportType switch
            {
                "most_rented_equipment" => GetMostRentedEquipment(orders),
                "most_active_users" => GetMostActiveUsers(orders),
                "top_revenue_equipment" => GetTopRevenueEquipment(orders),
                _ => throw new ArgumentException("Invalid report type")
            };
        }

        public async Task<string> UpdateOrderStatus(int orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.ID == orderId);

            if (order == null)
                throw new KeyNotFoundException("Order not found.");

            var statusSequence = new List<string> { "created", "paid", "rented", "returned" };

            var currentIndex = statusSequence.IndexOf(order.Status.ToLower());

            if (currentIndex == -1 || currentIndex == statusSequence.Count - 1)
                throw new InvalidOperationException($"Cannot change status from {order.Status}.");

            order.Status = statusSequence[currentIndex + 1];

            await _context.SaveChangesAsync();

            return order.Status;
        }



        private List<object> GetMostRentedEquipment(List<Database.Order> orders)
        {
            return orders
                .SelectMany(o => o.OrderItems)
                .GroupBy(oi => oi.Equipment.ID)
                .Select(group => new MostRentedEquipmentReportModel
                {
                    Name = group.First().Equipment.ItemName,
                    TotalQuantity = (int)group.Sum(oi => oi.Quantity),
                    TotalRentalDays = group.Sum(oi => (oi.EndDate - oi.StartDate)?.Days ?? 0)
                })
                .OrderByDescending(e => e.TotalQuantity)
                .Cast<object>() 
                .ToList();
        }



        private List<object> GetMostActiveUsers(List<Database.Order> orders)
        {
            return orders
                .GroupBy(o => o.UserID)
                .Select(group => new MostActiveUsersReportModel
                {
                    UserNameSurname = $"{group.First().User.FirstName} {group.First().User.LastName}",
                    TotalOrderItems = group.Sum(o => o.OrderItems.Count),
                    TotalOrders = group.Count()
                })
                .OrderByDescending(u => u.TotalOrderItems)
                .Cast<object>()
                .ToList();
        }



        private List<object> GetTopRevenueEquipment(List<Database.Order> orders)
        {
            return orders
                .SelectMany(o => o.OrderItems)
                .GroupBy(oi => oi.Equipment.ID)
                .Select(group => new TopRevenueEquipmentReportModel
                {
                    Name = group.First().Equipment.ItemName,
                    TotalRevenue = (decimal)group.Sum(oi => oi.Quantity * oi.CostPerUse)
                })
                .OrderByDescending(e => e.TotalRevenue)
                .Cast<object>()
                .ToList();
        }

        public override async Task<Order> GetById(int id)
        {
            var query = _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Equipment) 
                .AsQueryable();

            var order = await query.FirstOrDefaultAsync(o => o.ID == id);

            return _mapper.Map<Order>(order);
        }

        public override async Task<PageResult<Order>> Get(OrderSearchObject? search = null)
        {
            if (search == null)
            {
                return new PageResult<Order>();
            }

            var user = await _context.Users
                .Include(u => u.UserRoles)
                .ThenInclude(r => r.Role)
                .FirstOrDefaultAsync(u => u.ID == search.UserId);

            if (user == null)
            {
                return new PageResult<Order>();
            }

            var query = _context.Set<Database.Order>()
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .AsQueryable();

            var userIsEmployee = user.UserRoles.Any(ur => ur.Role.Name == "employee");

            if (userIsEmployee)
            {
                if (search.SearchForUserId.HasValue && search.SearchForUserId != 0)
                {
                    query = query.Where(o => o.UserID == search.SearchForUserId);
                }
            }
            else
            {
                query = query.Where(o => o.UserID == search.UserId);
            }

            PageResult<Order> result = new();

            query = AddFilter(query, search);
            query = AddInclude(query, search);

            result.Count = await query.CountAsync();

            if (search.Page.HasValue && search.PageSize.HasValue)
            {
                query = query.Skip(search.Page.Value * search.PageSize.Value)
                             .Take(search.PageSize.Value);
            }

            var list = await query.ToListAsync();
            var tmp = _mapper.Map<List<Order>>(list);
            result.Result = tmp;

            return result;
        }

        public async Task<Order> CreateOrder(int userId)
        {
            var cart = await _context.Carts
                    .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Equipment)
                    .FirstOrDefaultAsync(c => c.UserID == userId);

            if (cart == null)
            {
                throw new Exception("Carts not found.");
            }

            if (cart.CartItems.Count == 0)
            {
                throw new Exception("Carts can't be empty");
            }

            var newOrder = new Database.Order
            {
                UserID = cart.UserID,
                DatePlaced = DateTime.UtcNow,
                IsActive = true,
                TotalPrice = 0,
                Status = "created"
            };

            foreach (var cartItem in cart.CartItems)
            {
                if (cartItem.Equipment == null)
                {
                    throw new Exception($"Equipment not found for CartItem with EquipmentID {cartItem.EquipmentID}.");
                }

                var numberOfDays = (cartItem.EndDate - cartItem.StartDate).TotalDays;

                var quantity = cartItem.Quantity;
                var costPerUse = cartItem.Equipment.CostPerUse ?? 0m;

                var orderItemPrice = costPerUse * quantity * (decimal)numberOfDays;

                var orderItem = new Database.OrderItem
                {
                    EquipmentID = cartItem.EquipmentID,
                    Quantity = cartItem.Quantity,
                    CostPerUse = cartItem.Equipment.CostPerUse,
                    StartDate = cartItem.StartDate,
                    EndDate = cartItem.EndDate,
                    Price = orderItemPrice
                };

                newOrder.OrderItems.Add(orderItem);
                newOrder.TotalPrice += orderItemPrice;
            }

            _context.Orders.Add(newOrder);
            await _context.SaveChangesAsync();

            await _cartService.EmptyCart(cart.ID);

            var user = await _context.Users.Where(u => u.ID == userId).FirstOrDefaultAsync();

            if (user != null)
            {
                var userEmail = user.Email;
                if (!string.IsNullOrEmpty(userEmail))
                {
                    var message = $"Order created for {userEmail}";
                    var body = Encoding.UTF8.GetBytes(message);
                    _channel.BasicPublish(exchange: "",
                                          routingKey: "notificationsQueue",
                                          basicProperties: null,
                                          body: body);
                }
            }

            return _mapper.Map<Order>(newOrder);
        }

    }

}
