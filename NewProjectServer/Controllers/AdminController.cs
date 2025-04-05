using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using NewDatabaseModel;
using NewProjectServer.Dtos;

namespace NewProjectServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class AdminController(UserManager<WorldCitiesUser> userManager, JwtHandler jwtHandler) : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<ActionResult> LoginAsync(LoginRequestDto request)
        {
            WorldCitiesUser user = await userManager.FindByNameAsync(request.UserName);
            if (user == null) {
                return Unauthorized("Unkwown User");
            }
            bool success =  await userManager.CheckPasswordAsync(user, request.Password);
            if (!success) {
                return Unauthorized("Bad Password");
            }
            JwtSecurityToken token = await jwtHandler.GetTokenAsync(user);
            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(new LoginResult
            {
                Success = true,
                Message = "Hello",
                Token = tokenString

            }

                );
        }
    }
}