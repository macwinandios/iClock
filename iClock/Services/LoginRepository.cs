using iClock.Factory;
using iClock.Interfaces;
using iClock.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace iClock.Services
{
    public class LoginRepository : ILoginRepository
    {
        ILoginModel _loginModel;
        public LoginRepository(ILoginModel loginModel)
        {
            var loginModelObject = ObjectFactory.CreateLoginModel(Model.LoginModel);
            _loginModel = loginModel;
        }
        public LoginRepository()
        {

        }
        public Task<bool> DeleteUserAsync (int id)
        {
            throw new NotImplementedException();
            
        }
        public Task<IEnumerable<LoginModel>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoginModel> GetUserAsync (int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostUserAsync (LoginModel loginModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUserAsync (LoginModel loginModel)
        {
            throw new NotImplementedException();
        }
    }
}
