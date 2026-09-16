using DMS.Application.Common.Interfaces;
using DMS.Application.Common.Responses;
using DMS.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DMS.Application.Patients.Commands.CreatePatient
{
   internal sealed class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, Response<long>>
   {
      private readonly IDmsDbContext _context;
      public CreatePatientCommandHandler(IDmsDbContext context)
      {
         _context = context;
      }

      public async Task<Response<long>> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
      {
         bool alreadyExists = await _context.Patients.AnyAsync(p => p.FirstName == request.FirstName && p.LastName == request.LastName && p.DateOfBirth == request.DateOfBirth, cancellationToken);

         if (alreadyExists)
         {
            return Response<long>.Failure($"Patient with : {request.FirstName}, {request.LastName}, {request.DateOfBirth} already exists.");
         }

         Patient patient = new Patient(request.FirstName, request.LastName);

         patient.DateOfBirth = request.DateOfBirth;
         patient.Gender = request.Gender;
         patient.Phone = request.Phone;
         patient.Email = request.Email;
         patient.Address = request.Address;
         patient.BloodGroup = request.BloodGroup;
         patient.Notes = request.Notes;

         _context.Patients.Add(patient);

         await _context.SaveChangesAsync(cancellationToken);

         return Response<long>.Success(patient.Id);

      }
   }
}
