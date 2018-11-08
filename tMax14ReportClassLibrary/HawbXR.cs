using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class HawbXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public HawbXR(int OPHid, bool Antetli)
        {
            InitializeComponent();

            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            ReportDataSet.SMTPRow SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];

            rprHAWBTableAdapter.Fill(reportDataSet.RPR_HAWB, OPHid);

            eMails = reportDataSet.RPR_HAWB.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_HAWB.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_HAWB.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

            antetli.Value = Antetli;
            ISO.Value = "TM-7.5-11";
            if (Antetli)
                ISO.Value = "TM-7.5-16";

            if (SMTP.FIRMA == "TUNASET")
            {
                xrPictureBox2.Visible = false;
                xrPictureBox3.Visible = false;
                xrLabel51.Text = "Istanbul Ticaret Sarayı, Oruç Reis Mah. Vadi Cad. No:108 Kat:1 No:68 Giyimkent-Esenler/Istanbul/Türkiye Tel: +90(212)438 6300 Fax: +90(212)438 2617 eMail: operations@biotunaset.com  Web: biotunaset.com";
            }
        }

    }
}
