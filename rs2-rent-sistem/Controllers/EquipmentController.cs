using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    public class EquipmentController : BaseCRUDController<Equipment, EquipmentSearchObject, EquipmentUpsertObject, EquipmentUpsertObject>
    {
        public EquipmentController(ILogger<BaseController<Equipment, EquipmentSearchObject>> logger, IEquipmentService service) : base(logger, service)
        {
        }
    }
}
