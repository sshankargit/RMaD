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

            //Validate inputs
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Username is required.", "Failed!");
                return;
            }

            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Password is required.", "Failed!");
                return;
            }

            Authentication loginUser = new Authentication(tbUsername.Text, tbPassword.Text);
            Boolean loginSuccess= loginUser.login();

            if (loginSuccess)
            {
                MessageBox.Show("Login Success!", "Success!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                MessageBox.Show("Login Failed! User name or Password is incorrect.", "Login Failed!");
                this.DialogResult = DialogResult.Retry;
                this.Close();                
                return;
            }

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
            this.Close();
        }

        private void llHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/CSC-470-Project/RMaD");
        }

        private void RMaD_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbUsername;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnSubmit_Click(sender, e);
            }
        }
    }
}
