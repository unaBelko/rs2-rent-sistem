using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using rs2_rent_sistem.Model.Models;
using rs2_rent_sistem.Model.Requests;
using rs2_rent_sistem.Model.SearchObjects;
using rs2_rent_sistem.Services.Interfaces;
using rs2_rent_sistem_api.Controllers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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
            var user = await _userService.Login(request.Email, request.Password);

            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            var token = GenerateJwtToken(user);

            return Ok(new
            {
                Token = token,
                //Roles = new List<Role>()
                ////Roles = user.Roles
            });
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.ID.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(5),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Issuer"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public override Task<User> Insert([FromBody] UserUpsertObject insert)
        {
            return base.Insert(insert);
        }
    }
}
