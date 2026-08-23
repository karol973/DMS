namespace DMS.Session
{
	internal class UserSession
	{
		public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
		public string Email { get; set; }
		public bool IsLoggedIn => !string.IsNullOrWhiteSpace(AccessToken);	
		public void Start(string accessToken, string refreshToken, string email)
		{
			AccessToken = accessToken;
			RefreshToken = refreshToken;
			Email = email;
		}

		public void Clear()
		{
			AccessToken = null;
			RefreshToken = null;
			Email = null;
		}
	}
}
