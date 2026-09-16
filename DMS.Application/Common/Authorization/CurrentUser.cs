using DMS.Domain.Enums;

namespace DMS.Application.Common.Authorization
{
   public abstract class CurrentUser
   {
      public abstract long UserId { get; }
      public abstract long? PatientId { get; }
      public abstract UserRole Role { get; }
   }
}
