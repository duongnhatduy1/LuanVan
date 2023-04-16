using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSoftPhone_02.Pattern
{
    public partial class UserInfo
    {
        public UserInfo(string userName, string password, string serverIP)
        {
            UserName = userName;
            Password = password;
            ServerIP = serverIP;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string ServerIP { get; private set; }
    }
}
