using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Services.Interfaces;


namespace rs2_rent_sistem_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentCategoryController : BaseCRUDController<rs2_rent_sistem.Model.Models.EquipmentCategory, rs2_rent_sistem.Model.SearchObjects.EquipmentCategorySearchObject, EquipmentCategoryUpsertObject, EquipmentCategoryUpsertObject>
    {
        public EquipmentCategoryController(ILogger<BaseController<rs2_rent_sistem.Model.Models.EquipmentCategory, rs2_rent_sistem.Model.SearchObjects.EquipmentCategorySearchObject>> logger, IEquipmentCategoryService service) : base(logger, service)
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
                    return NotFound(new { Message = "Equipment category not found." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while disabling the equipment category.", Details = ex.Message });
            }
        }

        [Authorize(Roles = "employee")]
        public override Task<EquipmentCategory> Insert([FromBody] EquipmentCategoryUpsertObject insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "employee")]
        public override Task<EquipmentCategory> Update(int id, [FromBody] EquipmentCategoryUpsertObject update)
        {
            return base.Update(id, update);
        }
    }
}