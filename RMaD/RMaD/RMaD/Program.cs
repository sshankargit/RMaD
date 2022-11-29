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
                if (login.ShowDialog() == DialogResult.OK)
                {
                    logging  = false;
                    result = DialogResult.OK;
                }
            }

            if(result == DialogResult.OK)
            {
                Application.Run(new UxForm());
            }
        }
    }
}
