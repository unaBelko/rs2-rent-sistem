using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Services.Interfaces;

namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManufacturerController : BaseCRUDController<rs2_rent_sistem.Model.Models.Manufacturer, rs2_rent_sistem.Model.SearchObjects.ManufacturerSearchObject, ManufacturerUpsertObject, ManufacturerUpsertObject>
    {
        public ManufacturerController(ILogger<BaseController<rs2_rent_sistem.Model.Models.Manufacturer, rs2_rent_sistem.Model.SearchObjects.ManufacturerSearchObject>> logger, IManufacturerService service) : base(logger, service)
        {
        }

        [Authorize(Roles = "employee")]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Disable(int id)
        {
            try
            {
                var success = await _service.Delete(id);
                if (success)
                {
                    return Ok();
                }
                else
                {
                    return NotFound(new { Message = "Manufacturer not found." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while disabling the manufacturer.", Details = ex.Message });
            }
        }

        [Authorize(Roles = "employee")]
        public override Task<Manufacturer> Insert([FromBody] ManufacturerUpsertObject insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "employee")]
        public override Task<Manufacturer> Update(int id, [FromBody] ManufacturerUpsertObject update)
        {
            return base.Update(id, update);
        }
    }
}
