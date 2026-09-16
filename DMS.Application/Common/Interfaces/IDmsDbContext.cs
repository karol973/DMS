using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DMS.Application.Common.Interfaces
{
   public interface IDmsDbContext
   {
      DbSet<Patient> Patients { get; }
      DbSet<User> Users { get; }
      DbSet<PatientUser> PatientUsers { get; }
      Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
   }
}
