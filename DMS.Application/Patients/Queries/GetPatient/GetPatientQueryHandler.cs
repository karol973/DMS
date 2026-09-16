using DMS.Application.Common.Authorization;
using DMS.Application.Common.Handlers;
using DMS.Application.Common.Interfaces;
using DMS.Application.Common.Responses;
using DMS.Application.Patients.Mappings;
using DMS.Application.Patients.Models;
using DMS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DMS.Application.Patients.Queries.GetPatient
{
   internal sealed class GetPatientQueryHandler : HandlerBase, IRequestHandler<GetPatientQuery, Response<List<PatientDto>>>
   {
      private readonly IDmsDbContext _context;

      public GetPatientQueryHandler(IDmsDbContext context, CurrentUser currentUser) : base(currentUser) 
      {
         _context = context;
      }

      public async Task<Response<List<PatientDto>>> Handle(GetPatientQuery request, CancellationToken cancellationToken)
      {
         if (!PermissionHelper.CanListPatients(CurrentUser))
         {
            return Response<List<PatientDto>>.Failure("Nie masz uprawnień do wyświetlania pacjentów.");
         }

         List<PatientDto> patients = await _context.Patients
          .AsNoTracking()
          .Select(p => p.PatientMap())
          .ToListAsync(cancellationToken);

         return Response<List<PatientDto>>.Success(patients);

      }
   }
}
