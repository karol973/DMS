using DMS.Application.Common.Authorization;

namespace DMS.Application.Common.Interfaces
{
   public interface IAuthService
   {
      Task<LoginResult?> LoginAsync(string email, string password);
   }
}
