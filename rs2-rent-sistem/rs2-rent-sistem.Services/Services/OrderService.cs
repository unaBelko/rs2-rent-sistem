using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Models;
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
            //var connection = factory.CreateConnection();
            //_channel = connection.CreateModel();
            //_channel.QueueDeclare(queue: "reservationQueue",
            //                     durable: false,
            //                     exclusive: false,
            //                     autoDelete: false,
            //                     arguments: null);
            //
            _cartService = cartService;
        }

        public override async Task<PageResult<Order>> Get(OrderSearchObject? search = null)
        {
            var user = await _context.Users
                .Include(u => u.UserRoles)
                .ThenInclude(r => r.Role)
                .FirstOrDefaultAsync(u => u.ID == search.UserId);

            if (user == null)
            {
                return new PageResult<Order>();
            }
            else
            {
                var query = _context.Set<Database.Order>().AsQueryable();

                var userIsEmployee = user.UserRoles.Any(ur => ur.Role.Name == "employee");
                if (!userIsEmployee)
                {
                    query = query.Where(o => o.UserID == search.UserId);
                }

                PageResult<Order> result = new PageResult<Order>();

                query = AddFilter(query, search);

                query = AddInclude(query, search);

                result.Count = await query.CountAsync();

                if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
                {
                    query = query.Skip(search.Page.Value * search.PageSize.Value)
                                 .Take(search.PageSize.Value);
                }

                var list = await query.ToListAsync();

                var tmp = _mapper.Map<List<Order>>(list);
                result.Result = tmp;

                return result;
            }
        }

        public async Task<Order> CreateOrder(int userId)
        {
            var cart = await _context.Carts
                    .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Equipment)
                    .FirstOrDefaultAsync(c => c.UserID == userId);

            if (cart == null)
            {
                throw new Exception("Cart not found.");
            }

            var newOrder = new Database.Order
            {
                UserID = cart.UserID,
                DatePlaced = DateTime.UtcNow,
                IsActive = true,
                TotalPrice = 0
            };

            foreach (var cartItem in cart.CartItems)
            {
                if (cartItem.Equipment == null)
                {
                    throw new Exception($"Equipment not found for CartItem with EquipmentID {cartItem.EquipmentID}.");
                }

                var numberOfDays = (cartItem.EndDate - cartItem.StartDate).TotalDays;

                var quantity = cartItem.Quantity ?? 1;
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

            //if (user != null)
            //{
            //    var userEmail = user.Email;
            //    if (!string.IsNullOrEmpty(userEmail))
            //    {
            //        var message = $"Order created for {userEmail}";
            //        var body = Encoding.UTF8.GetBytes(message);
            //        _channel.BasicPublish(exchange: "",
            //                              routingKey: "notificationsQueue",
            //                              basicProperties: null,
            //                              body: body);
            //    }
            //}

            return _mapper.Map<Order>(newOrder);
        }

    }

}
