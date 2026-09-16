namespace DMS.Session
{
	internal class UserSession
	{
		public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
		public string Email { get; set; }
      public string UserRole { get; private set; }

      public bool IsLoggedIn => !string.IsNullOrWhiteSpace(AccessToken);	
		public void Start(string accessToken, string refreshToken, string email, string role)
		{
			AccessToken = accessToken;
			RefreshToken = refreshToken;
			Email = email;
         UserRole = role;
		}

		public void Clear()
		{
			AccessToken = null;
			RefreshToken = null;
			Email = null;
         UserRole = null;
		}
	}
}
