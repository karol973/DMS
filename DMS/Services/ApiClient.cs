using DMS.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Services
{
	internal class ApiClient
	{
		private readonly HttpClient _httpClient;

		public ApiClient()
		{
			_httpClient = new HttpClient
			{
				BaseAddress = new Uri(ApiSettings.BaseUrl)
			};
		}
		public void SetBearerToken(string token)
		{
			_httpClient.DefaultRequestHeaders.Authorization =
				new AuthenticationHeaderValue(
					"Bearer",
					token);
		}

		public async Task<HttpResponseMessage> PostAsync<T>(
			string url,
			T request)
		{
			string json =
				JsonConvert.SerializeObject(request);

			var content = new StringContent(
				json,
				Encoding.UTF8,
				"application/json");

			return await _httpClient.PostAsync(
				url,
				content);

		}
	}
}
