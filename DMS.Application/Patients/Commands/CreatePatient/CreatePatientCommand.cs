using DMS.Application.Common.Responses;
using MediatR;

namespace DMS.Application.Patients.Commands.CreatePatient
{
   public class CreatePatientCommand : IRequest<Response<long>>
   {
      public string FirstName { get; init; }
      public string LastName { get; init; }
      public DateTime? DateOfBirth { get; init; }
      public string? Gender { get; init; }
      public string? Phone { get; init; }
      public string? Email { get; init; }
      public string? Address { get; init; }
      public string? BloodGroup { get; init; }
      public string? Notes { get; init; }
      //public CreatePatientCommand(string firstName, string lastName)
      //{
      //   FirstName = firstName;
      //   LastName = lastName;
      //}
   }
}
