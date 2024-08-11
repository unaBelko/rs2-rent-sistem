using AutoMapper;
using rs2_rent_sistem.Models.Requests;
using rs2_rent_sistem.Services.Data;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem.Services.Services
{
    public class EquipmentCategoryService : CRUDService<Models.Models.EquipmentCategory,Database.EquipmentCategory ,Models.SearchObjects.EquipmentCategorySearchObject, EquipmentCategoryUpsertObject, EquipmentCategoryUpsertObject>, IEquipmentCategoryService
    {
        public EquipmentCategoryService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
