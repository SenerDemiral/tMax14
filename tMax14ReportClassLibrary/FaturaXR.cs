using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class FaturaXR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;

        public FaturaXR(int AFBid, string Antet, string Usr, bool AllIn = false)
        {
            InitializeComponent();

            // Force the report creation without requesting the parameter value from end-users.
            this.RequestParameters = false;

            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            ReportDataSet.SMTPRow SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprFaturaTableAdapter.Fill(reportDataSet.RPR_FATURA, AFBid, Usr);
            //rprFaturaOpsTableAdapter.Fill(reportDataSet.RPR_FATURA_OPS, AFBid);
            rprFaturaDtyTableAdapter.Fill(reportDataSet.RPR_FATURA_DTY, AFBid, "1");

            int nor = rprFaturaHouseTableAdapter.Fill(reportDataSet.RPR_FATURA_HOUSE, AFBid);
            if (nor > 0)
                DetailReportMaster.Visible = false;
            else
            {
                rprFaturaMasterTableAdapter.Fill(reportDataSet.RPR_FATURA_MASTER, AFBid);
                DetailReportHouse.Visible = false;
            }

            if (!reportDataSet.RPR_FATURA[0].IsOPIDNull())
                opInfoTableAdapter.Fill(reportDataSet.OP_INFO, reportDataSet.RPR_FATURA[0].OPID, reportDataSet.RPR_FATURA[0].OPHM);

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
                PaperKind = System.Drawing.Printing.PaperKind.A4;
                TopMargin.HeightF = 250F; // 50F; // 150F;
                BottomMargin.HeightF = 200F; // 50F; // 150F;
                PageFooter.Visible = false;
                Detail.HeightF = 1000F; // 1200F;

                xrLabelAdr.SizeF = new System.Drawing.SizeF(800F, 300F);

                xrLabelTrh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                xrLabelTrh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                xrLabelTrh2.Visible = true;
                xrLabelRef.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                xrLabelTrh.LocationF = new PointF(1380F, 475F); //PointF(1589.93F, 710F);//855,915,     1589
                xrLabelRef.LocationF = new PointF(1580F, 475F); //PointF(1589.93F, 775F);//915,975
                xrLabelTrh2.LocationF = new PointF(1380F, 580F); //PointF(1589.93F, 710F);//855,915,     1589
            }

            xrLabel53.Visible = !AllIn;
            xrLabel55.Visible = !AllIn;
            xrLine1.Visible = !AllIn;
            Detail1.Visible = !AllIn;

            xrLabelAll_In.Visible = AllIn;

        }

    }
}
