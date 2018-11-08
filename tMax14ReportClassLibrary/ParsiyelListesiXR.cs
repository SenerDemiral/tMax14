using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class ParsiyelListesiXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public ParsiyelListesiXR(int OPMid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprPLTableAdapter.Fill(reportDataSet.RPR_PL, OPMid);
            rprPLdtyTableAdapter.Fill(reportDataSet.RPR_PL_DTY, OPMid);

            eMails = reportDataSet.RPR_PL.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_PL.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_PL.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
