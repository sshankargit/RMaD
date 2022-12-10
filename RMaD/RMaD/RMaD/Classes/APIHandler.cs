using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using Newtonsoft.Json;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace RMaD.Classes
{

    internal class APIHandler
    {
        private string _token;
        private string _url;
        public string Token
        {
            get
            {
                return this._token;
            }
        }
        public string Url
        {
            get
            {
                return this._url;
            }
        }

        /// <summary>
        /// Create a handler for POST and GET connections for an API.
        /// </summary>
        /// <param name="url">Base url for connecting to API</param>
        /// <param name="endpoint">Endpoint for making specific calls to API</param>
        /// <param name="token">Developer token from Trackhive</param>
        public APIHandler(string url, string endpoint, string token)
        {
            this._token = "Bearer " + token;
            this._url = url + endpoint;
        }

        /// <summary>
        /// posts all shipments to API server
        /// </summary>
        public async void PostAllShipments()
        {
            DatabaseAccess databaseObject = new DatabaseAccess();
            databaseObject.OpenConnection();
            DataTable dt = new DataTable();

            string sqlQuery = "select S.tracking_id as [Tracking], S.shipped_on as [Shipped Date], S.arrive_on as [Arrival Date], SC.shipping_company_name as [Carrier], SS.status as Status " +
                        "from SHIPMENT S " +
                        "INNER JOIN SHIPPING_COMPANY SC on S.shipping_company_id = SC.shipping_company_id " +
                        "INNER JOIN SHIPMENT_STATUS SS on S.shipment_status_id = SS.shipment_status_id " +
            "order by S.shipment_id DESC";

            SQLiteDataAdapter sqdt = new SQLiteDataAdapter(sqlQuery, databaseObject.sqlConnection);
            sqdt.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];
                var req = new HttpRequestMessage(HttpMethod.Post, this.Url);
                //var req = new HttpRequestMessage(HttpMethod.Post, "https://private-anon-2c521532d5-trackhive.apiary-mock.com/");
                req.Headers.Add("Authorization", this.Token);
                req.Headers.Add("Accept", "application/json");

                var slugId = (row["carrier"].ToString().ToLower() != "dhl") ? row["carrier"].ToString().ToLower() : "dhl-pieceid";
                req.Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    ["tracking_number"] = row["tracking"].ToString(), // required
                    ["slug"] = slugId, // required
                    ["source"] = "Josh",
                });

                using (var client = new HttpClient())
                {
                    var res = await client.SendAsync(req);
                    string json = await res.Content.ReadAsStringAsync();
                }
                req.Dispose();
                Thread.Sleep(120);
            }

            MessageBox.Show("Completed", "Successfully Pushed!");
        }

        /// <summary>
        /// Get all shipments held in API server
        /// </summary>
        /// <returns>Datatable with all shipments</returns>
        public async void GetAllShipments()
        {

            var req = new HttpRequestMessage(HttpMethod.Get, this.Url+ "?pageId=1&limit=200");
            req.Headers.Add("Authorization", this.Token);
            req.Headers.Add("Accept", "application/json");
            var resJsonString = "";
            using (var client = new HttpClient())
            {
                var res = await client.SendAsync(req);
                resJsonString = await res.Content.ReadAsStringAsync();
            }
            req.Dispose();

            //var parsedResponse = JsonConvert.DeserializeObject(resJsonString);

            JToken token = JToken.Parse(resJsonString);
            JArray data = (JArray)token.SelectToken("data");
            foreach (var shipment in data)
            {
                var trackingNumber = shipment["tracking_number"].ToString() ?? "";
                var pickupDate = shipment["trackings"]["shipment_pickup_date"].ToString() ?? "";
                var expectedDelivery = shipment["trackings"]["expected_delivery"].ToString() ?? "";
                var slug = shipment["slug"].ToString().ToUpper() ?? "";
                if (slug.ToLower() == "dhl-pieceid") {
                    slug = "DHL";
                }
                else if (slug == "FEDEX") {
                    slug = "FedEx";
                }

                Shipment shipmentToAdd = new Shipment(trackingNumber, pickupDate, expectedDelivery, slug, "1");
                shipmentToAdd.addShipment();
            }
            
            Console.WriteLine(data.ToString());
            //var dt = new DataTable();

            //var req = new HttpRequestMessage(HttpMethod.Post, this.Url);
            //req.Headers.Add("Authorization", this.Token);
            //req.Headers.Add("Accept", "application/json");

            //return dt;
        }

        public class Statuses {
            public static string OutForDelivery = "OutForDelivery";
            public static string InTransit = "InTransit";
            public static string Delivered = "Delivered";
            public static string Exception = "Exception";
            public static string InfoReceived = "InfoReceived";
            public static string FailedAttempt = "FailedAttempt";
            public static string Pending = "Pending";
            public static string Expired = "Expired";
        }

        /* holds all of the different object that can be used for api request at the /trackings endpoint
        public class Rootobject
        {
            public Meta meta { get; set; }
            public Data data { get; set; }
        }

        public class Meta
        {
            public int code { get; set; }
        }

        public class Data
        {
            public string[] customer_emails { get; set; }
            public object[] customer_phone_numbers { get; set; }
            public string _id { get; set; }
            public string slug { get; set; }
            public string tracking_number { get; set; }
            public string source { get; set; }
            public string user_id { get; set; }
            public string language_type { get; set; }
            public Trackings trackings { get; set; }
            public string current_status { get; set; }
            public DateTime created { get; set; }
            public DateTime modified { get; set; }
            public string customer_name { get; set; }
            public string order_id { get; set; }
            public string order_url { get; set; }
        }

        public class Trackings
        {
            public object signed_by { get; set; }
            public string tag { get; set; }
            public Address address { get; set; }
            public float shipment_weight { get; set; }
            public string shipment_weight_unit { get; set; }
            public object expected_delivery { get; set; }
            public int delivery_time { get; set; }
            public string shipment_type { get; set; }
            public DateTime shipment_pickup_date { get; set; }
            public DateTime shipment_delivery_date { get; set; }
            public Checkpoint[] checkpoints { get; set; }
        }

        public class Address
        {
            public Ship_From ship_from { get; set; }
            public Ship_To ship_to { get; set; }
        }

        public class Ship_From
        {
            public string city { get; set; }
            public string state { get; set; }
            public object zip { get; set; }
            public string country_iso { get; set; }
            public string country_iso3 { get; set; }
            public string country_name { get; set; }
        }

        public class Ship_To
        {
            public string city { get; set; }
            public string state { get; set; }
            public object zip { get; set; }
            public string country_iso { get; set; }
            public string country_iso3 { get; set; }
            public string country_name { get; set; }
        }

        public class Checkpoint
        {
            public string slug { get; set; }
            public object created_at { get; set; }
            public object exception_code { get; set; }
            public string message { get; set; }
            public string tag { get; set; }
            public string subtag { get; set; }
            public string subtag_message { get; set; }
            public DateTime checkpoint_time { get; set; }
            public string city { get; set; }
            public string country_iso { get; set; }
            public string country_iso3 { get; set; }
            public string country_name { get; set; }
            public string state { get; set; }
            public int zip { get; set; }
            public string location { get; set; }
        }
        */
    }
}
