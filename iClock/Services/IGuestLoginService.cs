using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iClock.Services
{
    public interface IGuestLoginService
    {
        Task GuestLoginAsync<TViewModelBase>(object loginViewModel = null, bool setRoot = false);
        Task GoBackAsync();
    }
}
