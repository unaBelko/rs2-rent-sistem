using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    public class ManufacturerController : BaseCRUDController<rs2_rent_sistem.Model.Models.Manufacturer, rs2_rent_sistem.Model.SearchObjects.ManufacturerSearchObject, ManufacturerUpsertObject, ManufacturerUpsertObject>
    {
        public ManufacturerController(ILogger<BaseController<rs2_rent_sistem.Model.Models.Manufacturer, rs2_rent_sistem.Model.SearchObjects.ManufacturerSearchObject>> logger, IManufacturerService service) : base(logger, service)
        {
        }
    }
}
