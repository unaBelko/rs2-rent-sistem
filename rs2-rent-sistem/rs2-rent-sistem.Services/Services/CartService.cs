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

        public override async Task<Cart> GetById(int id)
        {
            var cartEntity = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Equipment)
                .FirstOrDefaultAsync(c => c.ID == id);

            if (cartEntity == null)
            {
                return null;
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

            await _context.SaveChangesAsync();

            return _mapper.Map<Cart>(cartEntity);
        }


        public async Task<Cart> RemoveFromCart(int cartItemID)
        {
            var existingCartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.ID == cartItemID);

            if (existingCartItem != null)
            {
                var cartID = existingCartItem.CartID;

                _context.CartItems.Remove(existingCartItem);
                await _context.SaveChangesAsync();

                var cartEntity = await _context.Carts
                    .Include(c => c.CartItems)
                    .FirstOrDefaultAsync(c => c.ID == cartID);

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

            await _context.SaveChangesAsync();
        }
    }
}
