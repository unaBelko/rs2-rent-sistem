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
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController<User, UserSearchObject>
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
                return Unauthorized(new { Message = "Invalid email or password." });
            }

            return Ok(new
            {
                Token = token,
            });
        }

        [Authorize(Roles = "employee")]
        [HttpGet]
        public override async Task<PageResult<User>> Get([FromQuery] UserSearchObject? search = null)
        {
            return await base.Get(search);
        }

        [Authorize]
        [HttpGet("GetCurrentUser")]
        public async Task<User?> GetCurrentUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (userId != null) {
                return await _userService.GetById(int.Parse(userId));
            }
            else
            {
                return null;
            }
        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] UserUpsertObject insert)
        {
            try
            {
                var user = await _userService.Insert(insert);
                return Ok(user);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("email address already exists"))
                {
                    return BadRequest(new { Message = "A user with this email address already exists." });
                }

                return StatusCode(500, new { Message = "An error occurred while processing the request.", Details = ex.Message });
            }
        }
    }
}
