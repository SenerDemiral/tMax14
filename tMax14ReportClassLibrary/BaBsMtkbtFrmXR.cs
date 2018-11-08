using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class BaBsMtkbtFrmXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public BaBsMtkbtFrmXR(int frtID, DateTime trh1, DateTime trh2)
        {
            InitializeComponent();

            rprBaBsMFTableAdapter.Fill(reportDataSet.RPR_BABSMF, frtID, trh1, trh2);

            eMails = reportDataSet.RPR_BABSMF.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_BABSMF.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_BABSMF.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
