using rs2_rent_sistem.Models.SearchObjects;
using rs2_rent_sistem.Services.Database;
using rs2_rent_sistem.Services.Interfaces;
using AutoMapper;
using rs2_rent_sistem.Services.Data;

namespace rs2_rent_sistem.Services.Services
{
    public class EquipmentService: BaseService<Models.Models.EquipmentCategory, EquipmentCategory, EquipmentCategorySearchObject>, IEquipmentService    
    {
        public EquipmentService(RentSistemDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override IQueryable<EquipmentCategory> AddFilter(IQueryable<Database.EquipmentCategory> query, EquipmentCategorySearchObject? search = null)
        {
            if (!string.IsNullOrWhiteSpace(search?.CategoryName))
            {
                query = query.Where(x => x.Name.StartsWith(search.CategoryName));
            }
            return base.AddFilter(query, search);
        }
    }
}
