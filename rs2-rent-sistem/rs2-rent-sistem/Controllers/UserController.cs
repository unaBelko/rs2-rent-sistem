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
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseCRUDController<User, UserSearchObject, UserUpsertObject, UserUpsertObject>
    {
        private readonly IUsersService _userService;
        private readonly IConfiguration _configuration;

        public UserController(ILogger<BaseController<User, UserSearchObject>> logger, IUsersService service, IConfiguration configuration)
            : base(logger, service)
        {
            _userService = service;
            _configuration = configuration;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var token = await _userService.Login(request.Email, request.Password);

            if (token == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            return Ok(new
            {
                Token = token,
                //Roles = new List<Role>()
                ////Roles = user.Roles
            });
        }

        [Authorize(Roles = "employee")]
        [HttpGet]
        public override async Task<PageResult<User>> Get([FromQuery] UserSearchObject? search = null)
        {
            return await base.Get(search);
        }

        public override Task<User> Insert([FromBody] UserUpsertObject insert)
        {
            return base.Insert(insert);
        }
    }
}
