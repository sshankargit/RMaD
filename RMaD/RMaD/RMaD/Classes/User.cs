using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMaD.Classes
{
    internal class User
    {

        private string _firstname;
        private string _lastname;
        private string _username;
        private string _password;
        private string _email;

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User(string firstname, string lastname, string username, string password, string email)
        {
            this._firstname = firstname;
            this._lastname = lastname;
            this._username = username;
            this._password = password;
            this._email = email;
        }
          
        public static void addUser(User user)
        {

        }

        public static void removeUser(User user)
        {

        }
    }
}
