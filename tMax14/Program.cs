using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Drawing;

/*
character set=UTF8;data source=192.168.0.4;initial catalog=tMax14;user id=sysdba;password=masterkey
character set=UTF8;data source=192.168.0.4;initial catalog=DOCS;user id=sysdba;password=masterkey
character set=UTF8;data source=192.168.0.4;initial catalog=DEPO;user id=sysdba;password=masterkey 
character set=WIN1254;data source=192.168.0.4;initial catalog=TMAX06;user id=sysdba;password=masterkey
*/
namespace tMax14
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
        public static string USReMail = "Sener Demiral <sener.demiral@gmail.com>";
        public static string OWNER = "TO";  // TransOrient, TunaSet

        public static string smtp_FIRMA = "";  // TRANSORIENT, TUNASET
        public static string smtp_MAIL_FROM_ADDRESS = "";
        public static string smtp_MAIL_FROM_DISPLAY_NAME = "";
        public static string smtp_CLIENT_HOST = "";
        public static string smtp_CREDENTIALS_USER_NAME = "";
        public static string smtp_CREDENTIALS_USER_PASSWORD = "";
        public static string smtp_ENABLE_SSL = "";
        public static int smtp_PORT = 0;
        public static string smtp_TRAXON_USER_NAME = "";
        public static string smtp_TRAXON_USER_PASSWORD = "";

        public static string rprDvz = "EUR";
        public static mainForm MF;
        public static Qry.qryPrmsForm QPF;
        //public static MainDataSet.SMTPRow SMTP2;
        public static Timer timerIdle = new Timer();
        //public static MainXF mXF;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.UserSkins.BonusSkins.Register();
            ///UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            //UserLookAndFeel.Default.SetSkinStyle("Metropolis");
            //DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            /*
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                tMax14.Properties.Settings.Default["ConnectionString"] = "character set=WIN1254;data source=192.168.1.245;initial catalog=tMax14;user id=sysdba;password=masterkey;connectionlifetime=60;connectiontimeout=30";
            else
                tMax14.Properties.Settings.Default["ConnectionString"] = "character set=WIN1254;data source=LOCALHOST;initial catalog=tMax14;user id=sysdba;password=masterkey;connectionlifetime=60;connectiontimeout=30";
            */
            
            //DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("Tahoma", 10);
            MF = new mainForm();

            MF.FillTanimlar();
            QPF = new Qry.qryPrmsForm();
            //mXF = new MainXF();
            
            /*
            timerIdle = new System.Windows.Forms.Timer();
            timerIdle.Enabled = true;
            timerIdle.Interval = 10000; // Idle time period. Here after 5 minutes perform task in  timerIdle_Tick
            timerIdle.Tick += timerIdle_Tick;
            Application.AddMessageFilter(new TestMessageFilter());
            */
            if (new Login.LoginForm().ShowDialog() == DialogResult.OK)
            {
                //QPF = new Qry.qryPrmsForm();
                Application.Run(MF);
                //Application.Run(mXF);
            }
        }

        static void timerIdle_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    /*
    [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.LinkDemand, Flags = System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public class TestMessageFilter : IMessageFilter
    {
        // http://www.faisalmb.com/post/Detecting-Idle-time-or-Inactivity-in-Windows-Forms.aspx
        //Following are the Windows API hex values. You can find more at http://faisalmb.com/blog/post/2009/01/Values-of-Windows-API.aspx
        // Here we are only interested in only Keyboard and Mouse activities
        private int WM_LBUTTONDOWN = 0x0201;
        private int WM_KEYDOWN = 0x0100;
        private int WM_RBUTTONDOWN = 0x0204;
        private int WM_MBUTTONDOWN = 0x0207;
        private int WM_MOUSEWHEEL = 0x020A;
        private int WM_MOUSEMOVE = 0x0200;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE || m.Msg == WM_KEYDOWN || m.Msg == WM_LBUTTONDOWN || m.Msg == WM_MOUSEWHEEL || m.Msg == WM_RBUTTONDOWN || m.Msg == WM_MBUTTONDOWN)
            {
                Program.timerIdle.Stop();
                Program.timerIdle.Start();
            }
            return false;
        }
    }
    */
}
