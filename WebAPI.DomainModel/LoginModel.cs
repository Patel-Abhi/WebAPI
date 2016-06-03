using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DomainModel
{
   public class LoginModel
    {
       public int UserId { get; set; }
       public string Username { get; set; }
       public string Password { get; set; }
       public string SignUpDt { get; set; }
       public string LastLoginDt { get; set; }
       public string UpdateDt { get; set; }
    }
}
