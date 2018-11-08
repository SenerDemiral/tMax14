using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class SerbestTeslimFormMasterXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public SerbestTeslimFormMasterXR(int OPMid)
        {
            InitializeComponent();

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprSTFMTableAdapter.Fill(reportDataSet.RPR_STFM, OPMid);

            eMails = reportDataSet.RPR_STFM.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_STFM.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_STFM.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

        }

    }
}
