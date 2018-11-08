using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agn
{
    static class Program
    {
        public static int AgnID = 17;
        public static MainXF MF;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MF = new MainXF();
            Application.Run(MF);
        }
    }
}
