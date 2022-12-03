using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RMaD.Classes
{
    internal class DatabaseAccess
    {
        public SQLiteConnection sqlConnection;
        public DatabaseAccess()
        {

            sqlConnection = new SQLiteConnection("Data Source=rmad.db");
            if (!File.Exists("./rmad.db"))
            {
                SQLiteConnection.CreateFile("rmad.db");
                System.Console.WriteLine("Database created!");
            }

        }
        public void OpenConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

        }
    }
}
