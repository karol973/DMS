using DMS.Application.Patients.Commands.CreatePatient;
using DMS.Application.Patients.Queries.GetPatient;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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

      [HttpGet("patients")]
      public Task<IActionResult> GetPatientsAsync()
      {
         return HandleAsync(new GetPatientQuery());
      }
   }
}
