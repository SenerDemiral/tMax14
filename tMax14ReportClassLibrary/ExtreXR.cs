using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class ExtreXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        
        public ExtreXR(int frtID, DateTime trh1, DateTime trh2)
        {
            InitializeComponent();

            this.rprExtreTableAdapter.Fill(reportDataSet.RPR_EXTRE, frtID, trh1, trh2);
            this.rprExtreDtyTableAdapter.Fill(reportDataSet.RPR_EXTRE_DTY, frtID, trh1, trh2);
            this.rprExtreOztTableAdapter.Fill(reportDataSet.RPR_EXTRE_OZT, frtID, trh1, trh2);
            //dnm = dnm.AddDays(1 - dnm.Day);
            //this.rprExtreTableAdapter.Fill(reportDataSet.RPR_EXTRE, frtID, dnm, dnm.AddMonths(1));
            //this.rprExtreDtyTableAdapter.Fill(reportDataSet.RPR_EXTRE_DTY, frtID, dnm, dnm.AddMonths(1));
            //this.rprExtreOztTableAdapter.Fill(reportDataSet.RPR_EXTRE_OZT, frtID, dnm, dnm.AddMonths(1));

            eMails = reportDataSet.RPR_EXTRE.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_EXTRE.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_EXTRE.Rows[0]["EMAILBODY"].ToString();

            this.ExportOptions.Email.Body = eMailBody;
            this.ExportOptions.Email.Subject = eMailSubject;
            this.ExportOptions.Email.RecipientAddress = eMails;
        }

    }
}
