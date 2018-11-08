using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tMax14agn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static int USTid = -1;
        public static string USTad = "ADMIN";
        public static string USR = "ADMN";
        public static string USRtag = "<ADMN>";
        public static string rprDvz = "EUR";
        public static int agn = 17;
        public static string agnAd = "";
        public static mainForm MF;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginXF lf = new loginXF();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                MF = new mainForm();
                //MF.FillTanimlar();

                Application.Run(MF);
            }
        }
    }
}
