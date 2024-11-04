using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginForm.Models;

namespace LoginForm.Services
{
    internal class UserService
    {
        public bool ValidateUser(string user, string password)
        {
            return user == "admin" && password == "1234";
        }

    }
}
