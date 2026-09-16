using DMS.Application.Common.Authorization;
using DMS.Application.Common.Handlers;
using DMS.Application.Common.Interfaces;
using DMS.Application.Common.Responses;
using DMS.Application.Patients.Mappings;
using DMS.Application.Patients.Models;
using DMS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DMS.Application.Patients.Queries.GetPatientById
{
   internal sealed class GetPatientByIdQueryHandler : HandlerBase, IRequestHandler<GetPatientByIdQuery, Response<PatientDto>>
   {
      private readonly IDmsDbContext _context;
      public GetPatientByIdQueryHandler(IDmsDbContext context, CurrentUser currentUser) : base(currentUser) 
      { 
         _context = context;  
      }

      public async Task<Response<PatientDto>> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
      {

         PatientUser? patientUser = await _context.PatientUsers
          .AsNoTracking()
          .Include(pu => pu.Patient)
          .FirstOrDefaultAsync(p => p.PatientId == request.PatientId, cancellationToken);


         if (patientUser == null)
         {
            return Response<PatientDto>.Failure($"Patient with id {request.PatientId} not found.");
         }

         if (!PermissionHelper.CanReadPatient(CurrentUser, patientUser.PatientId))
         {
            return Response<PatientDto>.Failure("Nie masz uprawnień do odczytu tego pacjenta.");
         }

         return Response<PatientDto>.Success(patientUser.Patient.PatientMap());

      }
   }
}
