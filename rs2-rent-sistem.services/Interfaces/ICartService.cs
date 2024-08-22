using rs2_rent_sistem.Models.Models;
using rs2_rent_sistem.Models.Requests;
using rs2_rent_sistem.Models.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface ICartService : IService<Cart, CartSearchObject>
    {
        Task<Cart> AddToCart(CartItemUpsertObject cartItem);

        Task<Cart> RemoveFromCart(CartItem cartItem);
        Task EmptyCart(int id);
    }
}
