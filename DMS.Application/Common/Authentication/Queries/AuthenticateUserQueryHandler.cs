using DMS.Application.Common.Authorization;
using DMS.Application.Common.Interfaces;
using DMS.Application.Common.Responses;
using MediatR;

namespace DMS.Application.Common.Authentication.Queries
{
   internal sealed class AuthenticateUserQueryHandler : IRequestHandler<AuthenticateUserQuery, Response<LoginResult>>
   {
      private IAuthService _authService;
      public AuthenticateUserQueryHandler(IAuthService authService)
      {
         _authService = authService;
      }

      public async Task<Response<LoginResult>> Handle(AuthenticateUserQuery request, CancellationToken cancellationToken)
      {
         LoginResult? loginResult = await _authService.LoginAsync(request.Email, request.Password);

         if (loginResult is null)
         {
            return Response<LoginResult>.Failure("Nieprawidłowy email lub hasło.");
         }

         return Response<LoginResult>.Success(loginResult);
      }
   }
}
