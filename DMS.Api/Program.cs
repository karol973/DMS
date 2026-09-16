using DMS.Application.Common.Interfaces;
using DMS.Application.Patients.Commands.CreatePatient;
using DMS.Infrastructure.Authentication;
using DMS.Infrastructure.Persistance;
using DMS.Infrastructure.Services.Auth;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);

// CONFIGURATION

string supabaseUrl = builder.Configuration["Supabase:Url"]
?? throw new InvalidOperationException(
        "Brak Supabase:Url w konfiguracji.");

string publishableKey = builder.Configuration["Supabase:PublishableKey"]
    ?? throw new InvalidOperationException(
        "Brak Supabase:PublishableKey w konfiguracji.");

string connectionString = builder.Configuration.GetConnectionString("Supabase")
    ?? throw new InvalidOperationException(
        "Brak ConnectionStrings:Supabase.");
var issuer = $"{supabaseUrl}/auth/v1";
var jwksUrl = $"{issuer}/.well-known/jwks.json";

using var httpClient = new HttpClient();

var jwksJson = await httpClient.GetStringAsync(jwksUrl);

var jwks = new JsonWebKeySet(jwksJson);
// API

builder.Services.AddMediatR(typeof(CreatePatientCommand));
builder.Services.AddEndpointsApiExplorer();
 
builder.Services.AddSwaggerGen(options =>
{
   options.AddSecurityDefinition(
       "Bearer",
       new OpenApiSecurityScheme
       {
          Name = "Authorization",
          Type = SecuritySchemeType.Http,
          Scheme = "bearer",
          BearerFormat = "JWT",
          In = ParameterLocation.Header,
          Description = "Wpisz access token JWT"
       });

   options.AddSecurityRequirement(
       new OpenApiSecurityRequirement
       {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
       });
});


// AUTH

builder.Services.AddScoped<IAuthService>(provider =>
{
   var logger = provider.GetRequiredService<ILogger<SupabaseAuthService>>();
   var dmsDbContext = provider.GetRequiredService<IDmsDbContext>();
   
   return new SupabaseAuthService(
       supabaseUrl,
       publishableKey,
       logger,
       dmsDbContext
   );
});

builder.Services.AddDmsAuthentication(
    issuer,
    jwks.GetSigningKeys()
);

builder.Services.AddCors(options =>
{
   options.AddPolicy("AngularClientWeb", policy =>
   {
      policy
         .WithOrigins("http://localhost:4200")
         .AllowAnyHeader()
         .AllowAnyMethod();
   });
});

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
       options.JsonSerializerOptions.Converters
           .Add(new JsonStringEnumConverter());
    });

// DATABASE

builder.Services.AddDbContext<DmsDbContext>(options =>
{
   options.UseNpgsql(connectionString);
});

builder.Services.AddScoped<IDmsDbContext>(provider =>
    provider.GetRequiredService<DmsDbContext>());


var app = builder.Build();


// PIPELINE

if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AngularClientWeb");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();