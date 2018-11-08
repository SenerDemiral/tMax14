using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tMax14mnf
{
    static class Program
    {
        public static string USR = "ADMN";
        public static int mnf = 10827;
        public static string mnfAd = "";
        public static MainForm MF;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginXF lf = new loginXF();

            if (lf.ShowDialog() == DialogResult.OK)
            {
                USR = mnf.ToString();
                if (USR.Length > 4)
                    USR = USR.Substring(USR.Length - 4, 4);

                MF = new MainForm();
                Application.Run(MF);
            }
        }
    }
}
