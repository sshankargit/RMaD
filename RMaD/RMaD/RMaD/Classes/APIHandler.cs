using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
        public APIHandler(string url, string endpoint)
        {
            //get token from database
            // this._token = "Bearer " + token from database;
            this._token = "Bearer " + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjYzOGQyMmRmOWM0OGEwMD" +
                "AyZDk3OTI5MiIsImlhdCI6MTY3MDE5Mzk0N30.NAMYKyQEsLTkHqhgF2DQ4EgAIUNhujCePx30Ze0-Zm0";
            this._url = url + endpoint;
        }

        public async void PostJson()
        {
            var req = new HttpRequestMessage(HttpMethod.Post, this.Url);
            req.Headers.Add("Authorization", this.Token);
            req.Headers.Add("Accept", "application/json");
            req.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["slug"] = "usps", // required
                ["tracking_number"] = "12341234", // required
                ["customer_name"] = "", // an array of strings of names
                ["customer_emails"] = "",// an array of strings of emails to recieve tracking updates
                ["source"] = "", // origin shipment is coming from
                ["origin_country"] = ""
            });

            using (var client = new HttpClient())
            {
                var res = await client.SendAsync(req);
                string json = await res.Content.ReadAsStringAsync();
            }
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
        // POST
        // COMPARE
        // GET
        // CREATE INVITE
    }
}
