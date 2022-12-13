using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMaD.Classes;

namespace RMaD
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create user object and calls add user method.
        /// validate account information
        /// check username vs current usernames(possibly against emails as well)
        /// add to database if no conficts
        /// display confirmation that account has been created
        /// close form after x second timer (test to see what feel right)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate Inputs
            if (string.IsNullOrEmpty(tbFirstname.Text))
            {
                MessageBox.Show("Firstname cannot be empty.", "Failed!");
                return;
            }

            if (string.IsNullOrEmpty(tbLastname.Text))
            {
                MessageBox.Show("Lastname cannot be empty.", "Failed!");
                return;
            }

            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Failed!");
                return;
            }

            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Failed!");
                return;
            }

            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("EmailId cannot be empty.", "Failed!");
                return;
            }

            User newUser = new User(tbFirstname.Text, tbLastname.Text, tbUsername.Text, tbPassword.Text, tbEmail.Text, tbToken.Text);

            //Check if username or email address already exists
            //Account will not be created if username or email address already exists.
            if (newUser.userExists())
            {
                MessageBox.Show("Username or Email already exists.", "Create New User Failed!");
                return;
            }
            else {
                Boolean addedUser = newUser.addUser();
                if (addedUser)
                {
                    MessageBox.Show("User has been created successfully.", "Create New User Success!");
                }
                else
                {
                    MessageBox.Show("Error occured. New user was not created.", "Create New User Failed!");
                }

            }
            
        }

        /// <summary>
        /// Close the form on clicking cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
