using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : BaseController<rs2_rent_sistem.Models.Models.EquipmentCategory, rs2_rent_sistem.Models.SearchObjects.EquipmentCategorySearchObject>
    {
        public EquipmentController(ILogger<BaseController<rs2_rent_sistem.Models.Models.EquipmentCategory, rs2_rent_sistem.Models.SearchObjects.EquipmentCategorySearchObject>> logger, IEquipmentService service) : base(logger, service)
        {
        }
    }
}