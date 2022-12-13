using NUnit.Framework;
using RMaD.Classes;
using System.Collections.Generic;
using System.Web;

namespace RMaD.Test
{
    public class ShipmentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("32342343", "2022-12-1", "2022-12-12", "UPS", "Shipped")]
        [TestCase("42342343", "2022-12-5", "2022-12-25", "FedEx", "In-Transit")]
        [TestCase("52342343", "2022-12-11", "2022-12-19", "USPS", "Pending")]
        public void TestAddShipment(string trackID, string shipDt, string arrDt, string carrier, string status )
        {
            Shipment s = new Shipment(trackID, shipDt, arrDt, carrier, status);
            s.addShipment();
            Assert.IsTrue(s.trackIDExists(trackID));
        }

        [Test]
        [TestCase("32342343", "2022-12-2", "2022-12-13", "FedEx", "In-Transit")]
        [TestCase("42342343", "2022-12-6", "2022-12-26", "UPS", "In-Transit")]
        [TestCase("52342343", "2022-12-12", "2022-12-20", "UPS", "Pending")]
        public void TestUpdateShipment(string trackID, string shipDt, string arrDt, string carrier, string status)
        {
            Shipment S = new Shipment(trackID, shipDt, arrDt, carrier, status);
            S.updateShipment();
            List<string> list = S.getShipmentByTrackID(trackID);
            Shipment S1 = new Shipment(list[0].ToString(), list[1].ToString(), list[2].ToString(), list[3].ToString(), list[4].ToString());
            Assert.AreEqual(shipDt,S1.DateShipped);
            Assert.AreEqual(arrDt, S1.DateArrival);
            Assert.AreEqual(carrier, S1.Carrier);
            Assert.AreEqual(status, S1.ShipmentStatus);
        }

    }
}