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

        [HttpPost]
        [ActionName("CreateUser")]
        public int CreateUser(string username, string password)        
        {
            var response = _service.CreateUser(username, password);
            return response.Data;
        }
        [HttpGet]
        [ActionName("GetLoginData")]
        public ServiceResponse<LoginModel> GetLoginData(string username, string password)
        {
            ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();
            response = _service.GetLoginData(username,password);
            return response;
        }

        [HttpGet]
        public List<LoginModel> GetAllUsers()
        {
            List<LoginModel> lstUser = new List<LoginModel>();
            lstUser = _service.GetAllUsers();
            return lstUser;
        }
        [HttpGet]
        public ServiceResponse<LoginModel> GetByUsername(string username)
        {
            ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();
            response = _service.GetByUsername(username);
            return response;
        }
        [HttpGet]
        public ServiceResponse<LoginModel> GetUserById(int userId)
        {
            ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();
            response = _service.GetUserById(userId);
            return response;
        }

    
        public ServiceResponse InvalidUrl()
        {
            ServiceResponse response = new ServiceResponse();
            //response.Exception = Exception;
            response.ErrorMessage = "Invalid url";
            return response;
        }

    }
}
