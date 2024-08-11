using rs2_rent_sistem.Models.Requests;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    public class ManufacturerController : BaseCRUDController<rs2_rent_sistem.Models.Models.Manufacturer, rs2_rent_sistem.Models.SearchObjects.ManufacturerSearchObject, ManufacturerUpsertObject, ManufacturerUpsertObject>
    {
        public ManufacturerController(ILogger<BaseController<rs2_rent_sistem.Models.Models.Manufacturer, rs2_rent_sistem.Models.SearchObjects.ManufacturerSearchObject>> logger, IManufacturerService service) : base(logger, service)
        {
        }
    }
}
