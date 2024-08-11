using rs2_rent_sistem.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IEquipmentCategoryService : ICRUDService<Models.Models.EquipmentCategory, Models.SearchObjects.EquipmentCategorySearchObject, EquipmentCategoryUpsertObject, EquipmentCategoryUpsertObject>
    {
    }
}
