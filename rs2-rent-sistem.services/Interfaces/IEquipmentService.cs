using rs2_rent_sistem.Models.Requests;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IEquipmentService : ICRUDService<Models.Models.Equipment, Models.SearchObjects.EquipmentSearchObject, EquipmentUpsertObject, EquipmentUpsertObject>
    {
    }
}
