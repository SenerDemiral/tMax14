using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace tMax14Backup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DateTime now = DateTime.Now;
            string fdbPath = @"C:\DATA\tMax\"; //@"F:\tMax14\DATA\";
            string zipPath = @"C:\Backup\";    //@"F:\tMax14\Backup\";

            string fdbName = fdbPath+"tMax14.FDB";
            string fbkName = string.Format("{0}tMax14-{1}.fbk", zipPath, now.ToString("yyMMdd-HHmm"));
            string zipName = string.Format("{0}tMax14-{1}.fbk.7z", zipPath, now.ToString("yyMMdd-HHmm"));

            ProcessStartInfo p = new ProcessStartInfo();
            Process x;

            try
            {
                // Firebird Backup
                p.FileName = @"C:\Program Files\Firebird\Firebird_2_5\bin\gbak.exe";
                p.Arguments = string.Format("-b -user SYSDBA -password masterkey {0} {1}", fdbName, fbkName);
                p.WindowStyle = ProcessWindowStyle.Hidden;
                x = Process.Start(p);
                x.WaitForExit();

                // 7Zip BackupFile
                p.FileName = @"C:\Program Files\7-Zip\7z.exe";
                p.Arguments = string.Format("a -t7z \"{0}\" \"{1}\" -mx=9  -mmt", zipName, fbkName);
                x = Process.Start(p);
                x.WaitForExit();

                // Delete BackupFile
                File.Delete(fbkName);
            }
            catch (Exception)
            {
            }
        }
    }
}
