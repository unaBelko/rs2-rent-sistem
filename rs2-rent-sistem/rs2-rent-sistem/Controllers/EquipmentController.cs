using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    public class EquipmentController : BaseCRUDController<Equipment, EquipmentSearchObject, EquipmentUpsertObject, EquipmentUpsertObject>
    {
        public EquipmentController(ILogger<BaseController<Equipment, EquipmentSearchObject>> logger, IEquipmentService service) : base(logger, service) { }

        [HttpGet("{id}/recommend")]
        public async Task<ActionResult<rs2_rent_sistem.Model.PageResult<Equipment>>> Recommend(int id)
        {
            var result = await (_service as IEquipmentService).GetRecommended(id);
            return Ok(result);
        }

        [Authorize(Roles = "employee")]
        [HttpPost]
        public override Task<Equipment> Insert([FromBody] EquipmentUpsertObject insert)
        {
            return base.Insert(insert);
        }
    }
}
