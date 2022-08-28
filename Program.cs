using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryStock
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            Form2 fm = new Form2();
            Application.Run(lg);

            if (lg.isLogIn = true)
            {
                Application.Run(fm);
            }

        }
    }
}
