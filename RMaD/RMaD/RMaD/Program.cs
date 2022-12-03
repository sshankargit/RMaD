using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMaD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool logging = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RMaD login = new RMaD();
            var result = new DialogResult();

            while (logging == true)
            {
                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    logging = false;
                    login.Close();
                }
                else
                {
                    result = login.ShowDialog();
                }
            }

            if (result == DialogResult.OK)
            {
                Application.Run(new UxForm());
            }
        }
    }
}
