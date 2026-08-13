using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace DMS.Api.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class TestController : ControllerBase
   {
      private readonly IConfiguration _configuration;

      public TestController(IConfiguration configuration)
      {
         _configuration = configuration;
      }

      [HttpGet]
      public async Task<IActionResult> TestConnection()
      {
         try
         {
            var connectionString =
                _configuration.GetConnectionString("Supabase");

            await using var connection =
                new NpgsqlConnection(connectionString);

            await connection.OpenAsync();

            await using var command =
                new NpgsqlCommand("SELECT NOW()", connection);

            var serverTime = await command.ExecuteScalarAsync();

            return Ok(new
            {
               connected = true,
               message = "Po³¹czono z Supabase!",
               serverTime
            });
         }
         catch (Exception ex)
         {
            return StatusCode(500, new
            {
               connected = false,
               error = ex.Message
            });
         }
      }
   
      [Authorize]
      [HttpGet("secure")]
      public IActionResult Secure()
      {
         return Ok(new
         {
            message = "Jesteœ zalogowany",
            userId = User.FindFirst("sub")?.Value,
            email = User.FindFirst("email")?.Value
         });
      }     
   }
}