using DMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Domain.Entities
{
   public class User
   {
      public long Id { get; set; }

      public Guid AuthUserId { get; set; }

      public string FirstName { get; set; }

      public string LastName { get; set; }

      public UserRole Role { get; set; } = UserRole.Patient;

      public PatientUser? PatientUser { get; private set; }

      public User(Guid authUserId, string firstName, string lastName)
      {
         AuthUserId = authUserId;
         FirstName = firstName;
         LastName = lastName;
      }
   }
}
