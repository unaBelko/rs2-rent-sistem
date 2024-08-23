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
        public OrderService(RentSistemDbContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<Order> CreateOrder(OrderCreationRequest request)
        {
            var cart = await _context.Carts
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
                IsActive = true
            };

            foreach (var cartItem in cart.CartItems)
            {
                if (cartItem.Equipment == null)
                {
                    throw new Exception($"Equipment not found for CartItem with EquipmentID {cartItem.EquipmentID}.");
                }

                var orderItem = new Database.OrderItem
                {
                    EquipmentID = cartItem.EquipmentID,
                    Quantity = cartItem.Quantity,
                    CostPerUse = cartItem.Equipment.CostPerUse,
                    StartDate = cartItem.StartDate,
                    EndDate = cartItem.EndDate,
                };

                newOrder.OrderItems.Add(orderItem);
            }

            _context.Orders.Add(newOrder);

            await _context.SaveChangesAsync();

            return _mapper.Map<Order>(newOrder);
        }
    }


}
