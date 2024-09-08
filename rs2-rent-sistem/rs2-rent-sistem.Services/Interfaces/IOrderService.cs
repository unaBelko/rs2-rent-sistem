using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IOrderService : IService<Order, OrderSearchObject>
    {
        Task<Order> CreateOrder(int userId);
    }
}
