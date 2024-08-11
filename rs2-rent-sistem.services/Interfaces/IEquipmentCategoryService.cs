using rs2_rent_sistem.Models.Requests;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IEquipmentCategoryService : ICRUDService<Models.Models.EquipmentCategory, Models.SearchObjects.EquipmentCategorySearchObject, EquipmentCategoryUpsertObject, EquipmentCategoryUpsertObject>
    {
    }
}
