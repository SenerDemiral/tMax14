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
using System.Net.Mail;

namespace tMax14ReportClassLibrary
{
    public partial class TopluExtreXF : DevExpress.XtraEditors.XtraForm
    {
        public string USR;
        public string USReMail;
        private ReportDataSet.RPT_GETRow rptRow;
        private bool hata = false;
        private ReportDataSet.SMTPRow SMTP;
        
        public TopluExtreXF()
        {
            InitializeComponent();

            DateTime today = DateTime.Today;
            dateEdit1.EditValue = new DateTime(today.Year, today.Month, 1);
            today = today.AddMonths(1);
            dateEdit2.EditValue = new DateTime(today.Year, today.Month, 1);
        }

        private void TopluExtreXF_Load(object sender, EventArgs e)
        {
            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DateTime today = dateEdit1.DateTime.AddMonths(1);
            dateEdit2.EditValue = new DateTime(today.Year, today.Month, 1);
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rteTableAdapter.Fill(this.reportDataSet.RPR_TOPLUEXTRE, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue, icDisRadioGroup.EditValue.ToString());

                if (icDisRadioGroup.EditValue.ToString() == "D")
                    this.rptGetTableAdapter.Fill(this.reportDataSet.RPT_GET, 100);  // Extre Dis
                else
                    this.rptGetTableAdapter.Fill(this.reportDataSet.RPT_GET, 101);  // Extre Ic
                rptRow = this.reportDataSet.RPT_GET[0];

                eMailSubjectTextEdit.Text = rptRow.EMAILSUBJECT;
                eMailBodyRichEditControl.Document.HtmlText = rptRow.EMAILBODY;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void sendSimpleButton_Click(object sender, EventArgs e)
        {
            rteBindingSource.EndEdit();
            sendSimpleButton.Enabled = false;
            // Borc kalani yoksa KLNS bos gelir
            foreach (ReportDataSet.RPR_TOPLUEXTRERow rtfRow in this.reportDataSet.RPR_TOPLUEXTRE.Rows)
            {
                if (!rtfRow.IsEMAILSNull() && !string.IsNullOrEmpty(rtfRow.EMAILS) && !rtfRow.IsKLNSNull() && !string.IsNullOrEmpty(rtfRow.KLNS) && rtfRow.OK == "T")
                {
                    if (minVdeDateEdit.EditValue == null || rtfRow.MINVDE < minVdeDateEdit.DateTime)
                        send2Firma(rtfRow.FRTID, rtfRow.EMAILS);
                        //MessageBox.Show(rtfRow.MINVDE.ToString());
                }
            }
        }

        private void send2Firma(int frtID, string eMail)
        {
            if (!string.IsNullOrEmpty(USReMail))
                eMail += ", " + USReMail;  // Aktif usera da mail gonder Control

            string fn = "Statement.pdf";

            MemoryStream ms = new MemoryStream();

            ExtreXR rpr = new ExtreXR(frtID, dateEdit1.DateTime, dateEdit2.DateTime);   //////////////////////////////////////////////////
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            var attachment = new Attachment(ms, fn);

            sendMail(eMail, eMailSubjectTextEdit.Text, eMailBodyRichEditControl.Document.HtmlText, attachment);

            if (!hata)
            {
                reportQueriesTableAdapter.RPH_INS(rptRow.KOD, "FRT", frtID, USR, "F", null);
            }
        }

        private void sendMail(string mailTo, string subject, string body, Attachment attachment)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                MailMessage mail = new MailMessage();

                mail.To.Add(mailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                mail.Attachments.Add(attachment);

                mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                smtp.Port = SMTP.PORT;

                smtp.Send(mail);
                hata = false;
            }
            catch (Exception ex)
            {
                hata = true;
                stuLabelControl.Text = "Hata! " + ex.Message;
                if (ex.InnerException != null)
                    stuLabelControl.Text = string.Format("Hata! {0}\n{1}", ex.Message, ex.InnerException.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void minVdeDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (minVdeDateEdit.EditValue == null)
                rteBindingSource.Filter = "";
            else
                rteBindingSource.Filter = string.Format("MINVDE < '{0}'", minVdeDateEdit.DateTime.Date);
        }



    }
}