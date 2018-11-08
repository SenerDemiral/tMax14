using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class ProofOfDeliveryXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public ProofOfDeliveryXR(int OPHid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprPODTableAdapter.Fill(reportDataSet.RPR_POD, OPHid);

            eMails = reportDataSet.RPR_POD.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_POD.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_POD.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

        private void ProofOfDeliveryXR_AfterPrint(object sender, EventArgs e)
        {

        }

    }
}
