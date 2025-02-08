using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.SearchObjects;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IOrderItemsService : IService<OrderItem, OrderItemSearchObject>
    {
        Task MarkOrderItemAsReviewed(int orderItemId);
        Task MarkOrderItemAsDamaged(int orderItemId);
    }
}
