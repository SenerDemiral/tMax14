using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class Fatura5XR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public Fatura5XR(int AFBid, string Antet, string Usr)
        {
            InitializeComponent();

            // Force the report creation without requesting the parameter value from end-users.
            this.RequestParameters = false;

            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            ReportDataSet.SMTPRow SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprFaturaTableAdapter.Fill(reportDataSet.RPR_FATURA, AFBid, Usr);
            rprFaturaDtyAllTableAdapter.Fill(reportDataSet.RPR_FATURA_DTY_ALL, AFBid);

            string tur = reportDataSet.RPR_FATURA[0].TUR;
            string drm = reportDataSet.RPR_FATURA[0].DRM;
            string eFtr = reportDataSet.RPR_FATURA[0].EFTR;

            antetli.Value = false;
            if (Antet == "Antetli")
                antetli.Value = true;

            Watermark.Text = "";
            if (drm == "A")
                Watermark.Text = "DRAFT";
            if (eFtr == "T")
                Watermark.Text += " eFatura";
            if (tur == "AA")
                Watermark.Text += " Alış";
            if (tur == "AS")
                Watermark.Text += " Satış İade";
            if (tur == "AV" || tur == "BV" || tur == "AM" || tur == "BM" || tur == "AD" || tur == "BD")     // aVans/Belgesiz,fazlaMesai,Dekont
                Watermark.Text = "";

            eMails = reportDataSet.RPR_FATURA.Rows[0]["EMAILS"].ToString();
            eMailSubject = reportDataSet.RPR_FATURA.Rows[0]["EMAILSUBJECT"].ToString();
            eMailBody = reportDataSet.RPR_FATURA.Rows[0]["EMAILBODY"].ToString();

            if (Antet != "Antetli" && SMTP.FIRMA == "TUNASET")
            {
                TopMargin.HeightF = 50F; // 150F;
                xrRichTextFooter.Visible = false;
                Detail.HeightF = 1000F; // 1200F;

                xrLabelAdr.SizeF = new System.Drawing.SizeF(800F, 300F);
                xrLabelTrh.LocationF = new PointF(1589.93F, 710F);//855, 915
                xrLabelRef.LocationF = new PointF(1351.81F, 775F);//915, 975
            }

        }

    }
}
