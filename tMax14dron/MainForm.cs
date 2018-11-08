using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tMax14dron
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        Cron BACron = new Cron("* * * * 4");    // Min:0-59 Hour:0-23, Day:1-31, WeekDay:0-6, Month:1-12
        Cron BJCron = new Cron("* * * * *");
        BAarg baArg = new BAarg();
        BJarg bjArg = new BJarg();
        DateTime NOW;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
            //this.ShowInTaskbar = false;
            
            //Size ps = this.Size;
            //ps.Height -= 30;
            //panelContainer1.Size = ps;

            timer.Interval = 60 * 1000; // 1dak
            timer.Tick += timer_Tick;
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            NOW = DateTime.Now;
            if (BACron.CanRunNow(NOW))
                if (!BAbackgroundWorker.IsBusy)
                    BAbackgroundWorker.RunWorkerAsync(baArg);

            if (BJCron.CanRunNow(NOW))
                if (!BJbackgroundWorker.IsBusy)
                {
                    //BJselAktifGridControl.DataSource = null;
                    BJselAktifGridView.BeginDataUpdate();

                    BJbackgroundWorker.RunWorkerAsync(bjArg);
                }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BAsimpleButton_Click(object sender, EventArgs e)
        {
            if (!BAbackgroundWorker.IsBusy)
                BAbackgroundWorker.RunWorkerAsync(baArg);

        }

        #region BusinessActivity

        private void BAbackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BAarg arg = e.Argument as BAarg;

            Thread.Sleep(1000);
            arg.DoneTS = (DateTime)queriesTableAdapter.BA_DRON();
            e.Result = arg;
        }

        private void BAbackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BAarg arg = e.Result as BAarg;

            BAlistBoxControl.Items.Insert(0, arg.DoneTS.ToString());
            if (BAlistBoxControl.Items.Count > 100)
                BAlistBoxControl.Items.RemoveAt(100);
        }

        #endregion BusinessActivity

        private void BJbackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BJarg arg = e.Argument as BJarg;

            arg.NOR = this.BJselAktifTableAdapter.Fill(this.dataSet.BJ_SEL_AKTIF);
            //DoJobs();

            string HataMsj = string.Empty;
            //Thread.Sleep(5000);
            for (int i = 0; i < this.dataSet.BJ_SEL_AKTIF.Rows.Count; i++)
                if (this.dataSet.BJ_SEL_AKTIF.Rows[i]["USR"].ToString() == "dron")
                {
                    this.dataSet.BJ_SEL_AKTIF.Rows[i]["ENDTS"] = DateTime.Now;
                    // Hata mesajlarini reportProgres ile gonder ki LOG edilebilsin
                    arg.Msj = SendMail(i);
                    BJbackgroundWorker.ReportProgress(i, arg);
                }

            
            /*
            Form f = new Form();
            GridControl grid = new GridControl();
            grid.Parent = f;
            grid.Visible = true;
            GridView view = new GridView(grid);
            grid.DataSource = this.dataSet.BJ_SEL_AKTIF;
            grid.Location = new System.Drawing.Point(0, 0);
            grid.MainView = view as BaseView;
            grid.Name = "GridControl2";
            grid.Size = new System.Drawing.Size(518, 273);
            grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { (BaseView)view });
            view.GridControl = grid;
            view.Name = "TempGridView1";
            //view.RestoreLayoutFromStream(dataStream, DevExpress.Utils.OptionsLayoutBase.FullLayout);
            //dataStream.Close();
            grid.ExportToPdf(@"C:\" + DateTime.Now.Minute.ToString() + ".PDF");
             * */

            arg.ExecutionTS = DateTime.Now;

            e.Result = arg;
        }

        private string SendMail(int rowId)
        {
            string msj = string.Empty;
            DataSet.BJ_SEL_AKTIFRow bjRow = (DataSet.BJ_SEL_AKTIFRow)this.dataSet.BJ_SEL_AKTIF.Rows[rowId];
            
            try
            {
                using (MemoryStream mem = new MemoryStream())
                {
                    XtraReport1 rprt = new XtraReport1();
                    //string fn = @"C:\Rapor-" + DateTime.Now.Minute.ToString() + ".PDF";
                    //rprt.ExportToPdf(fn);

                    rprt.ExportToPdf(mem);

                    // Create a new attachment and put the PDF report into it.
                    mem.Seek(0, System.IO.SeekOrigin.Begin);
                    Attachment att = new Attachment(mem, "TestReport.pdf", "application/pdf");

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("transorient.tmax@gmail.com", "Transorient tMax Drone");
                    mail.To.Add(bjRow.KIMLERE); // Virgulle ayrilmis bircok adres olabilir
                    //mail.Subject = string.Format("{0} From:{1} Tbl:{2} TblPK:{3}", addSubjectTextEdit.Text, Program.USTad, Tbl, TblPK);
                    mail.Subject = "Deneme DRON";
                    mail.Body = "Deneme DRON";

                    //Attachment atc = new Attachment(fn);
                    mail.Attachments.Add(att);

                    mail.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    //smtp.Credentials = new System.Net.NetworkCredential("transorient.tmax", "tMaxTeam");
                    smtp.Credentials = new System.Net.NetworkCredential("transorient.tmax", "HATATEST");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    msj = string.Format("{0}.{1} {2}/{3} {4}/{5} {6} @{7}", bjRow.REFTBL, bjRow.REFID, bjRow.BJDID, bjRow.BJDAD, bjRow.BIPID, bjRow.BIPAD, bjRow.KIMLERE, DateTime.Now);

                }
            }
            catch (Exception ex)
            {
                msj = string.Format("HATA : {0}.{1} {2}/{3} {4}/{5} {6} @{7}, {8}", bjRow.REFTBL, bjRow.REFID, bjRow.BJDID, bjRow.BJDAD, bjRow.BIPID, bjRow.BIPAD, bjRow.KIMLERE, DateTime.Now, ex.Message);
                //msj = string.Format("{1} Error sending eMail to: {0}", bjRow.KIMLERE, DateTime.Now);
            }
            return msj;
        }

        private void BJbackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BJarg arg = e.Result as BJarg;
            //BJlayoutControlGroup.Text = arg.NOR.ToString();
            BJupdTStextEdit.Text = arg.ExecutionTS.ToString();
            BJselAktifGridView.EndDataUpdate();
            //BJselAktifGridControl.DataSource = BJselAktifBindingSource;
        }

        private void BJbackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //MessageBox.Show(bjArg.Msj);
            BJlistBoxControl.Items.Insert(0, bjArg.Msj);
        }
    
        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }
    }



    class BAarg
    {
        public DateTime DoneTS { get; set; }
    }

    class BJarg
    {
        public DateTime ExecutionTS { get; set; }
        public int NOR { get; set; }
        public string Msj { get; set; }
    }
}
