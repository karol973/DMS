namespace DMS.Domain.Entities
{
   public class PatientUser
   {
      public long UserId { get; private set; }

      public long PatientId { get; private set; }

      public User User { get; private set; } = null!;

      public Patient Patient { get; private set; } = null!;
      public PatientUser(long userId, long patientId)
      {
         UserId = userId;
         PatientId = patientId;
      }
   }
}
