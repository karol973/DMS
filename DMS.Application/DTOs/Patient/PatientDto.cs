using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Application.DTOs.Patient
{
   public class PatientDto
   {
      public long Id { get; init; }  
      public string FirstName { get; init; }
      public string LastName { get; init; }
      public DateTime? DateOfBirth { get; init; }
      public string? Gender { get; init; }
      public string? Phone { get; init; }
      public string? Email { get; init; }
      public string? Address { get; init; }
      public string? BloodGroup { get; init; }
      public string? Notes { get; init; }
   }
}
