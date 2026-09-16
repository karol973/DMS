using DMS.Application.Common.Authorization;
using DMS.Application.Common.Interfaces;
using DMS.Domain.Entities;
using DMS.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Supabase;
namespace DMS.Infrastructure.Services.Auth
{
   public class SupabaseAuthService : IAuthService
   {
      private readonly Client _supabase;
      private readonly ILogger<SupabaseAuthService> _logger;
      private readonly IDmsDbContext _dmsDbContext;
      public SupabaseAuthService(string url, string publishableKey, ILogger<SupabaseAuthService> logger, IDmsDbContext _context)
      {
         _supabase = new Client(url, publishableKey);
         _logger = logger;
         _dmsDbContext = _context; 
      }

      public async Task<LoginResult?> LoginAsync(string email, string password)
      {
         try
         {
            Supabase.Gotrue.Session? session = await _supabase.Auth.SignIn(email, password);

            if (session == null || string.IsNullOrWhiteSpace(session.AccessToken) || string.IsNullOrWhiteSpace(session.RefreshToken))
            {
               return null;
            }

            if (!Guid.TryParse(session.User.Id, out Guid authUserId))
            {
               return null;
            }

            //User? user = await _dmsDbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.AuthUserId == authUserId);

            var user = await _dmsDbContext.Users
               .AsNoTracking()
               .Where(u => u.AuthUserId == authUserId)
               .Select(u => new
               {
                  u.Id,
                  u.Role,
                  PatientId = u.PatientUser != null ? (long?)u.PatientUser.PatientId : null
               })
               .FirstOrDefaultAsync();

            if (user == null)
            {
               return null;
            }

            //if (user.IsActive == false) -----> TO DO: dodać pole IsActive do usera
            //{
            //   return null;
            //}


            return new LoginResult(session.AccessToken, session.RefreshToken, user.Role, user.Id, user.PatientId);
         }

         catch (Exception ex)
         {
            _logger.LogError(ex, "Błąd podczas logowania użytkownika: {Email}", email);
            return null;
         }

      }
   }
}
