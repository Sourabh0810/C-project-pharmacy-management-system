using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         // Application.Run(new Manufacture());
           // Application.Run(new Sellers());
         //  Application.Run(new login());

            Application.Run(new Load());

          //Application.Run(new Sellers());
          // Application.Run(new Medicine());
          //Application.Run(new Customers());
          // Application.Run(new Dashboard());
           // Application.Run(new Selling());
        }
    }
}
