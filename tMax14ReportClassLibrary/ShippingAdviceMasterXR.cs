using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class ShippingAdviceMasterXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public ShippingAdviceMasterXR(int OPMid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprSAMTableAdapter.Fill(reportDataSet.RPR_SAM, OPMid);

            eMails = reportDataSet.RPR_SAM.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_SAM.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_SAM.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
