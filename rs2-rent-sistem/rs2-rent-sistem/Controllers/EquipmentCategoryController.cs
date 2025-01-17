using Microsoft.AspNetCore.Mvc;
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

        //[Authorize(Roles = "employee")]
        //[HttpDelete("Disable/{id}")]
        //public async Task<IActionResult> Disable(int id)
        //{
        //    try
        //    {
        //        var success = await _service.SoftDelete(id); // Call the SoftDelete method from the service
        //        if (success)
        //        {
        //            return Ok(new { Message = "Equipment category has been disabled successfully." });
        //        }
        //        else
        //        {
        //            return NotFound(new { Message = "Equipment category not found." });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { Message = "An error occurred while disabling the equipment category.", Details = ex.Message });
        //    }
        //}
    }
}