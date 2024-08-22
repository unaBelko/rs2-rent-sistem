using rs2_rent_sistem.Model.Requests;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IEquipmentService : ICRUDService<Model.Models.Equipment, Model.SearchObjects.EquipmentSearchObject, EquipmentUpsertObject, EquipmentUpsertObject>
    {
    }
}
