using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class IcNakliyeTalimatiXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public IcNakliyeTalimatiXR(int OPHid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprIntTableAdapter.Fill(reportDataSet.RPR_INT, OPHid);

            eMails = reportDataSet.RPR_INT.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_INT.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_INT.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
