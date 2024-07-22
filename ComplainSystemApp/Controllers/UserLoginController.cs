using ComplainSystem.Application.BusinessModels;
using ComplainSystem.Application.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplainSystemApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public UserLoginController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Authenicate")]
        public async Task<IActionResult> Authenticate(UserLogin userLogin)
        {
            var token = _tokenService.Authenticate(userLogin);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }

        //[HttpPost]
        //public async Task<IActionResult> RefreshToken(Tokens token)
        //{
        //    if (token.Token)
        //    {

        //    }
        //}
    }
}
