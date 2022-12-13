using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RMaD.Classes
{   /// <summary>
    /// Database access class
    /// </summary>
    internal class DatabaseAccess
    {
        public SQLiteConnection sqlConnection;
        /// <summary>
        /// Constructor which connects to SQLite database
        /// </summary>
        public DatabaseAccess()
        {
            string s = Path.GetFullPath(".");
            sqlConnection = new SQLiteConnection("Data Source=./rmad.db");
        }
        /// <summary>
        /// Open database connection to SQLite database
        /// </summary>
        public void OpenConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        /// <summary>
        /// Close database connection
        /// </summary>
        public void CloseConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

        }
    }
}
