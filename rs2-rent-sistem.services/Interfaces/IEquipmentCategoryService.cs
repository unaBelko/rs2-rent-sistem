using rs2_rent_sistem.Model.Requests;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IEquipmentCategoryService : ICRUDService<Model.Models.EquipmentCategory, Model.SearchObjects.EquipmentCategorySearchObject, EquipmentCategoryUpsertObject, EquipmentCategoryUpsertObject>
    {
    }
}
