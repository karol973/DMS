using DMS.Application.Common.Interfaces;
using DMS.Application.Common.Responses;
using DMS.Application.DTOs.Patient;
using DMS.Application.Patients.Mappings;
using DMS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Application.Patients.Queries.GetPatientById
{
   internal sealed class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, Response<PatientDto>>
   {
      private readonly IDmsDbContext _context;
      public GetPatientByIdQueryHandler(IDmsDbContext context)
      {
         _context = context;  
      }

      public async Task<Response<PatientDto>> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
      {
         Patient? patient = await _context.Patients
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == request.PatientId, cancellationToken);

         if (patient == null)
         {
            return Response<PatientDto>.Failure($"Patient with id {request.PatientId} does not exist.");
         }

         return Response<PatientDto>.Success(patient.PatientMap());

      }
   }
}
