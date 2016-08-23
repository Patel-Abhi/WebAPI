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
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {

        IUserService _service;
        public EmployeeController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public ServiceResponse<LoginModel> Get(string username = null, string password = null)
        {
            ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();
            if (username != null && password != null)
            {

                response = _service.GetLoginData(username, password);

            }
            else
            {
                var resp = _service.GetAllUsers();

            }
            return response;
        }

        [HttpPost]
        public int Create(string username, string password)
        {
            var response = _service.CreateUser(username, password);
            return response.Data;
        }


    }
}
