using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class GumrukBilgisiXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public GumrukBilgisiXR(int OPHid)
        {
            InitializeComponent();

            rprGBTableAdapter.Fill(reportDataSet.RPR_GB, OPHid);

            eMails = reportDataSet.RPR_GB.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_GB.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_GB.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
