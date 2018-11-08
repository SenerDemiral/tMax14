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

namespace tMax14ReportClassLibrary
{
    public partial class TopluFaturaXF : DevExpress.XtraEditors.XtraForm
    {
        public string afbIDs = "";
        public string USR;
        public string USReMail;
        private List<Attachment> attachments = new List<Attachment>();
        private ReportDataSet.RPT_GETRow rptRow;
        private bool hata = false;

        private ReportDataSet.SMTPRow SMTP;
        
        public TopluFaturaXF()
        {
            InitializeComponent();
        }

        private void TopluFaturaXF_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(afbIDs))
                this.rprTopluFaturaTableAdapter.Fill(this.reportDataSet.RPR_TOPLUFATURA, afbIDs);

            this.rptGetTableAdapter.Fill(this.reportDataSet.RPT_GET, 4);
            rptRow = this.reportDataSet.RPT_GET[0];
            
            eMailSubjectTextEdit.Text = rptRow.EMAILSUBJECT;
            eMailBodyRichEditControl.Document.HtmlText = rptRow.EMAILBODY;

            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];
        }

        private void sendSimpleButton_Click(object sender, EventArgs e)
        {
            sendSimpleButton.Enabled = false;

            //this.rptGetTableAdapter.Fill(this.reportDataSet.RPT_GET, 4);
            //rptRow = this.reportDataSet.RPT_GET[0];

            foreach (ReportDataSet.RPR_TOPLUFATURARow rtfRow in this.reportDataSet.RPR_TOPLUFATURA.Rows)
            {
                if (!rtfRow.IsEMAILSNull() && !string.IsNullOrEmpty(rtfRow.EMAILS))
                {
                    send2Firma(rtfRow.FRTID, rtfRow.FRTAFBIDS, rtfRow.EMAILS);
                }
            }
        }

        private void send2Firma(int frtID, string frtAfbIDs, string eMail)
        {
            attachments.Clear();
            string[] afbIDs = frtAfbIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id;
            foreach (string afbID in afbIDs)
            {
                id = Convert.ToInt32(afbID);
                attFatura(id);
                attDocuments("AFB", id, "INV", false);
            }

            if (!string.IsNullOrEmpty(USReMail))
                eMail += ", " + USReMail;  // Aktif usera da mail gonder Control
           
            //sendMail(eMail, rptRow.EMAILSUBJECT, rptRow.EMAILBODY);
            sendMail(eMail, eMailSubjectTextEdit.Text, eMailBodyRichEditControl.Document.HtmlText);

            if (!hata)
            {
                foreach (string afbID in afbIDs)
                {
                    id = Convert.ToInt32(afbID);
                    reportQueriesTableAdapter.AFB_SET_EMLD(id, "T", USR);   // Set eMailed
                    reportQueriesTableAdapter.RPH_INS(rptRow.KOD, "AFB", id, USR, "F", null);
                }
            }
        }

        private void attFatura(int afbID)
        {
            //string fn = string.Format("InvoiceRef{0}.pdf", afbID);
            string fn = "Invoice.pdf";

            MemoryStream ms = new MemoryStream();

            if (ftrSklImageComboBoxEdit.EditValue.ToString() == "1")
            {
                FaturaXR rpr = new FaturaXR(afbID, "Antetli", USR);
                rpr.ExportToPdf(ms);
            }
            else if (ftrSklImageComboBoxEdit.EditValue.ToString() == "2")
            {
                Fatura2XR rpr = new Fatura2XR(afbID, "Antetli", USR);
                rpr.ExportToPdf(ms);
            }
            else if (ftrSklImageComboBoxEdit.EditValue.ToString() == "3")
            {
                Fatura3XR rpr = new Fatura3XR(afbID, "Antetli", USR);
                rpr.ExportToPdf(ms);
            }
            else if (ftrSklImageComboBoxEdit.EditValue.ToString() == "4")
            {
                Fatura5XR rpr = new Fatura5XR(afbID, "Antetli", USR);
                rpr.ExportToPdf(ms);
            }
            else if (ftrSklImageComboBoxEdit.EditValue.ToString() == "5")
            {
                Fatura32XR rpr = new Fatura32XR(afbID, "Antetli", USR);
                rpr.ExportToPdf(ms);
            }

            ms.Seek(0, System.IO.SeekOrigin.Begin);

            attachments.Add(new Attachment(ms, fn));

        }

        private void attDocuments(string refTbl, int refID, string disEvrkTur, bool zorunlu)
        {
            this.docSelDetTableAdapter.Fill(this.reportDataSet.DOC_SEL_DET, refTbl, refID, disEvrkTur);
            int rowCount = this.reportDataSet.DOC_SEL_DET.Rows.Count;

            if (rowCount > 0)
            {
                foreach (ReportDataSet.DOC_SEL_DETRow row in this.reportDataSet.DOC_SEL_DET.Rows)
                {
                    byte[] byteArray = row.BLB; //(byte[])this.reportDataSet.DOC_SEL_DET.Rows[0]["BLB"];
                    MemoryStream ms = new MemoryStream(byteArray);
                    ms.Seek(0, System.IO.SeekOrigin.Begin);
                    if (ms.Length > 0)
                    {
                        string attName = string.Format("{0}{1}{2}-{3}{4}", disEvrkTur, refTbl, refID, row.DOCID, row.TYP);
                        attachments.Add(new Attachment(ms, attName));
                    }
                }
            }
        }

        private void sendMail(string mailTo, string subject, string body)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                MailMessage mail = new MailMessage();

                for (int i = 0; i < attachments.Count; i++)
                    mail.Attachments.Add(attachments[i]);

                mail.To.Add(mailTo);

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

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
            Cursor = Cursors.Default;
        }

    }
}