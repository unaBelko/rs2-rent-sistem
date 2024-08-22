using AutoMapper;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class EquipmentCategoryService : CRUDService<Model.Models.EquipmentCategory, Database.EquipmentCategory, Model.SearchObjects.EquipmentCategorySearchObject, EquipmentCategoryUpsertObject, EquipmentCategoryUpsertObject>, IEquipmentCategoryService
    {
        public EquipmentCategoryService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
