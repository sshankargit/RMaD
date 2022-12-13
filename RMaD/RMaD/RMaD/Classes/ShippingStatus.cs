using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMaD.Classes
{
    /// <summary>
    /// Shipping status object class
    /// </summary>
    internal class ShippingStatus
    {
        private string shipStatus;
        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;

        public ShippingStatus() { }
        public ShippingStatus(string shipStatus) { this.shipStatus = shipStatus; }

        /// <summary>
        /// Populate shipping status in Add new shipment form
        /// </summary>
        /// <returns></returns>
        public List<string> loadShippingStatus()
        {
            List<string> shippingStatusList = new List<string>();

            DatabaseAccess databaseObject = new DatabaseAccess();
            sqlQuery = "SELECT status from SHIPMENT_STATUS";
            sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@projectVer", projectVer);

            databaseObject.OpenConnection();
            result = sqlCommand.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    shippingStatusList.Add(result[0].ToString());
                }
            }

            result.Close();
            databaseObject.CloseConnection();

            return shippingStatusList;
        }

        /// <summary>
        /// Get shipment status ID from database
        /// </summary>
        /// <returns>shipment status ID</returns>
        public int getStatusID()
        {
            DatabaseAccess databaseObject = new DatabaseAccess();
            sqlQuery = "SELECT shipment_status_id from SHIPMENT_STATUS where status = @status";
            sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@status", this.shipStatus);
            databaseObject.OpenConnection();
            result = sqlCommand.ExecuteReader();

            int statusID = -1;

            if (result.HasRows)
            {
                if (result.Read())
                {
                    if (result[0].ToString() == string.Empty)
                    {
                        result.Close();
                        databaseObject.CloseConnection();
                        return -1;
                    }

                    statusID = int.Parse(result[0].ToString());
                }
            }

            result.Close();
            databaseObject.CloseConnection();

            return statusID;
        }

    }
}
