using DMS.Application.Common.Authorization;
using DMS.Application.Common.Responses;
using MediatR;

namespace DMS.Application.Common.Authentication.Queries
{
   public sealed class AuthenticateUserQuery: IRequest<Response<LoginResult>>
   {
      public string Email { get; set; }
      public string Password { get; set; }
   }
}
