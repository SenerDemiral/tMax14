using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class CargoManifestXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public CargoManifestXR(int OPMid)
        {
            InitializeComponent();

            //OPMid = 159654;   //Test
            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprCMTableAdapter.Fill(reportDataSet.RPR_CM, OPMid);
            rprCMdetayTableAdapter.Fill(reportDataSet.RPR_CM_DETAY, OPMid);

            eMails = reportDataSet.RPR_CM.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_CM.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_CM.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
