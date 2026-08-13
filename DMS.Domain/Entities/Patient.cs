using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Domain.Entities
{
   public class Patient
   {

      public long Id { get; set; }

      public string FirstName { get; set; } 

      public string LastName { get; set; }

      public DateTime? DateOfBirth { get; set; }

      public string? Gender { get; set; }

      public string? Phone { get; set; }

      public string? Email { get; set; }

      public string? Address { get; set; }

      public string? BloodGroup { get; set; }

      public string? Notes { get; set; }

      public DateTime CreatedAt { get; set; }

      public DateTime UpdatedAt { get; set; }
      public Patient(string firstName, string lastName)
      {
         FirstName = firstName;
         LastName = lastName;
      }
   }
}
