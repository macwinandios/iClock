using iClock.DataAccessLayer;
using iClock.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace iClock.Services
{
    public class LoginRepository : ILoginRepository
    {

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
