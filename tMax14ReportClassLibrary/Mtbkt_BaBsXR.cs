using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class Mtbkt_BaBsXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public Mtbkt_BaBsXR(int frtID, DateTime trh)
        {
            InitializeComponent();

            // Mtbkt <= Trh
            // BaBs >=Trh1 <Trh2
            DateTime trh1;
            DateTime trh2;

            trh1 = trh.AddDays(1.0 - trh.Day);  // Trh'in 1.gunu
            trh2 = trh1.AddMonths(1);  // Bir sonraki ayin ilk gunu

            MtbktBaBsTableAdapter.Fill(reportDataSet.RPR_MTBKT_BABS, frtID, trh);
            MtbktDtyTableAdapter.Fill(reportDataSet.RPR_MTBKT_DTY, frtID, trh);
            BaBsMFTableAdapter.Fill(reportDataSet.RPR_BABSMF, frtID, trh1, trh2);

            eMails = reportDataSet.RPR_MTBKT_BABS.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_MTBKT_BABS.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_MTBKT_BABS.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
