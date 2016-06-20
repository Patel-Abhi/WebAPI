using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DomainModel;
using WebAPI.Repositories.RepositoryDefinition;
using WebAPI.Services.ServiceInterface;

namespace WebAPI.Services.ServiceDefinition
{
    public class UserService : IUserService
    {
        #region Property Initialization
        public UserRepository _userRepository { get; set; }
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion       

        #region Create New User
        public ServiceResponse<int> CreateUser(string username, string password)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            response.Status = Status.Failure;
            try
            {
                int result = _userRepository.CreateUser(username, password);
                response.Data = result;
                response.Status = result > 0 ? Status.Success : Status.Failure;
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.ErrorMessage = "Error occured while creating user";
            }

            return response;
        }
        #endregion

        #region Get Login Data
        public ServiceResponse<LoginModel> GetLoginData(string username, string password)
        {
            ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();
            response.Status = Status.Failure;
            try
            {
                response.Data = _userRepository.GetLoginData(username, password);
                response.Status = Status.Success; ;
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.ErrorMessage = "Error occured while getting login data";
            }

            return response;
        }
        #endregion

        #region Get All Users
        public List<LoginModel> GetAllUsers()
        {
            List<LoginModel> lstUser = new List<LoginModel>();
            try
            {
                lstUser = _userRepository.GetAllUsers();
            }
            catch (Exception ex) { }
            return lstUser;
        }
        #endregion

        #region Get User By Id
        public ServiceResponse<LoginModel> GetUserById(int userId)
        {
            ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();
            response.Status = Status.Failure;
            try
            {
                response.Data = _userRepository.GetUserById(userId);
                response.Status = Status.Success;
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.ErrorMessage = "Error occured while getting user data";
            }
            return response;
        }
        #endregion

        #region Get By Username
        public ServiceResponse<LoginModel> GetByUsername(string username)
        {
            ServiceResponse<LoginModel> response = new ServiceResponse<LoginModel>();
            response.Status = Status.Failure;
            try
            {
                response.Data = _userRepository.GetByUsername(username);
                response.Status = Status.Success;
            }
            catch(Exception ex)
            {
                response.Exception = ex;
                response.ErrorMessage = "Error occured while getting user data";
            }
            return response;
        }
        #endregion   
               
    }
}
