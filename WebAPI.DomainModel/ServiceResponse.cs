using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DomainModel
{
   public class ServiceResponse<T>:ServiceResponse
    {
       public T Data { get; set; }
    }
   public enum Status
   {
       Success=0,
       Failure=1
   }
   public class ServiceResponse
   {
       public string ErrorMessage { get; set; }
       public Exception Exception { get; set; }
       public Status Status { get; set; }
   }
}
