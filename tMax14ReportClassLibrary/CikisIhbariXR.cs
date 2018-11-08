using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class CikisIhbariXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public CikisIhbariXR(int OPHid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprCITableAdapter.Fill(reportDataSet.RPR_CI, OPHid);

/*
            xrLabelHROSlabel.Visible = false;
            xrLabelHROSdata.Visible = false;
            if (reportDataSet.RPR_CI.Rows[0]["ROT"].ToString() == "I" &&
                reportDataSet.RPR_CI.Rows[0]["MOT"].ToString() == "R")
            {
                xrLabelHROSlabel.Visible = true;
                xrLabelHROSdata.Visible = true;
            }
*/
            eMails = reportDataSet.RPR_CI.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_CI.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_CI.Rows[0]["EMAILBODY"].ToString();
             
            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
