using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DataAccess
{
   public class DBConstants
    {
       public static string CreateUser
       {
           get
           {
               return "SP_CreateUser";
           }
       }

       public static string GetLoginData
       {
           get
           {
               return "SP_GetLoginData";
           }
       }
       public static string GetAllUsers
       {
           get
           {
               return "SP_GetAllUsers";
           }
       }
    }
}
