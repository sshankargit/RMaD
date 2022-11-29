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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // validate account information
            // check username vs current usernames(possibly against emails as well)
            // add to database if no conficts
            // display confirmation that account has been created
            // close form after x second timer (test to see what feel right)

            // set to dialog to ok for testing purposes
            this.DialogResult = DialogResult.OK;
        }
    }
}
