using iClock.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iClock.Services
{
    public interface ILoginRepository
    {
        Task<bool> PostUserAsync (LoginModel loginModel);
        Task<bool> PutUserAsync (LoginModel loginModel);
        Task<bool> DeleteUserAsync (int id);
        Task<LoginModel> GetUserAsync (int id);
        Task<IEnumerable<LoginModel>> GetAllUsersAsync();

    }
}
