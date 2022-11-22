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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // authenticate login
            // pull user and data
            // check api and pull data if status or delivery time has changed
            // load ui forms

            var auth = new Authentication(this.tbUsername.Text, this.tbPassword.Text);
            var ux = new UxForm();
            ux.Location = this.Location;
            ux.StartPosition = FormStartPosition.Manual;
            ux.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var create = new CreateAccount();
            create.Location = this.Location;
            create.StartPosition = FormStartPosition.Manual;
            create.Show();
            create.FormClosing += delegate { this.Show(); };
            this.Hide();
        }
    }
}
