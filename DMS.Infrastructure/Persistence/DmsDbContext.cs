using DMS.Application.Common.Interfaces;
using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DMS.Infrastructure.Persistance
{
   public class DmsDbContext : DbContext, IDmsDbContext
   {
      public DmsDbContext(DbContextOptions<DmsDbContext> options) : base(options)
      {
      }

      public DbSet<Patient> Patients => Set<Patient>();
      public DbSet<User> Users => Set<User>();
      public DbSet<PatientUser> PatientUsers => Set<PatientUser>(); 
      protected override void OnModelCreating(
            ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);

         modelBuilder.ApplyConfigurationsFromAssembly(
             typeof(DmsDbContext).Assembly);
      }
   }
}
