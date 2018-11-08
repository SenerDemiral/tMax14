using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class ENSformXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public ENSformXR(int OPMid)
        {
            InitializeComponent();

            rprENSFTableAdapter.Fill(reportDataSet.RPR_ENSF, OPMid);

            //eMails = reportDataSet.RPR_ENSF.Rows[0]["EMAILS"].ToString();
            //eMailSubject = reportDataSet.RPR_ENSF.Rows[0]["EMAILSUBJECT"].ToString();
            //eMailBody = reportDataSet.RPR_ENSF.Rows[0]["EMAILBODY"].ToString();
        }

    }
}
