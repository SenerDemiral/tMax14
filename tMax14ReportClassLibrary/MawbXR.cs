using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class MawbXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public MawbXR(int OPMid, bool Antetli)
        {
            InitializeComponent();

            rprMAWBTableAdapter.Fill(reportDataSet.RPR_MAWB, OPMid);

            eMails = reportDataSet.RPR_MAWB.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_MAWB.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_MAWB.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

            antetli.Value = Antetli;
            ISO.Value = "TM-7.5-12";
            if (Antetli)
                ISO.Value = "TM-7.5-17";
        }

    }
}
