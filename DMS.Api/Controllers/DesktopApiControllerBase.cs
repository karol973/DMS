using DMS.Infrastructure.Authentication.Policies;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace DMS.Api.Controllers
{
   [Authorize(Policy = DmsPolicies.DesktopAccess)]
   public abstract class DesktopApiControllerBase : ApiControllerBase
   {
      public DesktopApiControllerBase(IMediator mediator) : base(mediator)
      {
      }
   }
}
