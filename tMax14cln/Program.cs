using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tMax14cln
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static int cln = 31967;
        public static string clnAd = "";

        public static mainXF MF;

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginXF lf = new loginXF();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                MF = new mainXF();
                //MF.FillTanimlar();

                Application.Run(MF);
            }

        }
    }
}
