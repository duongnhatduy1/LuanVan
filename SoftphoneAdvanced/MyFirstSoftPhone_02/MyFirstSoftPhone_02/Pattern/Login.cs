using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSoftPhone_02.Pattern
{
    class Login
    {
        public Login(string userName, string password)
        {
            username = userName;
            password = password;
        }

        public string username { get; private set; }
        public string password { get; private set; }
    }
}
