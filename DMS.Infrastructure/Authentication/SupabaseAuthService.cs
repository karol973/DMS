using DMS.Application.Common.Interfaces;
using DMS.Application.DTOs.Auth;
using Supabase;
namespace DMS.Application.Services.Auth
{
   public class SupabaseAuthService : IAuthService
   {
      private readonly Client _supabase;

      public SupabaseAuthService(string url, string publishableKey)
      {
         _supabase = new Client(url, publishableKey);
      }

      public async Task<LoginResult?> LoginAsync(string email, string password)
      {
         try
         {
            var session = await _supabase.Auth.SignIn(email, password);

            if (session == null || string.IsNullOrWhiteSpace(session.AccessToken))
            {
               return null;
            }

            return new LoginResult(session.AccessToken, session.RefreshToken ?? string.Empty);
         }

         catch
         {
            return null;
         }
      }
   }
}
