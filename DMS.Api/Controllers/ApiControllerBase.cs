using DMS.Application.Common.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Api.Controllers
{
   [ApiController]
   public abstract class ApiControllerBase : ControllerBase
   {
      private readonly IMediator _mediator;

      protected ApiControllerBase(IMediator mediator)
      {
         _mediator = mediator;
      }

      protected async Task<IActionResult> HandleAsync(IRequest<Response> request, CancellationToken cancellationToken = default)
      {
         Response response = await _mediator.Send(request, cancellationToken);

         if (!response.IsSuccess)
         {
            return BadRequest(response);
         }

         return Ok(response);
      }

      protected async Task<IActionResult> HandleAsync<T>(IRequest<Response<T>> request, CancellationToken cancellationToken = default)
      {
         Response<T> response = await _mediator.Send(request, cancellationToken);

         if (!response.IsSuccess)
         {
            return BadRequest(response);
         }

         return Ok(response);
      }
   }
}