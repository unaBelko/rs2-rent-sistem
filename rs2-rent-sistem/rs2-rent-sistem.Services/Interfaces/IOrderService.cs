using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IOrderService : IService<Order, OrderSearchObject>
    {
        Task<Order> CreateOrder(OrderCreationRequest request);
    }
}
