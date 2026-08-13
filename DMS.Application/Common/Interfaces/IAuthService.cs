using DMS.Application.DTOs.Auth;

namespace DMS.Application.Common.Interfaces
{
   public interface IAuthService
   {
      Task<LoginResult?> LoginAsync(string email, string password);
   }
}
