using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class HblXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public HblXR(int OPHid, bool Antetli)
        {
            InitializeComponent();

            rprImgsTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprFBLTableAdapter.Fill(reportDataSet.RPR_FBL, OPHid);

            eMails = reportDataSet.RPR_FBL.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_FBL.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_FBL.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;

            //xrPictureBox1.Visible = Antetli;
            antetsiz.Value = !Antetli;
            
            ISO.Value = "TM-7.5-13";
            if (Antetli)
                ISO.Value = "TM-7.5-18";
        }

    }
}
