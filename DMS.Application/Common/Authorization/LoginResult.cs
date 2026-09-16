using DMS.Domain.Enums;

namespace DMS.Application.Common.Authorization
{
   public class LoginResult
   {
      public long Id { get; set; }
      public long? PatientId { get; set; }
      public string AccessToken { get; set; }
      public string RefreshToken { get; set; }
      public UserRole UserRole {  get; set; }
      public LoginResult(string accessToken, string refreshToken, UserRole role, long id, long? patientId)
      {
         Id = id;
         PatientId = patientId;
         AccessToken = accessToken;
         RefreshToken = refreshToken;
         UserRole = role;
      }
   }
}
