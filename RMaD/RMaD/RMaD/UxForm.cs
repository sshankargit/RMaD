using RMaD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMaD
{
    public partial class UxForm : Form
    {
        List<Panel> panelList = new List<Panel>();
        List<Button> buttonList = new List<Button>();
        private int _shipments;

        private SQLiteDataReader result;
        private SQLiteCommand sqlCommand;
        string sqlQuery;

        /// <summary>
        /// Counts the amount of shipments in the Flow Layout Panel 
        /// countained in the shipments panel
        /// </summary>
        public int Shipments { get; set; }

        public UxForm()
        {
            InitializeComponent();
        }

        private void UxForm_Load(object sender, EventArgs e)
        {   
            // List indexes the panels from 0..4
            panelList.Add(pnlShipments);
            panelList.Add(pnlGroups);
            panelList.Add(pnlReports);
            panelList.Add(pnlUser);
            panelList.Add(pnlSettings);

            buttonList.Add(btnShipmentMenu);
            buttonList.Add(btnGroupMenu);
            buttonList.Add(btnReportsMenu);
            buttonList.Add(btnUserMenu);
            buttonList.Add(btnSettingsMenu);

            //this._shipments = this.flpShipments.Controls.Count;
            changePanel(0);
            populateDataGridView();
        }

        private void btnShipmentMenu_Click(object sender, EventArgs e)
        {
            changePanel(0);
        }

        private void btnGroupMenu_Click(object sender, EventArgs e)
        {
            changePanel(1);
        }

        private void btnReportsMenu_Click(object sender, EventArgs e)
        {
            changePanel(2);
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            changePanel(3);
        }

        private void btnSettingsMenu_Click(object sender, EventArgs e)
        {
            changePanel(4);
        }

        /// <summary>
        /// Change Panel will show the panel sent to the method and deactivate the button used
        /// to change to a new panel. It will then hide the panels that are not in use and will
        /// enable the buttons needed to change to those panels.
        /// </summary>
        /// <param name="panel">Index of panel being changed to</param>
        private void changePanel(int panel)
        {
            panelList[panel].Show();
            buttonList[panel].Enabled = false;

            for (int i = 0; i < panelList.Count; i++)
            {
                if (i != panel)
                {
                    panelList[i].Hide();
                    buttonList[i].Enabled = true;
                }
            }
        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            bool creating = true;
            AddShipment ship = new AddShipment();
            DialogResult drShip = new DialogResult();

            while(creating == true)
            {
                if(drShip == DialogResult.OK)
                {
                    this.Shipments++;
                    //newShipment(Shipments);
                    creating = false;
                }
                else if(drShip == DialogResult.Cancel)
                {
                    creating = false;
                }
                else
                {
                    drShip = ship.ShowDialog();
                }
            }
            
        }

        /// <summary>
        /// Creates a new shipment button within the Flow Layout Panel.
        /// </summary>
        /// <param name="shipNum">The index of the new button</param>
        private void newShipment(int shipNum)
        {
            Button btnShipment = new Button();
            btnShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnShipment.Name = "btnShipment";
            btnShipment.Size = new System.Drawing.Size(450, 50);
            btnShipment.TabIndex = 1;
            btnShipment.Text = "Shipment " + shipNum.ToString(); // change to data pull from data tables
            btnShipment.UseVisualStyleBackColor = true;
            //flpShipments.Controls.Add(btnShipment);
        }

        /// <summary>
        /// Populate grid with shipments queried from database
        /// </summary>
        /// <param </param>
        private void populateDataGridView()
        {
            dataGridViewShipment.DataSource = null;
            DatabaseAccess databaseObject = new DatabaseAccess();
            databaseObject.OpenConnection();
            DataTable dt = new DataTable();

            sqlQuery = "select S.tracking_id as [Tracking], S.shipped_on as [Shipped Date], S.arrive_on as [Arrival Date], SC.shipping_company_name as [Carrier], SS.status as Status " +
                        "from SHIPMENT S " +
                        "INNER JOIN SHIPPING_COMPANY SC on S.shipping_company_id = SC.shipping_company_id " +
                        "INNER JOIN SHIPMENT_STATUS SS on S.shipment_status_id = SS.shipment_status_id " +
                        "order by S.shipment_id DESC";            

            SQLiteDataAdapter sqdt = new SQLiteDataAdapter(sqlQuery, databaseObject.sqlConnection);
            sqdt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewShipment.DataSource = dt;                

                for (int i = 0; i < dataGridViewShipment.Columns.Count; i++)
                {
                    dataGridViewShipment.Columns[i].Frozen = false;
                }

                dataGridViewShipment.Columns["Tracking"].DefaultCellStyle.Format = "N2";
                dataGridViewShipment.RowHeadersVisible = false;               
            }            
            databaseObject.CloseConnection();
        }

    }
}
