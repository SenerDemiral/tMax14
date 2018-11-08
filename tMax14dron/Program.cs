using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tMax14dron
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;
            if (!exists)
                Application.Run(new XtraForm2());
        }
    }
}
