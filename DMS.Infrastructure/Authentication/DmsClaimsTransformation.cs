using DMS.Application.Common.Interfaces;
using DMS.Domain.Enums;
using DMS.Infrastructure.Authentication.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace DMS.Infrastructure.Authentication;

public sealed class DmsClaimsTransformation : IClaimsTransformation
{
   private readonly IDmsDbContext _dbContext;
   private readonly ILogger<DmsClaimsTransformation> _logger;

   public DmsClaimsTransformation(IDmsDbContext dbContext, ILogger<DmsClaimsTransformation> logger)
   {
      _dbContext = dbContext;
      _logger = logger;
   }

   public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
   {
      if (principal.Identity is not ClaimsIdentity identity || !identity.IsAuthenticated)
      {
         return principal;
      }

      if (principal.HasClaim(
              claim => claim.Type == DmsClaimTypes.UserId)
          && principal.HasClaim(
              claim => claim.Type == DmsClaimTypes.Role))
      {
         return principal;
      }

      string? supabaseUserIdValue = principal.FindFirst(DmsClaimTypes.Subject)?.Value;

      if (string.IsNullOrWhiteSpace(supabaseUserIdValue))
      {
         _logger.LogWarning("Brak sub w tokenie JWT");

         return principal;
      }

      if (!Guid.TryParse(supabaseUserIdValue, out Guid authUserId))
      {
         _logger.LogWarning("Nieprawidłowy format UUID");

         return principal;
      }

      var user = await _dbContext.Users
          .AsNoTracking()
          .Where(x => x.AuthUserId == authUserId)
          .Select(x => new
          {
             x.Id,
             x.FirstName,
             x.LastName,
             x.Role,
             PatientId = x.PatientUser != null
            ? x.PatientUser.PatientId
            : (long?)null
          })
          .SingleOrDefaultAsync();

      if (user is null)
      {
         _logger.LogWarning("Użytkownik Supabase {AuthUserId} " + "nie ma wpisu w DMS.", authUserId);

         return principal;
      }

      if (user.Role == UserRole.Patient && user.PatientId is null)
      {
         _logger.LogWarning("Użytkownik DMS {UserId} ma rolę Patient, " + "ale nie posiada konta.", user.Id);

         return principal;
      }

      string roleName = user.Role.ToString();

      if (!identity.HasClaim(claim => claim.Type == DmsClaimTypes.Role))
      {
         identity.AddClaim(new Claim(DmsClaimTypes.Role, roleName));
      }

      if (!identity.HasClaim(claim => claim.Type == DmsClaimTypes.UserId))
      {
         identity.AddClaim(new Claim(DmsClaimTypes.UserId, user.Id.ToString()));
      }

      if (user.PatientId is long patientId && !identity.HasClaim(claim => claim.Type == DmsClaimTypes.PatientId))
      {
         identity.AddClaim(new Claim(DmsClaimTypes.PatientId, patientId.ToString()));
      }

      if (!string.IsNullOrWhiteSpace(user.FirstName) && !identity.HasClaim(ClaimTypes.GivenName, user.FirstName))
      {
         identity.AddClaim(new Claim(ClaimTypes.GivenName, user.FirstName));
      }

      if (!string.IsNullOrWhiteSpace(user.LastName) && !identity.HasClaim(ClaimTypes.Surname, user.LastName))
      {
         identity.AddClaim(new Claim(ClaimTypes.Surname, user.LastName));
      }

      return principal;
   }
}