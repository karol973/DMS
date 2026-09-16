using DMS.Application.Patients.Queries.GetPatient;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Api.Controllers.Desktop
{
   [Route("api/desktop/patients")]
   public class PatientController : DesktopApiControllerBase
   {
      public PatientController(IMediator mediator) : base(mediator)
      {
      }

      [HttpGet()]
      public Task<IActionResult> GetPatientsAsync()
      {
         return HandleAsync(new GetPatientQuery());
      }
   }
}
