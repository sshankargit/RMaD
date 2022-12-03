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
    public partial class RMaD : Form
    {
        public RMaD()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On click will check to see if a login is valid. If the login is valid the
        /// program will continue with the login process. If the login is invalid the program
        /// will add an error message and reprompt the user for a login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            // authenticate login
            // pull user and data
            // check api and pull data if status or delivery time has changed
            // load ui forms

            // for testing purposed login will not be checked
            
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var newAccount = new CreateAccount();
            newAccount.Location = this.Location;
            newAccount.StartPosition = FormStartPosition.Manual;
            if(newAccount.ShowDialog().Equals(DialogResult.OK))
            {
                // add account
                // else do nothing
            }
            this.DialogResult = DialogResult.Retry;
        }

        private void RMaD_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void llHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/CSC-470-Project/RMaD");
        }
    }
}
