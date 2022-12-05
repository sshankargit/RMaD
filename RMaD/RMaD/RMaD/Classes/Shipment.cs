using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RMaD.Classes
{
    internal class Shipment
    {
        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;
        int res = 0;
        public void addShipment(List<string> newShipment) { 
        
            if (newShipment == null) { MessageBox.Show("Add new shipment failed.", "Failed!"); };

            sqlQuery = "INSERT INTO SHIPMENT (tracking_id, shipped_on, arrive_on, shipping_company_id,shipment_status_id)" + 
                      "VALUES(@trackingId, @dateShipped, @dateArrival, @shippingCompany, @shippingStatus)";

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);

                sqlCommand.Parameters.AddWithValue("@trackingId", newShipment[0]);
                sqlCommand.Parameters.AddWithValue("@dateShipped", newShipment[1]);
                sqlCommand.Parameters.AddWithValue("@dateArrival", newShipment[2]);
                sqlCommand.Parameters.AddWithValue("@shippingCompany", newShipment[3]);
                sqlCommand.Parameters.AddWithValue("@shippingStatus", "1");

                databaseObject.OpenConnection();
                res = sqlCommand.ExecuteNonQuery();

                databaseObject.CloseConnection();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Add new shipment failed.");
            }
        }
        

    }
}
