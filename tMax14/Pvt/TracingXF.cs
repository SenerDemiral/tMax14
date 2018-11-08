using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Net.Mime;
using System.Net.Mail;

namespace tMax14.Pvt
{
    public partial class TracingXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "TracingXF";
        
        public TracingXF()
        {
            InitializeComponent();
        }

        private void TracingXF_Load(object sender, EventArgs e)
        {
            Program.MF.XGLrestore(layoutName, 0, dGridView);

            this.rPR_TRACINGTableAdapter.Fill(this.pvtDataSet.RPR_TRACING);
            this.rPR_TRACING_DTYTableAdapter.Fill(this.pvtDataSet.RPR_TRACING_DTY);
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mGridView.MoveFirst();
            for (int i = 0; i < mGridView.RowCount; i++)
            {
                DataRow row = mGridView.GetDataRow(i);
                if (!string.IsNullOrEmpty(row["EMAILS"].ToString()) ) 
                    eMailExcel(row);
                mGridView.MoveNext();
            }
        }

        private void eMailExcel(DataRow row)
        {
            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();
            string eMails = row["EMAILS"].ToString();
            string eMailSubject = row["EMAILSUBJECT"].ToString();
            string eMailBody = row["EMAILBODY"].ToString();

            using (MemoryStream memStream = new MemoryStream())
            {
                dGridView.ExportToXls(memStream);

                // Create a new attachment and put the Excel report into it.
                memStream.Seek(0, System.IO.SeekOrigin.Begin);
                System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(memStream, "Tracing.xls", "application/xls");

                MailMessage mail = new MailMessage();
                mail.Attachments.Add(att);

                mail.To.Add(eMails);
                mail.Subject = eMailSubject;
                mail.Body = eMailBody;
                mail.IsBodyHtml = true;

                mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                smtp.Port = SMTP.PORT;

                smtp.Send(mail);

                mail.Dispose();

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = dGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rPR_TRACING_DTYTableAdapter.Update(this.pvtDataSet.RPR_TRACING_DTY);
        }

    }
}