using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMS.Infrastructure.Persistence.Configurations
{
   public class PatientConfiguration: IEntityTypeConfiguration<Patient>
   {
      public void Configure(EntityTypeBuilder<Patient> builder)
      {
         builder.ToTable("patients", "public");

         builder.HasKey(x => x.Id);

         builder.Property(x => x.Id)
             .HasColumnName("id")
             .ValueGeneratedOnAdd();

         builder.Property(x => x.FirstName)
             .HasColumnName("first_name")
             .HasMaxLength(100)
             .IsRequired();

         builder.Property(x => x.LastName)
             .HasColumnName("last_name")
             .HasMaxLength(100)
             .IsRequired();

         builder.Property(x => x.DateOfBirth)
             .HasColumnName("date_of_birth")
             .HasColumnType("date");

         builder.Property(x => x.Gender)
             .HasColumnName("gender")
             .HasMaxLength(20);

         builder.Property(x => x.Phone)
             .HasColumnName("phone")
             .HasMaxLength(50);

         builder.Property(x => x.Email)
             .HasColumnName("email")
             .HasMaxLength(150);

         builder.Property(x => x.Address)
             .HasColumnName("address")
             .HasMaxLength(300);

         builder.Property(x => x.BloodGroup)
             .HasColumnName("blood_group")
             .HasMaxLength(10);

         builder.Property(x => x.Notes)
             .HasColumnName("notes");

         builder.Property(x => x.CreatedAt)
             .HasColumnName("created_at")
             .HasDefaultValueSql("now()")
             .ValueGeneratedOnAdd();

         builder.Property(x => x.UpdatedAt)
             .HasColumnName("updated_at")
             .HasDefaultValueSql("now()")
             .ValueGeneratedOnAdd();
      }
   }
}