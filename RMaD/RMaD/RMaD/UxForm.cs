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

namespace RMaD
{
    public partial class UxForm : Form
    {
        List<Panel> panelList = new List<Panel>();
        List<Button> buttonList = new List<Button>();

        public UxForm()
        {
            InitializeComponent();
        }

        private void UxForm_Load(object sender, EventArgs e)
        {   
            // List indexes panels from 0..4
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

            changePanel(0);
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

        private void UxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
