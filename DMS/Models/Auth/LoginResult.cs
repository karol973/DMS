namespace DMS.Models.Auth
{
	internal class LoginResult
	{
		public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
      public string UserRole { get; set; }
	}
}
