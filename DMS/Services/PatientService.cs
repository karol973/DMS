using DMS.Models.Common;
using DMS.Models.Patient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DMS.Services
{
   internal class PatientService : ServiceBase
   {
      public PatientService(ApiClient apiClient) : base(apiClient)
      {
      }

      public async Task<List<PatientDto>> GetPatientsAsync()
      {
         HttpResponseMessage response = await _apiClient.GetAsync("api/desktop/patients");

         if (!response.IsSuccessStatusCode)
         {
            return new List<PatientDto>();
         }

         string json = await response.Content.ReadAsStringAsync();

         ApiResponse<List<PatientDto>> result = JsonConvert.DeserializeObject<ApiResponse<List<PatientDto>>>(json);

         if (result == null || result.Data == null)
         {
            return new List<PatientDto>();
         }

          return result.Data;
      }
   }
}
