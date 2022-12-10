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
        private string _trackNumber;
        private string _dateShipped;
        private string _dateArrival;
        private string _carrier;
        private string _shipmentStatus;

        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;        

        public Shipment(string trackNumber, string dateShipped, string dateArrival, string carrier, string shipmentStatus)
        {
            _trackNumber = trackNumber;
            _dateShipped = dateShipped;
            _dateArrival = dateArrival;
            _carrier = carrier;
            _shipmentStatus = shipmentStatus;
        }

        public Boolean addShipment() {     


            sqlQuery = "INSERT INTO SHIPMENT (tracking_id, shipped_on, arrive_on, shipping_company_id,shipment_status_id)" + 
                      "VALUES(@trackingId, @dateShipped, @dateArrival, @shippingCompany, @shippingStatus)";

            try
            {
                ShippingService shipServ = new ShippingService();
                int carrierID = shipServ.getCarrierID(this._carrier);//getting carrier ID from database
                int shipStatusId = shipServ.getShipmentStatusID(this._shipmentStatus); // get ship status id

                if (carrierID < 1)
                {
                    MessageBox.Show("Carrier does not exist in the system.", "New shipment add failed!");
                }

                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@trackingId", this._trackNumber);
                sqlCommand.Parameters.AddWithValue("@dateShipped", this._dateShipped);
                sqlCommand.Parameters.AddWithValue("@dateArrival", this._dateArrival);
                sqlCommand.Parameters.AddWithValue("@shippingCompany", carrierID);
                sqlCommand.Parameters.AddWithValue("@shippingStatus", shipStatusId);

                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();

                databaseObject.CloseConnection();

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Add new shipment failed.");
                return false;
            }
        }

        public Boolean trackIDExists()
        {
            Boolean recExists = false;

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlQuery = "select * from SHIPMENT where tracking_id =@trackID";
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);

                sqlCommand.Parameters.AddWithValue("@trackID", this._trackNumber);                
                databaseObject.OpenConnection();
                result = sqlCommand.ExecuteReader();

                if (result.HasRows)
                {
                    recExists = true;
                }

                result.Close();
                databaseObject.CloseConnection();
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Failed.");
            }

            return recExists;
        }

    }
}
