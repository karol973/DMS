using DMS.Application.Common.Authentication.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Api.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class AuthController : ApiControllerBase
   {
      public AuthController(IMediator mediator) : base(mediator)
      {
      }

      [HttpPost("login")]
      public Task<IActionResult> Login([FromBody] AuthenticateUserQuery query)
      {
         return HandleAsync(query);
         
      }
   }
}
