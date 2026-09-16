using DMS.Models.Auth;
using DMS.Models.Common;
using DMS.Session;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DMS.Services
{
	internal class AuthService : ServiceBase
	{
		private readonly UserSession _userSession;
		public AuthService(ApiClient apiClient, UserSession userSession) : base(apiClient)
		{
			_userSession = userSession;
		}

		public async Task<LoginResult> LoginAsync(string username, string password)
		{
			var request = new LoginRequest
			{
				 Email = username,
				 Password = password
			};

			HttpResponseMessage response = await _apiClient.PostAsync("api/Auth/login", request);
			
			if (!response.IsSuccessStatusCode)
			{
				return null;
			}

			string json = await response.Content.ReadAsStringAsync();

			ApiResponse<LoginResult> result = JsonConvert.DeserializeObject<ApiResponse<LoginResult>>(json);

			if (result == null ||
				string.IsNullOrWhiteSpace(result.Data.AccessToken))
			{
				return null;
			}

			_userSession.Start(result.Data.AccessToken, result.Data.RefreshToken, username, result.Data.UserRole);

			_apiClient.SetBearerToken(result.Data.AccessToken);

			return result.Data;
			
		}

		public void Logout()
		{
			_userSession.Clear();
			_apiClient.ClearBearerToken();
		}
	}
}
