using DMS.Application.Patients.Models;
using DMS.Domain.Entities;

namespace DMS.Application.Patients.Mappings
{
   public static class PatientMapping
   {
      public static PatientDto PatientMap(this Patient patient)
      {
         return new PatientDto
         {
            Id = patient.Id,
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            DateOfBirth = patient.DateOfBirth,
            Gender = patient.Gender,
            Phone = patient.Phone,
            Email = patient.Email,
            Address = patient.Address,
            BloodGroup = patient.BloodGroup,
            Diagnosis = patient.Notes
         };
      }
   }
}
