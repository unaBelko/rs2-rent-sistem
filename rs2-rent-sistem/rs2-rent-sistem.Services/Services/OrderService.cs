using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class OrderService : BaseService<Order, Database.Order, OrderSearchObject>, IOrderService
    {
        private readonly ICartService _cartService;

        public OrderService(RentSistemDbContext context, IMapper mapper, ICartService cartService) : base(context, mapper)
        {
            _cartService = cartService;
        }

        public async Task<Order> CreateOrder(OrderCreationRequest request)
        {
            var cart = await _context.Carts
                .Where(c => c.UserID == request.UserId)
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Equipment)
                .FirstOrDefaultAsync(c => c.ID == request.CartId);

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

            await _cartService.EmptyCart(request.CartId);

            return _mapper.Map<Order>(newOrder);
        }
    }

}
