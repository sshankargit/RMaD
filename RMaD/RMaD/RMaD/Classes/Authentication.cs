using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMaD.Classes
{
    internal class Authentication
    {
        private string _username;
        private string _password;
        private string _token;

        public string Username { get; }
        public string Password { get; }
        public string Token { get; }

        public Authentication(String username, String password)
        {
            this._username = username; 
            this._password = password;
        }

        public static void login()
        {

        }
        public static void logout() 
        { 

        }
    }
}
