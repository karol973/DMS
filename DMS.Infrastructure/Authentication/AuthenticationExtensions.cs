using DMS.Application.Common.Authorization;
using DMS.Domain.Enums;
using DMS.Infrastructure.Authentication.Claims;
using DMS.Infrastructure.Authentication.Policies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace DMS.Infrastructure.Authentication;

public static class AuthenticationExtensions
{
   public static IServiceCollection AddDmsAuthentication(this IServiceCollection services, string issuer, IEnumerable<SecurityKey> signingKeys)
   {
      services
         .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
         .AddJwtBearer(options =>
         {
            options.MapInboundClaims = false;

            options.TokenValidationParameters =
               new TokenValidationParameters
               {
                  ValidateIssuer = true,
                  ValidIssuer = issuer,

                  ValidateAudience = true,
                  ValidAudience = "authenticated",

                  ValidateLifetime = true,

                  ValidateIssuerSigningKey = true,
                  IssuerSigningKeys = signingKeys,

                  RoleClaimType = DmsClaimTypes.Role,

                  ClockSkew = TimeSpan.FromMinutes(2)
               };
         });

      services.AddAuthorization(options =>
      {
         options.DefaultPolicy =
             new AuthorizationPolicyBuilder(
                 JwtBearerDefaults.AuthenticationScheme)
             .RequireAuthenticatedUser()
             .RequireClaim(DmsClaimTypes.UserId)
             .RequireClaim(DmsClaimTypes.Role)
             .Build();

         options.AddPolicy(DmsPolicies.DesktopAccess, policy =>
         {
            policy.RequireAuthenticatedUser();

            policy.RequireRole(
               nameof(UserRole.Admin),
               nameof(UserRole.Doctor));
         });

         options.AddPolicy(DmsPolicies.PatientPortal, policy =>
         {
            policy.RequireAuthenticatedUser();

            policy.RequireRole(
               nameof(UserRole.Patient));
         });
      });
     
      services.AddScoped<IClaimsTransformation, DmsClaimsTransformation>();

      services.AddHttpContextAccessor();

      services.AddScoped<CurrentUser, HttpCurrentUser>();

      return services;
   }
}