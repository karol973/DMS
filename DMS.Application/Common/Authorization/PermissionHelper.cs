namespace DMS.Application.Common.Authorization
{
   public static class PermissionHelper
   {
      public static bool CanCreatePatient(CurrentUser currentUser)
      {
         ArgumentNullException.ThrowIfNull(currentUser);

         return currentUser.Role is Domain.Enums.UserRole.Admin or Domain.Enums.UserRole.Doctor;
      }

      public static bool CanListPatients(CurrentUser currentUser)
      {
         ArgumentNullException.ThrowIfNull(currentUser);

         return currentUser.Role is Domain.Enums.UserRole.Admin or Domain.Enums.UserRole.Doctor;
      }

      public static bool CanReadPatient(CurrentUser currentUser, long patientId)
      {
         ArgumentNullException.ThrowIfNull(currentUser);

         return currentUser.Role switch
         {

            Domain.Enums.UserRole.Admin => true,
            Domain.Enums.UserRole.Doctor => true,
            Domain.Enums.UserRole.Patient => currentUser.PatientId.HasValue
               && currentUser.PatientId.Value == patientId,
            _=> false,

         };
      }

      public static bool CanUpdateMedicalData(CurrentUser currentUser)
      {
         ArgumentNullException.ThrowIfNull(currentUser);

         return currentUser.Role is Domain.Enums.UserRole.Admin or Domain.Enums.UserRole.Doctor;

      }

      public static bool CanDeletePatient(CurrentUser currentUser)
      {
         ArgumentNullException.ThrowIfNull(currentUser);

         return currentUser.Role == Domain.Enums.UserRole.Admin;
      }
   }
}
