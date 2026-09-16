using DMS.Application.Common.Responses;
using DMS.Application.Patients.Models;
using MediatR;

namespace DMS.Application.Patients.Queries.GetPatientById
{
   public class GetPatientByIdQuery : IRequest<Response<PatientDto>>
   {
      public long PatientId { get; init; }
   }
}
