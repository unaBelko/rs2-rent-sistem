using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class CartService : BaseService<Cart, Database.Cart, CartSearchObject>, ICartService
    {
        public CartService(RentSistemDbContext context, IMapper mapper) : base(context, mapper) { }
        public override async Task<Cart> GetById(int userId)
        {
            var cartEntity = await _context.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Equipment)
                .FirstOrDefaultAsync(c => c.UserID == userId);

            if (cartEntity == null)
            {
                cartEntity = new Database.Cart
                {
                    UserID = userId,
                    DateAdded = DateTime.UtcNow,
                    TotalPrice = 0
                };

                _context.Carts.Add(cartEntity);
                await _context.SaveChangesAsync();
            }

            return _mapper.Map<Cart>(cartEntity);
        }

        public async Task<Cart> AddToCart(CartItemUpsertObject cartItem)
        {
            var existingCart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserID == cartItem.UserID);

            Database.Cart cartEntity;

            if (existingCart == null)
            {
                cartEntity = new Database.Cart
                {
                    UserID = cartItem.UserID,
                    DateAdded = DateTime.UtcNow,
                    TotalPrice = 0
                };

                _context.Carts.Add(cartEntity);
                await _context.SaveChangesAsync();
            }
            else
            {
                cartEntity = existingCart;
            }

            var existingCartItem = cartEntity.CartItems
                .FirstOrDefault(ci => ci.EquipmentID == cartItem.EquipmentID);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity += cartItem.Quantity;
                _context.CartItems.Update(existingCartItem);
            }
            else
            {
                var cartItemEntity = _mapper.Map<Database.CartItem>(cartItem);
                cartItemEntity.CartID = cartEntity.ID;
                _context.CartItems.Add(cartItemEntity);
            }

            // Recalculate the total price of the cart
            cartEntity.TotalPrice = 0;
            foreach (var item in cartEntity.CartItems)
            {
                // Load the Equipment entity for each cart item
                var equipment = await _context.Equipment.FindAsync(item.EquipmentID);
                if (equipment != null)
                {
                    var days = (item.EndDate - item.StartDate).Days;
                    cartEntity.TotalPrice += item.Quantity * equipment.CostPerUse * days;
                }
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<Cart>(cartEntity);
        }




        public async Task<Cart> RemoveFromCart(int cartItemID)
        {
            var existingCartItem = await _context.CartItems
                .Include(ci => ci.Equipment)
                .FirstOrDefaultAsync(ci => ci.ID == cartItemID);

            if (existingCartItem != null)
            {
                var cartID = existingCartItem.CartID;

                _context.CartItems.Remove(existingCartItem);
                await _context.SaveChangesAsync();

                var cartEntity = await _context.Carts
                    .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Equipment)
                    .FirstOrDefaultAsync(c => c.ID == cartID);

                if (cartEntity != null)
                {
                    cartEntity.TotalPrice = cartEntity.CartItems.Sum(ci =>
                    {
                        var days = (ci.EndDate - ci.StartDate).Days;
                        return ci.Quantity * ci.Equipment.CostPerUse * days;
                    });

                    await _context.SaveChangesAsync();
                }

                return _mapper.Map<Cart>(cartEntity);
            }

            return null;
        }



        public async Task EmptyCart(int id)
        {
            var cartEntity = await _context.Carts
           .Include(c => c.CartItems)
           .FirstOrDefaultAsync(c => c.ID == id);

            if (cartEntity == null)
            {
                throw new Exception("Cart not found.");
            }

            _context.CartItems.RemoveRange(cartEntity.CartItems);
            cartEntity.TotalPrice = 0;

            await _context.SaveChangesAsync();
        }
    }
}
