using AutoMapper;
using Microsoft.EntityFrameworkCore;
using rs2_rent_sistem.Models.Models;
using rs2_rent_sistem.Models.Requests;
using rs2_rent_sistem.Models.SearchObjects;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class CartService : BaseService<Cart, Database.Cart, CartSearchObject>, ICartService
    {
        public CartService(RentSistemDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<Cart> GetById(int id)
        {
            // Fetch the Cart including its CartItems and the associated Equipment using Entity Framework
            var cartEntity = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Equipment)  // Include the Equipment related to CartItems
                .FirstOrDefaultAsync(c => c.ID == id);

            // If cartEntity is null, handle accordingly (e.g., return null or throw an exception)
            if (cartEntity == null)
            {
                return null; // Or throw a NotFoundException, etc.
            }

            // Map the entity to the DTO
            return _mapper.Map<Cart>(cartEntity);
        }

        public async Task<Cart> AddToCart(CartItemUpsertObject cartItem)
        {
            // Create or find the default user (replace this with your logic to get the current user)
            var defaultUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == "defaultuser@example.com");
            if (defaultUser == null)
            {
                defaultUser = new Database.User
                {
                    FirstName = "Default",
                    LastName = "User",
                    Email = "defaultuser@example.com",
                    IsActive = true
                };
                _context.Users.Add(defaultUser);
                await _context.SaveChangesAsync();
            }

            // Check if the user already has a cart
            var existingCart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.UserID == defaultUser.ID);

            Database.Cart cartEntity;

            if (existingCart == null)
            {
                // Create a new cart for the user
                var newCart = new Database.Cart
                {
                    UserID = defaultUser.ID,
                    DateAdded = DateTime.UtcNow,
                };

                // Map the DTO Cart to Database Cart entity
                cartEntity = _mapper.Map<Database.Cart>(newCart);
                _context.Carts.Add(cartEntity);
                await _context.SaveChangesAsync(); // Save to get the CartID
            }
            else
            {
                cartEntity = existingCart;
            }

            // Map CartItem DTO to Database CartItem entity
            var cartItemEntity = _mapper.Map<Database.CartItem>(cartItem);
            cartItemEntity.CartID = cartEntity.ID;

            _context.CartItems.Add(cartItemEntity);
            await _context.SaveChangesAsync();

            // Return the updated Cart mapped to the DTO
            return _mapper.Map<Cart>(cartEntity);
        }

        public async Task<Cart> RemoveFromCart(CartItem cartItem)
        {
            // Map CartItem DTO to Database CartItem entity
            var cartItemEntity = _mapper.Map<Database.CartItem>(cartItem);

            // Retrieve the cart item from the database
            var existingCartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.CartID == cartItemEntity.CartID && ci.EquipmentID == cartItemEntity.EquipmentID);

            if (existingCartItem != null)
            {
                _context.CartItems.Remove(existingCartItem);
                await _context.SaveChangesAsync();
            }

            // Retrieve the cart and map it back to the Cart DTO
            var cartEntity = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.ID == cartItemEntity.CartID);

            return _mapper.Map<Cart>(cartEntity);
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
