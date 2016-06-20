using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DomainModel;

namespace WebAPI.Services.ServiceInterface
{
   public interface IUserService
    {
        ServiceResponse<int> CreateUser(string username, string password);
        ServiceResponse<LoginModel> GetLoginData(string username, string password);
        List<LoginModel> GetAllUsers();
        ServiceResponse<LoginModel> GetUserById(int userId);
        ServiceResponse<LoginModel> GetByUsername(string username);
    }
}
