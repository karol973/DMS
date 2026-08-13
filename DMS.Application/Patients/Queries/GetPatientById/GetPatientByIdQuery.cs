using DMS.Application.Common.Responses;
using DMS.Application.DTOs.Patient;
using MediatR;

namespace DMS.Application.Patients.Queries.GetPatientById
{
   public class GetPatientByIdQuery : IRequest<Response<PatientDto>>
   {
      public int PatientId { get; init; }
   }
}
