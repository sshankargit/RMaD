using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
    /// <summary>
    /// Class for creating shipment object
    /// </summary>
    public class Shipment
    {
        private string _trackNumber;
        private string _dateShipped;
        private string _dateArrival;
        private string _carrier;
        private string _status;

        public string TrackNumber { get { return _trackNumber; } }
        public string DateShipped { get { return _dateShipped; } }
        public string DateArrival { get { return _dateArrival; } }
        public string Carrier { get { return _carrier; } }
        public string ShipmentStatus { get { return _status; } }

        private static SQLiteDataReader result;
        private static SQLiteCommand sqlCommand;
        static string sqlQuery;

        private ShippingService shipServ;
        private ShippingStatus shipStatus;

        /// <summary>
        /// Constructor creates shipment object
        /// </summary>
        /// <param name="trackNumber"></param>
        /// <param name="dateShipped"></param>
        /// <param name="dateArrival"></param>
        /// <param name="carrier"></param>
        /// <param name="status"></param>
        public Shipment(string trackNumber, string dateShipped, string dateArrival, string carrier, string status)
        {
            _trackNumber = trackNumber;
            _dateShipped = dateShipped;
            _dateArrival = dateArrival;
            _carrier = carrier;
            _status = status;
        }
        
        /// <summary>
        /// Gets shipment information from add shipment form and adds into database
        /// </summary>
        /// <returns>Shipment add status true/false</returns>
        public async Task<Boolean> addShipment() {     


            sqlQuery = "INSERT INTO SHIPMENT (tracking_id, shipped_on, arrive_on, shipping_company_id,shipment_status_id)" + 
                      "VALUES(@trackNumber, @dateShipped, @dateArrival, @shippingCompany, @shippingStatus)";

            try
            {
                shipServ = new ShippingService(this._carrier);
                shipStatus = new ShippingStatus(this._status);          

                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@trackNumber", this._trackNumber);
                sqlCommand.Parameters.AddWithValue("@dateShipped", this._dateShipped);
                sqlCommand.Parameters.AddWithValue("@dateArrival", this._dateArrival);
                sqlCommand.Parameters.AddWithValue("@shippingCompany", shipServ.getCarrierID());
                sqlCommand.Parameters.AddWithValue("@shippingStatus", shipStatus.getStatusID());

                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();

                databaseObject.CloseConnection();

                User user = new User(LoginInfo.loggedInUser);
                APIHandler apiHandler = new APIHandler("https://api.trackinghive.com", "/trackings", user.Token());
                Shipment shipment = new Shipment(this._trackNumber, this._dateShipped, this._dateArrival, this._carrier, this._status);
                await apiHandler.PostShipment(shipment);

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Add new shipment failed.");
                return false;
            }
        }

        /// <summary>
        /// Updates existing shipment
        /// Gets details from update shipment form and modify existing shipment record
        /// </summary>
        /// <returns>Update shipment status true/false </returns>
        public Boolean updateShipment()
        {
            sqlQuery = "UPDATE SHIPMENT " +
                      "SET shipped_on = @dateShipped, arrive_on = @dateArrival, shipping_company_id = @shippingCompany, shipment_status_id = @shippingStatus "+
                      "WHERE tracking_id = @trackNumber";

            try
            {
                shipServ = new ShippingService(this.Carrier);
                shipStatus = new ShippingStatus(this.ShipmentStatus);
                int carrierID = shipServ.getCarrierID();//getting carrier ID from database
                int shipStatusId = shipStatus.getStatusID(); // get ship status id

                if (carrierID < 1)
                {
                    MessageBox.Show("Carrier does not exist in the system.", "New shipment add failed!");
                }

                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@trackNumber", this._trackNumber);
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
                System.Windows.Forms.MessageBox.Show(e.Message, "Update shipment failed.");
                return false;
            }
        }
        /// <summary>
        /// Update shipment using orignal tacking id
        /// Refresh shipments data grid view
        /// </summary>
        /// <param name="originalTrackID"></param>
        public void updateShipment(string originalTrackID)
        {
            sqlQuery = "UPDATE SHIPMENT SET shipped_on = @shipdt, arrive_on = @arrdt, shipping_company_id = @shipID, shipment_status_id=@shipStatus, tracking_id = @trackID " + 
                         "WHERE tracking_id = @trackID1";

            shipServ = new ShippingService(this._carrier);
            shipStatus = new ShippingStatus(this._status);

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@shipdt", this._dateShipped);
                sqlCommand.Parameters.AddWithValue("@arrdt", this._dateArrival);
                sqlCommand.Parameters.AddWithValue("@shipID", shipServ.getCarrierID());
                sqlCommand.Parameters.AddWithValue("@shipStatus", shipStatus.getStatusID());
                sqlCommand.Parameters.AddWithValue("@trackID", this._trackNumber);
                sqlCommand.Parameters.AddWithValue("@trackID1", originalTrackID);

                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                databaseObject.CloseConnection();

                MessageBox.Show("Shipment has been updated!");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Update failed");
            }

            //sreturn res;
        }

        /// <summary>
        /// Delete the selected shipment from database
        /// Update shipment data grid view
        /// </summary>
        public void deleteShipment()
        {
            sqlQuery = "DELETE FROM SHIPMENT WHERE tracking_id = @trackID ";

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);                
                sqlCommand.Parameters.AddWithValue("@trackID", this._trackNumber);

                databaseObject.OpenConnection();
                sqlCommand.ExecuteNonQuery();
                databaseObject.CloseConnection();

                MessageBox.Show("Shipment has been deleted!");
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Delete failed");
            }

            //sreturn res;
        }
        /// <summary>
        /// Check if trackig ID already exists when adding a shipment
        /// If the tracking ID arready exists the shipment will not be added
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Test class for checking tracking number exists
        /// </summary>
        /// <param name="trackNum"></param>
        /// <returns></returns>
        public Boolean trackIDExists(string trackNum)
        {
            Boolean recExists = false;

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlQuery = "select * from SHIPMENT where tracking_id =@trackID";
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);

                sqlCommand.Parameters.AddWithValue("@trackID", trackNum);
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

        public List<string> getShipmentByTrackID(string trackNum)
        {
            Boolean recExists = false;
            List<string> shipment = new List<string>();

            try
            {
                DatabaseAccess databaseObject = new DatabaseAccess();
                sqlQuery = "select S.tracking_id as [Tracking], S.shipped_on as [Shipped Date], S.arrive_on as [Arrival Date], SC.shipping_company_name as [Carrier], SS.status as Status " +
                            "from SHIPMENT S " +
                            "INNER JOIN SHIPPING_COMPANY SC on S.shipping_company_id = SC.shipping_company_id " +
                            "INNER JOIN SHIPMENT_STATUS SS on S.shipment_status_id = SS.shipment_status_id " +
                            "where S.tracking_id = @trackID ";
                           //"order by S.shipment_id DESC";
                sqlCommand = new SQLiteCommand(sqlQuery, databaseObject.sqlConnection);

                sqlCommand.Parameters.AddWithValue("@trackID", trackNum);
                databaseObject.OpenConnection();
                result = sqlCommand.ExecuteReader();

                if (result.HasRows)
                {

                    while(result.Read())
                    {
                        shipment.Add(result[0].ToString());
                        shipment.Add(result[1].ToString());
                        shipment.Add(result[2].ToString());
                        shipment.Add(result[3].ToString());
                        shipment.Add(result[4].ToString());
                    }
                    //recExists = true;
                    //shipment = new Shipment(result[0].ToString(), result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString());
                   
                }

                result.Close();
                databaseObject.CloseConnection();
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Failed.");
            }

            return shipment;
        }

    }
}
