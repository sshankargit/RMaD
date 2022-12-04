using RMaD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RMaD
{
    public partial class AddShipment : Form
    {
        public AddShipment()
        {
            InitializeComponent();
            populateCarrier();

        }

        private void dtpShipped_ValueChanged(object sender, EventArgs e)
        {

        }

        private void populateCarrier()
        {
            ShippingService shipServ = new ShippingService();
            tbCarrierdpdn.Items.Clear();

            List<string> ls = new List<string>();

            ls = shipServ.loadShippingServList();
            foreach (string item in ls)
            {
                tbCarrierdpdn.Items.Add(item);
            }
        }

        private void AddShipment_Load(object sender, EventArgs e)
        {

        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            
            Shipment newShipment = new Shipment();

            if (string.IsNullOrEmpty(mtbTracking.Text))
            {
                MessageBox.Show("Tracking number is required.", "Failed!");
                return;
            }
           
            if (string.IsNullOrEmpty(tbCarrierdpdn.Text))
            {
                MessageBox.Show("Shipping carrier is required.", "Failed!");
                return;
            }

            List<string> shipment = new List<string>();
            shipment.Add(mtbTracking.Text);
            shipment.Add(dtpShipped.Text);
            shipment.Add(dtpArrival.Text);
            shipment.Add(tbCarrierdpdn.Text);

            newShipment.addShipment(shipment);        
        }
    }
}
