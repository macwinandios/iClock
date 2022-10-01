using System;
using System.Collections.Generic;
using System.Text;

namespace iClock.Models
{
    public class LoginModel
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public string AdminPassword { get; set; } = "123";
        public string AdminUsername { get; set; } = "admin";
    }
}
