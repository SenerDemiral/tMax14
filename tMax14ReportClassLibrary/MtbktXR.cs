using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class MtbktXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public MtbktXR(int frtID, DateTime trh)
        {
            InitializeComponent();

            mtbktTableAdapter.Fill(reportDataSet.RPR_MTBKT, frtID, trh);
            mtbktDtyTableAdapter.Fill(reportDataSet.RPR_MTBKT_DTY, frtID, trh);

            eMails = reportDataSet.RPR_MTBKT.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_MTBKT.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_MTBKT.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
