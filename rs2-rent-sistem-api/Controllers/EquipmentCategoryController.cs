using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Models.Requests;
using rs2_rent_sistem.Services.Interfaces;


namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentCategoryController : BaseCRUDController<rs2_rent_sistem.Models.Models.EquipmentCategory, rs2_rent_sistem.Models.SearchObjects.EquipmentCategorySearchObject, EquipmentCategoryUpsertObject, EquipmentCategoryUpsertObject>
    {
        public EquipmentCategoryController(ILogger<BaseController<rs2_rent_sistem.Models.Models.EquipmentCategory, rs2_rent_sistem.Models.SearchObjects.EquipmentCategorySearchObject>> logger, IEquipmentCategoryService service) : base(logger, service)
        {
        }
    }
}