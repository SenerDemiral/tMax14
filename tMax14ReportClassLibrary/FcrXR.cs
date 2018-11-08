using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class FcrXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public FcrXR(int OPHid, bool Antetli)
        {
            InitializeComponent();

            rprFCRTableAdapter.Fill(reportDataSet.RPR_FCR, OPHid);

            eMails = reportDataSet.RPR_FCR.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_FCR.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_FCR.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

            antetli.Value = Antetli;
            ISO.Value = "TM-7.5-14";
            if (Antetli)
                ISO.Value = "TM-7.5-19";
        }

    }
}
