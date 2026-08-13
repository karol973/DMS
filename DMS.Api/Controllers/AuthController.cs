using DMS.Application.Common.Interfaces;
using DMS.Application.DTOs.Auth;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Api.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class AuthController : ControllerBase
   {
      IAuthService _authService;

      public AuthController(IAuthService authService)
      {
         _authService = authService;
      }

      [HttpPost("login")]
      public async Task<IActionResult> Login([FromBody] LoginRequest request)
      {
         LoginResult? result = await _authService.LoginAsync(
            request.Email, request.Password);

         if (result is null)
         {
            return Unauthorized(new
            {
               message = "Nieprawidłowy login lub hasło"
            });
         }
         return Ok(result);
      }
   }
}
