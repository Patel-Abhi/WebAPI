using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DomainModel;

namespace WebAPI.Repositories.RepositoryInterface
{
   public interface IEmployeeRepository
    {
        int CreateUser(string username, string password);
        LoginModel GetLoginData(string username, string password);
        List<LoginModel> GetAllUsers();
        LoginModel GetUserById(int userId);
        LoginModel GetByUsername(string username);
    }
}
