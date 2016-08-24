using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DataAccess;
using WebAPI.DomainModel;
using WebAPI.Repositories.RepositoryInterface;

namespace WebAPI.Repositories.RepositoryDefinition
{
    public class EmployeeRepository : IEmployeeRepository
    {

        #region Global Objects Decalaration
        SqlConnection con = new SqlConnection(Configuration.ConnectionString);
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter();
        #endregion

        #region  Create New User
        public int CreateUser(string username, string password)
        {
            int resultVal = 0;
            cmd = new SqlCommand(DBConstants.CreateUser, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outputVal = new SqlParameter("@UserId_New", SqlDbType.Int);
            outputVal.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputVal);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", Utility.Encrypt(password));
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }
            if (Convert.ToInt32(outputVal.Value) > 0)
            {
                resultVal = Convert.ToInt32(outputVal.Value);
            }
            return resultVal;
        }
        #endregion

        #region Get Login Data
        public LoginModel GetLoginData(string username, string password)
        {
            string encPassword = Utility.Encrypt(password);
            LoginModel user = new LoginModel();
            cmd = new SqlCommand(DBConstants.GetLoginData, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", encPassword);
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user.UserId = rdr.GetInt32(0);
                    user.Username = rdr.GetString(1);
                    user.Password = rdr.GetString(2);
                    user.SignUpDt = rdr.GetDateTime(3).ToShortDateString();
                    user.LastLoginDt = rdr.GetDateTime(4).ToShortDateString();
                    user.UpdateDt = rdr.GetDateTime(5).ToShortDateString();
                }
                rdr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();

            }
            return user;
        }
        #endregion

        #region Get All Users
        public List<LoginModel> GetAllUsers()
        {
            List<LoginModel> lstUsers = new List<LoginModel>();
            cmd = new SqlCommand(DBConstants.GetAllUsers, con);
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    lstUsers.Add(new LoginModel
                    {
                        UserId = rdr.GetInt32(0),
                        Username = rdr.GetString(1),
                        Password = rdr.GetString(2),
                        SignUpDt = rdr.GetDateTime(3).ToShortDateString(),
                        LastLoginDt = rdr.GetDateTime(4).ToShortDateString(),
                        UpdateDt = rdr.GetDateTime(5).ToShortDateString()
                    });

                }
                rdr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();

            }

            return lstUsers;
        }
        #endregion

        #region Get User By Id
        public LoginModel GetUserById(int userId)
        {
            LoginModel user = new LoginModel();
            cmd = new SqlCommand(DBConstants.GetUserById, con);
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user.UserId = rdr.GetInt32(0);
                    user.Username = rdr.GetString(1);
                    user.Password = rdr.GetString(2);
                    user.SignUpDt = rdr.GetDateTime(3).ToShortDateString();
                    user.LastLoginDt = rdr.GetDateTime(4).ToShortDateString();
                    user.UpdateDt = rdr.GetDateTime(5).ToShortDateString();
                }
                rdr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();

            }

            return user;
        }
        #endregion

        #region Get User By Username

        public LoginModel GetByUsername(string username)
        {
            LoginModel user = new LoginModel();
            cmd = new SqlCommand(DBConstants.GetByUsername, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user.UserId = rdr.GetInt32(0);
                    user.Username = rdr.GetString(1);
                    user.Password = rdr.GetString(2);
                    user.SignUpDt = rdr.GetDateTime(3).ToShortDateString();
                    user.LastLoginDt = rdr.GetDateTime(4).ToShortDateString();
                    user.UpdateDt = rdr.GetDateTime(5).ToShortDateString();
                }
                rdr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();

            }

            return user;
        }
        #endregion

    }
}
