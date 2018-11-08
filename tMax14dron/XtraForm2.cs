using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Xml;

namespace tMax14dron
{
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        //Cron dvzKurCron = new Cron("* * * * *");    // Min:0-59 Hour:0-23, Day:1-31, WeekDay:0-6, Month:1-12
        Cron dvzKurCron = new Cron("0 8 * 1,2,3,4,5 *");    // Min:0-59 Hour:0-23, Day:1-31, WeekDay:0-6, Month:1-12
        DateTime NOW;
        string abcd = "aaaa";
        public XtraForm2()
        {
            InitializeComponent();

            //if (!dvzKurBackgroundWorker.IsBusy)
            //    dvzKurBackgroundWorker.RunWorkerAsync(abcd);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NOW = DateTime.Now;
            //Text = NOW.ToString();
            if (dvzKurCron.CanRunNow(NOW))
                if (!dvzKurBackgroundWorker.IsBusy)
                    dvzKurBackgroundWorker.RunWorkerAsync(abcd);
        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        #region dovizKurlari
        private void dvzKurBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            hstGridView.BeginDataUpdate();  // Cross Thread'den kurtulmak icin
            
            //BAarg arg = e.Argument as BAarg;
            string arg = e.Argument as string;
            //Thread.Sleep(1000);
           // e.Result = arg;
            //throw new InvalidOperationException("asffasd");
            arg = "sener"; // nodeList.ToString();

            bool tcmbOK = true, yapiOK = true;

            XmlDocument doc = new XmlDocument();
            doc.Load("http://api.piyasa.com/xml/?kaynak=doviz_guncel_tcmb");    // Merkez Bankasi

            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;

            nodeList = root.SelectNodes("node");
            
            if (nodeList.Count == 0)
            {
                hstDataSet.HST.AddHSTRow(NOW, "Kur", "MB Kurları alınamadı", "");
                tcmbOK = false;
            }
            else
                hstDataSet.HST.AddHSTRow(NOW, "Kur", "", "MB Kurları alındı");
            
            foreach (XmlNode xn in nodeList)
            {
                string foex = xn["foex"].InnerText;
                string buy = xn["buy"].InnerText;
                string sell = xn["sell"].InnerText;
                queriesTableAdapter.KUR_UPD(foex, "MB", buy, sell); 
            }
            
            doc.RemoveAll();
            doc.Load("http://api.piyasa.com/xml/?kaynak=doviz_guncel_yapi");    // Yapi Kredi

            root = doc.DocumentElement;

            nodeList = root.SelectNodes("node");
            if (nodeList.Count == 0)
            {
                hstDataSet.HST.AddHSTRow(NOW, "Kur", "YK Kurları alınamadı", "");
                yapiOK = false;
            }
            else
                hstDataSet.HST.AddHSTRow(NOW, "Kur", "", "YK Kurları alındı");
            foreach (XmlNode xn in nodeList)
            {
                string foex = xn["foex"].InnerText;
                string buy = xn["buy"].InnerText;
                string sell = xn["sell"].InnerText;
                queriesTableAdapter.KUR_UPD(foex, "YK", buy, sell);
            }
            
            if (tcmbOK && yapiOK)
            {
                dvzKurCron.prevRunDay = NOW.ToString("dd.MM.yy");
                e.Result = "OK";
            }
            else
                e.Result = "HATA";
        }

        private void dvzKurBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                hstDataSet.HST.AddHSTRow(NOW, "Kur", e.Error.Message, "");
            else
                Text = e.Result.ToString();

            hstGridView.EndDataUpdate();  // Cross Thread'den kurtulmak icin
            hstGridView.RefreshData();
            //Text = NOW.ToString();
        }
        #endregion dovizKurlari

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraForm2_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kurUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dvzKurBackgroundWorker.IsBusy)
            {
                dvzKurBackgroundWorker.RunWorkerAsync(abcd);
            }
        }
    }
}