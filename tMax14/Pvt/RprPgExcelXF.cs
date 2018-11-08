using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Spreadsheet;
using System.IO;
using System.Net.Mail;

namespace tMax14.Pvt
{
    public partial class RprPgExcelXF : DevExpress.XtraEditors.XtraForm
    {
        int nor = 0;
        enum cols { AOH, ORG, CNTNO, ORDNO, STU, ROS, mORG, mATD, mDST, mETA, mRETA, mATA, CABW, DRBD, RTR, ROH, mRTD, POD };
        string[] cNF = new string[50];

        IWorkbook workbook;
        Worksheet sheet;

        public RprPgExcelXF()
        {
            InitializeComponent();
        }

        private void getTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void OphPgExcelXF_Load(object sender, EventArgs e)
        {
            int nore = this.rPR_PG_EMAILSTableAdapter.Fill(this.pvtDataSet.RPR_PG_EMAILS);
            barEditItem1.EditValue = this.pvtDataSet.RPR_PG_EMAILS[0].EMAILS;

            nor = this.rPR_PGTableAdapter.Fill(this.pvtDataSet.RPR_PG) + 2; // Baslik iki satir
            getTemplate();
        }

        private void getTemplate()
        {
            workbook = spreadsheetControl1.Document;
            // Load the template document into the SpreadsheetControl.
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\P&G-OverviewReportTemplate.xlsx"))
                workbook.LoadDocument(AppDomain.CurrentDomain.BaseDirectory + "\\P&G-OverviewReportTemplate.xlsx");
            else
                workbook.LoadDocument(@"\\192.168.1.245\tMax14\P&G-OverviewReportTemplate.xlsx");
            //workbook.LoadDocument(@"C:\TransOrient\P&G-OverviewReportTemplate.xlsx", DocumentFormat.OpenXml);
            //workbook.LoadDocument(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PGtemplate.xlsx", DocumentFormat.OpenXml);
            //spreadsheetControl1.LoadDocument(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PGtemplate.xlsx", DocumentFormat.OpenXml);
            sheet = workbook.Worksheets[0];

            for (int i = 0; i < 19; i++)
            {
                //cNF[i] = sheet.Columns[((char)(i + 65)).ToString()].NumberFormat;
                cNF[i] = sheet.Columns[i].NumberFormat;
            }
            Range rTrh = sheet.Range["C1"];
            sheet.Cells["C1"].Value = string.Format("{0} {1:dd.MM.yy}", sheet.Cells["C1"].Value, DateTime.Today);
            
            sheet.Import(pvtDataSet.RPR_PG, false, 2, 0);

            for (int i = 0; i < 19; i++)
            {
                //sheet.Columns[((char)(i + 65)).ToString()].NumberFormat = cNF[i];
                sheet.Columns[i].NumberFormat = cNF[i];
            }

            /*
            sheet.Columns["A"].NumberFormat = Anf;
            */
            // A range that includes the entire column A.
            //Range rangeColumnA = sheet.Range["A:A"];
            //Range rangeColumnB = sheet.Range["B3:B99"];
            /*
            string trhF = "dd.MM.yy";
            string trhSatF = "dd.MM.yy HH:mm";
            //rangeAOH.NumberFormat = trhF;
            rangeROS.NumberFormat  = trhF;
            rangeMATD.NumberFormat = trhF;
            rangeMETA.NumberFormat = trhF;
            rangeMATA.NumberFormat = trhF;
            rangeDRBD.NumberFormat = trhF;

            rangeRTR.NumberFormat = trhSatF;
            rangeROH.NumberFormat = trhSatF;
            rangeMRTD.NumberFormat = trhSatF;
            rangePOD.NumberFormat = trhSatF;
            */
        }

        private void spreadsheetControl1_DocumentLoaded(object sender, EventArgs e)
        {
            //getTemplate();
        }

        private void eMailbarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //workbook.SaveDocument(
            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();
            string eMails = barEditItem1.EditValue.ToString();
            string eMailSubject = pvtDataSet.RPR_PG_EMAILS[0].EMAILSUBJECT;
            string eMailBody = pvtDataSet.RPR_PG_EMAILS[0].EMAILBODY;

            using (MemoryStream memStream = new MemoryStream())
            {
                workbook.SaveDocument(memStream, DocumentFormat.Xlsx);
                //dGridView.ExportToXls(memStream);

                // Create a new attachment and put the Excel report into it.
                memStream.Seek(0, System.IO.SeekOrigin.Begin);
                System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(memStream, "Transorient_P&G_Overview.xlsx", "application/xlsx");

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