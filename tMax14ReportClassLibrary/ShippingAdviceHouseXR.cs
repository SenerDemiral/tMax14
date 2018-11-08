using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class ShippingAdviceHouseXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public ShippingAdviceHouseXR(int OPHid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprSAHTableAdapter.Fill(reportDataSet.RPR_SAH, OPHid);

            eMails = reportDataSet.RPR_SAH.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_SAH.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_SAH.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
