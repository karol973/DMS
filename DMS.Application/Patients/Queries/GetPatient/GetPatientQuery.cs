using DMS.Application.Common.Responses;
using DMS.Application.DTOs.Patient;
using MediatR;

namespace DMS.Application.Patients.Queries.GetPatient
{
   public sealed class GetPatientQuery : IRequest<Response<List<PatientDto>>>
   {
   }
}
