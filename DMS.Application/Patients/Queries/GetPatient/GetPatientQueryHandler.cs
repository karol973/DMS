using DMS.Application.Common.Interfaces;
using DMS.Application.Common.Responses;
using DMS.Application.DTOs.Patient;
using DMS.Application.Patients.Mappings;
using DMS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DMS.Application.Patients.Queries.GetPatient
{
   internal sealed class GetPatientQueryHandler : IRequestHandler<GetPatientQuery, Response<List<PatientDto>>>
   {
      private readonly IDmsDbContext _context;

      public GetPatientQueryHandler(IDmsDbContext context)
      {
         _context = context;
      }

      public async Task<Response<List<PatientDto>>> Handle(GetPatientQuery request, CancellationToken cancellationToken)
      {
         List<PatientDto> patients = await _context.Patients
          .AsNoTracking()
          .Select(p => p.PatientMap())
          .ToListAsync(cancellationToken);

         return Response<List<PatientDto>>.Success(patients);

      }
   }
}
