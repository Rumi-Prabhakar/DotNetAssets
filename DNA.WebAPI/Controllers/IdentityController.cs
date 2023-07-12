using DNA.Services;
using DNA.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace DNA.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/Identity")]
    [ApiController]
    public class IdentityController : Controller
    {
        IUserService _userService;
        IConfiguration _config;
        public IdentityController(IConfiguration config, IUserService userService) 
        {
            _config = config;
            _userService = userService;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromQuery] string username, [FromQuery] string password)
        {
            var userIdentity = await _userService.VerifyUser(username, password);
            if(!userIdentity.IsAuthenticated) 
            {
                throw new Exception("Login failed !");
            }

            //-----------Generate Jwt Token--------------------------------------
            
            var userClaims = new Dictionary<string, object>
            {
                { JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString() },
                { JwtRegisteredClaimNames.Sub, userIdentity.Username },
                { JwtRegisteredClaimNames.Email, userIdentity.EmailAddress },
                { "isAdmin", "true" }
            };


            var secret = _config["JwtSettings:Key"];
            var tokenHandler = new JwtSecurityTokenHandler();
            var secretKey = new SymmetricSecurityKey(Convert.FromBase64String(secret));
                                                
            var tokenDescriptor = new SecurityTokenDescriptor
            { 
                Subject = new ClaimsIdentity(new Claim[]
                { 
                    new Claim(ClaimTypes.NameIdentifier, userIdentity.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                Issuer = _config["JwtSettings:Issuer"],
                Audience = _config["JwtSettings:Audience"],
                Claims = userClaims,
                SigningCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return Ok(tokenHandler.WriteToken(token));
        }

    }    
}
