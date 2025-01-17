using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public override IQueryable<Database.EquipmentCategory> AddFilter(IQueryable<Database.EquipmentCategory> query, Model.SearchObjects.EquipmentCategorySearchObject? search = null)
        {
            query = query.Where(ec => !ec.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search?.CategoryName))
            {
                query = query.Where(ec => ec.Name.Contains(search.CategoryName));
            }

            return base.AddFilter(query, search);
        }

        public async Task<bool> SoftDelete(int id)
        {
            var equipmentCategory = await _context.EquipmentCategories.FirstOrDefaultAsync(ec => ec.ID == id);

            if (equipmentCategory == null)
            {
                return false;
            }

            equipmentCategory.IsDeleted = true;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
