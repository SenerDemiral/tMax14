using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class AktarmaBilgilendirmeXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public AktarmaBilgilendirmeXR(int OPHid)
        {
            InitializeComponent();

            rprAktbTableAdapter.Fill(reportDataSet.RPR_AKTB, OPHid);

            eMails = reportDataSet.RPR_AKTB.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_AKTB.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_AKTB.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
