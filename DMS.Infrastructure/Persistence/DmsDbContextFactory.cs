using DMS.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class DmsDbContextFactory : IDesignTimeDbContextFactory<DmsDbContext>
{
   public DmsDbContext CreateDbContext(string[] args)
   {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DMS.Api")) 
          .AddJsonFile("appsettings.json")
          .AddJsonFile("appsettings.Development.json", optional: true)
          .Build();

      string connectionString = configuration.GetConnectionString("Supabase")
               ?? throw new InvalidOperationException(
              "Brak ConnectionStrings:Supabase");
      DbContextOptionsBuilder<DmsDbContext> optionsBuilder = new DbContextOptionsBuilder<DmsDbContext>();
      optionsBuilder.UseNpgsql(connectionString);

      return new DmsDbContext(optionsBuilder.Options);
   }
}
