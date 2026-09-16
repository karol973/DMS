using DMS.Application.Common.Authorization;
using DMS.Domain.Enums;
using DMS.Infrastructure.Authentication.Claims;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace DMS.Infrastructure.Authentication
{
   public sealed class HttpCurrentUser : CurrentUser
   {
      private readonly IHttpContextAccessor _httpContextAccessor;

      public HttpCurrentUser(IHttpContextAccessor httpContextAccessor)
      {
         _httpContextAccessor = httpContextAccessor;
      }
      private ClaimsPrincipal User => _httpContextAccessor.HttpContext!.User;

      public override long UserId
      {
         get
         {
            var value = User.FindFirst(DmsClaimTypes.UserId)?.Value;
            return long.Parse(value!);
         }
      }

      public override long? PatientId
      {
         get
         {
            var value = User.FindFirst(DmsClaimTypes.PatientId)?.Value;

            return long.TryParse(value, out var id)
                ? id
                : null;
         }
      }

      public override UserRole Role
      {
         get
         {
            var value = User.FindFirst(DmsClaimTypes.Role)?.Value; 

            if (string.IsNullOrEmpty(value))
            {
               throw new UnauthorizedAccessException("Brak roli DMS użytkownika.");
            }

            return Enum.Parse<UserRole>(value);
         }
      }
   }
}
