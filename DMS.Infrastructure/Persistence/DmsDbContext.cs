using DMS.Application.Common.Interfaces;
using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Infrastructure.Persistance
{
   public class DmsDbContext : DbContext, IDmsDbContext
   {
      public DmsDbContext(DbContextOptions options) : base(options)
      {
      }

      public DbSet<Patient> Patients => Set<Patient>();
      protected override void OnModelCreating(
            ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);

         modelBuilder.ApplyConfigurationsFromAssembly(
             typeof(DmsDbContext).Assembly);
      }
   }
}
