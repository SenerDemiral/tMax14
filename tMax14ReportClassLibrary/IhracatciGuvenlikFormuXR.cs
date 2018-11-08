using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class IhracatciGuvenlikFormuXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public IhracatciGuvenlikFormuXR(int OPHid)
        {
            InitializeComponent();

            rprIGFTableAdapter.Fill(reportDataSet.RPR_IGF, OPHid);

            eMails = reportDataSet.RPR_IGF.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_IGF.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_IGF.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
