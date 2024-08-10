using rs2_rent_sistem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs2_rent_sistem.Services.Interfaces
{
    public interface IEquipmentService : IService<Models.Models.EquipmentCategory, Models.SearchObjects.EquipmentCategorySearchObject>
    {
    }
}
