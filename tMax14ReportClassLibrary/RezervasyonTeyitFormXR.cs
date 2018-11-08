using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class RezervasyonTeyitFormXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public RezervasyonTeyitFormXR(int OPHid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprRTFTableAdapter.Fill(reportDataSet.RPR_RTF, OPHid);

            eMails = reportDataSet.RPR_RTF.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_RTF.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_RTF.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
