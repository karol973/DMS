using DMS.Application.Patients.Queries.GetPatientById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Api.Controllers.Portal
{
   public class PatientProfileController : DesktopApiControllerBase
   {
      public PatientProfileController(IMediator mediator) : base(mediator)
      {
      }

      [HttpGet("{id:long}/patientdata")]
      public Task<IActionResult> GetPatientByIdAsync(long id)
      {
         return HandleAsync(new GetPatientByIdQuery
         {
            PatientId = id
         });
      }
   }
}
