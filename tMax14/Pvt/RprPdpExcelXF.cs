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
    public partial class RprPdpExcelXF : DevExpress.XtraEditors.XtraForm
    {
        public int mID = 0;
        IWorkbook workbook;
        Worksheet sheet;
        
        public RprPdpExcelXF()
        {
            InitializeComponent();
        }

        private void RprPdpExcelXF_Load(object sender, EventArgs e)
        {
            this.rPR_PDPTableAdapter.Fill(this.pvtDataSet.RPR_PDP, mID);
            getTemplate();
        }

        private void getTemplate()
        {
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(@"\\192.168.1.245\tMax14\PDP-CollectionManifestTemplate.xlsm", DocumentFormat.Xlsm);
            //workbook.LoadDocument(@"C:\TunaBio\PDP-CollectionManifestTemplate.xlsm", DocumentFormat.Xlsm);
            sheet = workbook.Worksheets[0];

            sheet.Cells["N1"].Value = pvtDataSet.RPR_PDP.Rows[0]["MORG"].ToString();
            sheet.Cells["M2"].Value = string.Format("{0:dd.MM.yyyy}", pvtDataSet.RPR_PDP.Rows[0]["MWBD"]);

            int rof = 4;
            foreach (PvtDataSet.RPR_PDPRow row in this.pvtDataSet.RPR_PDP.Rows)
            {
                sheet.Cells[rof, 1].Value = row["REFNO"].ToString();
                sheet.Cells[rof, 2].Value = row["CNE"].ToString();
                sheet.Cells[rof, 3].Value = row["B_PRTNO"].ToString();
                sheet.Cells[rof, 4].Value = row["B_SITENO"].ToString();

                sheet.Cells[rof, 5].Value = row["B_NOTA"].ToString();
                sheet.Cells[rof, 6].Value = row["B_NOTF"].ToString();
                sheet.Cells[rof, 7].Value = row["B_NOTR"].ToString();

                sheet.Cells[rof, 8].Value = row["B_NOA"].ToString();
                sheet.Cells[rof, 9].Value = row["B_NOF"].ToString();
                sheet.Cells[rof, 11].Value = row["B_NOR"].ToString();

                sheet.Cells[rof, 14].Value = row["B_SNDINFO"].ToString();
                sheet.Cells[rof, 15].Value = string.Format("{0:dd.MM.yyyy}", row["BRD"]);
                sheet.Cells[rof, 16].Value = string.Format("{0:HH:mm}", row["BRD"]);
                sheet.Cells[rof, 17].Value = string.Format("{0:dd.MM.yyyy}", row["AOH"]);
                sheet.Cells[rof, 18].Value = string.Format("{0:HH:mm}", row["AOH"]);

                sheet.Cells[rof, 19].Value = row["B_DIKG"].ToString();
                sheet.Cells[rof, 20].Value = row["GRW"].ToString();
                sheet.Cells[rof, 21].Value = row["B_KUTUGONDER"].ToString();
                
                rof++;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainDataSet.SMTPRow SMTP = Program.MF.SMTP();
            string eMails = barEditItem1.EditValue.ToString();
            string eMailSubject = "Tunaset PDP Collection Manifest";
            //string eMailBody = pvtDataSet.RPR_PG_EMAILS[0].EMAILBODY;

            using (MemoryStream memStream = new MemoryStream())
            {
                workbook.SaveDocument(memStream, DocumentFormat.Xlsm);
                //dGridView.ExportToXls(memStream);

                // Create a new attachment and put the Excel report into it.
                memStream.Seek(0, System.IO.SeekOrigin.Begin);
                System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(memStream, "Tunaset_PDP_CollectionManifest.xlsm", "application/xlsm");

                MailMessage mail = new MailMessage();
                mail.Attachments.Add(att);

                mail.To.Add(eMails);
                mail.Subject = eMailSubject;
                //mail.Body = eMailBody;
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