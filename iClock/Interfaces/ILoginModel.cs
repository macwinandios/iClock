using System;
using System.Collections.Generic;
using System.Text;

namespace iClock.Interfaces
{
    public interface ILoginModel
    {
        string Password { get; set; }
        string Username { get; set; }
        string AdminPassword { get; set; }
        string AdminUsername { get; set; }

    }
}
