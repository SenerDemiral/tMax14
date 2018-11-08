using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class EcsRateRequestXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public EcsRateRequestXR(int tstID, string Usr)
        {
            InitializeComponent();

            rprEcsRRTableAdapter.Fill(reportDataSet.RPR_ECS_RR, tstID, Usr);

            eMails = reportDataSet.RPR_ECS_RR.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_ECS_RR.Rows[0]["EMAILSUBJECT"].ToString(); // Kullanilmiyor
            eMailBody = reportDataSet.RPR_ECS_RR.Rows[0]["EMAILBODY"].ToString();

        }

    }
}
