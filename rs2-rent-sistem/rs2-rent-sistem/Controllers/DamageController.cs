using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rs2_rent_sistem.Model;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;
using rs2_rent_sistem_api.Controllers;

namespace rs2_rent_sistem.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DamageController : BaseController<Damage, DamageSearchObject>
    {
        public DamageController(ILogger<DamageController> logger, IDamageService service) : base(logger, service)
        {
        }

        [Authorize(Roles= "employee")]
        public override async Task<PageResult<Damage>> Get([FromQuery] DamageSearchObject? search = null)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (userId != null)
            {
                search.UserID = int.Parse(userId);
                var damages = await _service.Get(search);
                return damages;
            }
            else
            {
                return null;
            }
        }


        [HttpPost]
        public async Task ReportDamage(DamageInsertModel damage)
        {
            await ((IDamageService)_service).ReportDamage(damage);
        }
    }
}
