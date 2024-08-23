using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface ICartService : IService<Cart, CartSearchObject>
    {
        Task<Cart> AddToCart(CartItemUpsertObject cartItem);

        Task<Cart> RemoveFromCart(int cartItemId);
        Task EmptyCart(int id);
    }
}
