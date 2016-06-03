using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DataAccess
{
   public class Configuration
    {
       public static string ConnectionString
       {
           get
           {
               return @"Data Source= THINKSYS-PC\SQLEXPRESS; Initial Catalog=WebAPI_DB; User Id=sa2; Password=sa2012;";
           }
       }
    }
}
