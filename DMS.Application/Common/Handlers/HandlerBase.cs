using DMS.Application.Common.Authorization;

namespace DMS.Application.Common.Handlers
{
   public abstract class HandlerBase 
   {
      protected CurrentUser CurrentUser { get; }

      protected HandlerBase(CurrentUser currentUser)
      {
         CurrentUser = currentUser;
      }
   }
}
