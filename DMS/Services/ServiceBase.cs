namespace DMS.Services
{
	internal abstract class ServiceBase
	{
		protected ApiClient _apiClient { get; }
		protected ServiceBase(ApiClient apiClient)
		{
			_apiClient = apiClient;
		}
	}
}
