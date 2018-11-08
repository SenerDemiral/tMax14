using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class VarisIhbarXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public VarisIhbarXR(int OPHid, int ihbarNo)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            if (ihbarNo > 1)
                xrLabel1.Text += "  " + ihbarNo.ToString();
            rprVITableAdapter.Fill(reportDataSet.RPR_VI, OPHid);
            rprVIdtyTableAdapter.Fill(reportDataSet.RPR_VI_DTY, OPHid);

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
            eMails = reportDataSet.RPR_VI.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_VI.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_VI.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
