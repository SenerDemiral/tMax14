using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Mail;
using System.IO;

namespace tMax14.KaliteKontrol
{
    public partial class kkSendMailXF : DevExpress.XtraEditors.XtraForm
    {
        public string tbl = "O";    // Olay/Muhatap/Faaliyet
        public int refID = 0;
        private MainDataSet.SMTPRow SMTP;

        public kkSendMailXF()
        {
            InitializeComponent();
        }

        private void kkSendMailXF_Load(object sender, EventArgs e)
        {
            SMTP = Program.MF.SMTP();
            
            this.kKES_TBL_SELTableAdapter.Fill(this.kkDataSet.KKES_TBL_SEL, tbl, refID);
        }

        private void sendEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kksmGridView.GetFocusedRowCellValue("EMAILS").ToString()))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                MailMessage mail = new MailMessage();

                mail.To.Add(kksmGridView.GetFocusedRowCellValue("EMAILS").ToString());

                mail.Subject = kksmGridView.GetFocusedRowCellValue("SUBJECT").ToString();
                mail.Body = kksmGridView.GetFocusedRowCellValue("BODY").ToString();
                mail.IsBodyHtml = false;

                mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                smtp.Port = SMTP.PORT;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error sending eMail.\n" + ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

    }
}