using DMS.Application.Common.Interfaces;
using DMS.Application.Services.Auth;
using DMS.Infrastructure.Persistance;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using DMS.Application.Patients.Commands.CreatePatient;
using MediatR;
var builder = WebApplication.CreateBuilder(args);

// CONFIGURATION

string supabaseUrl =
    builder.Configuration["Supabase:Url"]
    ?? throw new InvalidOperationException(
        "Brak Supabase:Url w konfiguracji.");

string publishableKey =
    builder.Configuration["Supabase:PublishableKey"]
    ?? throw new InvalidOperationException(
        "Brak Supabase:PublishableKey w konfiguracji.");

string connectionString =
    builder.Configuration.GetConnectionString("Supabase")
    ?? throw new InvalidOperationException(
        "Brak ConnectionStrings:Supabase.");


// API

builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(CreatePatientCommand));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// AUTH

builder.Services.AddScoped<IAuthService>(_ =>
    new SupabaseAuthService(
        supabaseUrl,
        publishableKey
    ));

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
       options.Authority = $"{supabaseUrl}/auth/v1";
       options.Audience = "authenticated";
    });

builder.Services.AddAuthorization();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();