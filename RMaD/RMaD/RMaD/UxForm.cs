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

        public UxForm()
        {
            InitializeComponent();
        }
        /*
        public UxForm(Authentication login)
        {
            
            this.username = login.Username;
            this.password = login.Password;
            InitializeComponent();
        }

        public UxForm(Authentication login, Point location, FormStartPosition manual) : this(login)
        {
            this.Location = location;
            this.StartPosition = manual;
            this.username = login.Username;
            this.password = login.Password;
            InitializeComponent();
        } */

        public void FillTextBoxes()
        {

        }

        private void UxForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
