using DMS.Models.Auth;
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

			HttpResponseMessage response = await _apiClient.PostAsync(
				"api/Auth/login",
				request);
			{
				if (!response.IsSuccessStatusCode)
				{
					return null;
				}

				string json =
					await response.Content.ReadAsStringAsync();

				LoginResult result =
					JsonConvert.DeserializeObject<LoginResult>(json);

				if (result == null ||
					string.IsNullOrWhiteSpace(result.AccessToken))
				{
					return null;
				}

				_userSession.Start(result.AccessToken, result.RefreshToken, username);

				_apiClient.SetBearerToken(
					result.AccessToken);

				return result;
			}
		}
	}
}
