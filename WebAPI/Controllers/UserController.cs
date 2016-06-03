using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.DomainModel;
using WebAPI.Repositories.RepositoryInterface;
using WebAPI.Services.ServiceInterface;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {

        IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        public string GetName(string username)
        {
            return "";
        }

        [HttpGet]
        public int CreatUser(string username, string password)        
        {
            var response = _service.CreateUser(username, password);
            return response.Data;
        }

        [HttpGet]
        public List<LoginModel> GetAllUsers()
        {
            List<LoginModel> lstUser = new List<LoginModel>();
            lstUser = _service.GetAllUsers();
            return lstUser;
        }
    }
}
