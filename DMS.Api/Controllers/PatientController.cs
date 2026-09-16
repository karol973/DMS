using DMS.Application.Patients.Commands.CreatePatient;
using DMS.Application.Patients.Queries.GetPatientById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace DMS.Api.Controllers
{
   [Route("api/[controller]")]
   public class PatientController : ApiControllerBase
   {
      public PatientController(IMediator mediator) : base(mediator)
      {
      }

      [HttpPost]
      public Task<IActionResult> CreateAsync([FromBody] CreatePatientCommand command, CancellationToken cancellationToken)
      {
         return HandleAsync(command, cancellationToken);
      }

      [HttpGet("{id:long}/patientdata")]
      public Task<IActionResult> GetPatientByIdAsync(long id)
      {
         return HandleAsync(new GetPatientByIdQuery{
            PatientId = id
         });
      }

      [Authorize]     
      [HttpGet("test-auth")]
      public IActionResult TestAuth()
      {
         return Ok(new
         {
            IsAuthenticated = User.Identity?.IsAuthenticated,
            Claims = User.Claims.Select(c => new
            {
               c.Type,
               c.Value
            })
         });

      }
   }
}
