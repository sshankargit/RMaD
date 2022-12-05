using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RMaD.Classes
{
    internal class User
    {

        private string _firstname;
        private string _lastname;
        private string _username;
        private string _password;
        private string _email;

        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;

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

        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
        }

        public Boolean addUser()
        {
            sqlQuery = "INSERT INTO USERS (first_name, last_name, user_name, password,email_address,created_on) " +
                      "VALUES(@firstName, @lastName, @userName, @password, @emailId, @createDate)";

            string encryptedPassword = PasswordEncryptor.MD5Hash(this._password);

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);

                sqlCommand.Parameters.AddWithValue("@firstName", this._firstname);
                sqlCommand.Parameters.AddWithValue("@lastName", this._lastname);
                sqlCommand.Parameters.AddWithValue("@userName", this._username);
                sqlCommand.Parameters.AddWithValue("@password", encryptedPassword);
                sqlCommand.Parameters.AddWithValue("@emailId", this._email);
                sqlCommand.Parameters.AddWithValue("@createDate",DateTime.Now.ToString("yyyy-MM-dd"));


                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();

                databaseObject.CloseConnection();

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Add new user failed.");
                return false;
            }
        }

        public Boolean userExists()
        {
            Boolean usrExists = false;

            try { 
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlQuery = "select * from USERS where (user_name = @user or email_address = @email)";
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);

                sqlCommand.Parameters.AddWithValue("@user", this._username);
                sqlCommand.Parameters.AddWithValue("@email", this._email);
                databaseObject.OpenConnection();
                result = sqlCommand.ExecuteReader();

                if (result.HasRows)
                {
                    usrExists = true;
                }

                result.Close();
                databaseObject.CloseConnection();
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Failed.");
            }

            return usrExists;
        }

        public void removeUser(User user)
        {

        }

    }       
    
}
