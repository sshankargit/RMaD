using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMaD.Classes
{
    /// <summary>
    /// Class for User authentication
    /// </summary>
    internal class Authentication
    {
        private string _username;
        private string _password;

        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;

        public string Username { get; }
        public string Password { get; }
        public string Token { get; }

        public Authentication(String username, String password)
        {
            this._username = username; 
            this._password = password;
        }
        /// <summary>
        /// Method to login a user
        /// Validate username existance in the database
        /// Convert password string to hash and compare with the password hash stored for the user.
        /// Login user if password hash matches
        /// </summary>
        /// <returns>login success flag</returns>
        public Boolean login()
        {
            DatabaseAccess databaseObject = new DatabaseAccess();
            Boolean validLogin = true;

            sqlQuery = "select user_name, password from USERS WHERE user_name=@userName";
            sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@userName", this._username);
            databaseObject.OpenConnection();
            result = sqlCommand.ExecuteReader();

            if (result.HasRows)
            {
                if (result.Read())
                {
                    //Bcrypt auth added
                    if (!PasswordEncryption.ValidatePassword(this._password, result[1].ToString()))
                    {
                        validLogin = false;
                    }

                }
            }
            else
            {
                validLogin = false;
            }

            result.Close();
            databaseObject.CloseConnection();

            return validLogin;

        }
        public static void logout() 
        {
        }
    }
}
