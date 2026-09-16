using DMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DMS.Infrastructure.Persistence.Configurations
{
   public class UserConfiguration : IEntityTypeConfiguration<User>
   {
      public void Configure(EntityTypeBuilder<User> builder)
      {
         builder.ToTable("users", "public");

         builder.HasKey(x => x.Id);

         builder.Property(x => x.Id)
             .HasColumnName("id")
             .ValueGeneratedOnAdd();

         builder.Property(x => x.AuthUserId)
             .HasColumnName("auth_user_id")
             .IsRequired();

         builder.HasIndex(x => x.AuthUserId)
             .IsUnique();

         builder.Property(x => x.FirstName)
             .HasColumnName("first_name")
             .HasMaxLength(100)
             .IsRequired();

         builder.Property(x => x.LastName)
             .HasColumnName("last_name")
             .HasMaxLength(100)
             .IsRequired();

         builder.Property(x => x.Role)
             .HasColumnName("role")
             .HasConversion<string>()
             .HasMaxLength(30)
             .IsRequired();

      }
   }
}
