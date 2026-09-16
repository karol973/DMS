using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMS.Infrastructure.Persistence.Configurations;

public sealed class PatientUserConfiguration
    : IEntityTypeConfiguration<PatientUser>
{
   public void Configure(
       EntityTypeBuilder<PatientUser> builder)
   {
      builder.ToTable("patient_users", "public");

      builder.HasKey(x => x.UserId);

      builder.Property(x => x.UserId)
          .HasColumnName("user_id");

      builder.Property(x => x.PatientId)
          .HasColumnName("patient_id");

      builder.HasIndex(x => x.PatientId)
          .IsUnique();

      builder.HasOne(x => x.User)
          .WithOne(x => x.PatientUser)
          .HasForeignKey<PatientUser>(
              x => x.UserId)
          .OnDelete(DeleteBehavior.Cascade);

      builder.HasOne(x => x.Patient)
          .WithOne()
          .HasForeignKey<PatientUser>(
              x => x.PatientId)
          .OnDelete(DeleteBehavior.Cascade);
   }
}