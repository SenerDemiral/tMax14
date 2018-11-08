using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Spreadsheet;
using System.IO;
using System.Net.Mail;

namespace tMax14.Pvt
{
    public partial class RprEcsExcelXF : DevExpress.XtraEditors.XtraForm
    {
        IWorkbook workbook;
        Worksheet sheet;
        string[] cNF = new string[50];

        public RprEcsExcelXF()
        {
            InitializeComponent();
        }

        private void RprEcsExcelXF_Load(object sender, EventArgs e)
        {
            rPR_ECSTableAdapter.Fill(this.pvtDataSet.RPR_ECS);
            rpR_ECS_EMAILSTableAdapter.Fill(pvtDataSet.RPR_ECS_EMAILS);
            eMailBarEditItem.EditValue = this.pvtDataSet.RPR_ECS_EMAILS[0].EMAILS;

            getTemplate();
        }

        private void getTemplate()
        {
            workbook = spreadsheetControl1.Document;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\ECS-OverviewReportTemplate.xlsx"))
                workbook.LoadDocument(AppDomain.CurrentDomain.BaseDirectory + "\\ECS-OverviewReportTemplate.xlsx");
            else
                workbook.LoadDocument(@"\\192.168.1.245\tMax14\ECS-OverviewReportTemplate.xlsx", DocumentFormat.Xlsx);
            //workbook.LoadDocument(@"C:\Transorient\ECS-OverviewReportTemplate.xlsx", DocumentFormat.Xlsx);

            sheet = workbook.Worksheets[0];

            for (int i = 0; i < 50; i++)
            {
                cNF[i] = sheet.Columns[i].NumberFormat;
            }

            Range rTrh = sheet.Range["C1"];
            sheet.Cells["C1"].Value = string.Format("{0} {1:dd.MM.yy}", sheet.Cells["C1"].Value, DateTime.Today);

            sheet.Import(pvtDataSet.RPR_ECS, false, 2, 0);

            for (int i = 0; i < 50; i++)
            {
                sheet.Columns[i].NumberFormat = cNF[i];
            }

        }

        private void SendMailBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();
            string eMails = eMailBarEditItem.EditValue.ToString();
            string eMailSubject = pvtDataSet.RPR_ECS_EMAILS[0].EMAILSUBJECT;
            string eMailBody = pvtDataSet.RPR_ECS_EMAILS[0].EMAILBODY;

            using (MemoryStream memStream = new MemoryStream())
            {
                workbook.SaveDocument(memStream, DocumentFormat.Xlsx);

                // Create a new attachment and put the Excel report into it.
                memStream.Seek(0, System.IO.SeekOrigin.Begin);
                System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(memStream, "Transorient_ECS_Overview.xlsx", "application/xlsx");

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

                MessageBox.Show("Mail gönderildi");
            }

        }

    }
}