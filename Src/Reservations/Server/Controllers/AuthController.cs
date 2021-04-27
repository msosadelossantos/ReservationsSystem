using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Reservations.Aplication.Auth;
using Reservations.Shared.Generic;
using Reservations.Shared.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;


        public AuthController(
           IAuthService authService,
            IConfiguration configuration)
        {
            _authService = authService;
            _configuration = configuration;
        }

        [HttpPost("signup")]
        public async Task<ActionResult<ApiResult<UserDto>>> SignUpAsync([FromBody] RegisterDto model)
        {
            var result = await _authService.SignUp(model);

            if (result.Success)
            {
               
                return new ApiResult<UserDto>()
                {
                    Success = true,
                    Payload = result.Payload.User
                };
            }
            else
            {
                return new ApiResult<UserDto>()
                {
                    Success = false,
                    Messages = new MessageStruct[] { new MessageStruct("1", "Error: Something went wrong.") },
                    Payload = null
                };
            }



        }

        [HttpPost("login")]
        public async Task<ActionResult<ApiResult<UserToken>>> LoginAsync([FromBody] UserDto userInfo)
        {
            var result = await _authService.Login(userInfo);

            if (result.Success)
            {
                var token = BuildToken(userInfo);
                return new ApiResult<UserToken>()
                {
                    Success = true,
                    Payload = token
                };

            }
            else
            {
                return new ApiResult<UserToken>()
                {
                    Success = false,
                    Messages = new MessageStruct[] { new MessageStruct("1", "Error: Username or password is incorrect.")},
                    Payload = null
                };
            }

        }

        private UserToken BuildToken(UserDto userInfo)
        {
            var claims = new[]
            {
        new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.UserCode),
        new Claim(ClaimTypes.Name, userInfo.UserCode),
        new Claim("miValor", "Lo que yo quiera"),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Tiempo de expiración del token. En nuestro caso lo hacemos de una hora.
            var expiration = DateTime.UtcNow.AddYears(1);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }
    }
}
