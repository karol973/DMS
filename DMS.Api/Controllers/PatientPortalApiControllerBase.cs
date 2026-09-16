using DMS.Infrastructure.Authentication.Policies;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace DMS.Api.Controllers
{
   [Authorize(Policy = DmsPolicies.PatientPortal)]
   public abstract class PatientPortalApiControllerBase : ApiControllerBase
   {
      protected PatientPortalApiControllerBase(IMediator mediator) : base(mediator)
      {
      }
   }
}
