using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace tMax14ReportClassLibrary
{
    public partial class Fatura2XR : DevExpress.XtraReports.UI.XtraReport
    {
        public string eMails, eMailSubject, eMailBody;
        //ReportDataSet.OWNERRow owner;
            
        
        public Fatura2XR(int AFBid, string Antet, string Usr)
        {
            InitializeComponent();

            ReportDataSetTableAdapters.SMTPTableAdapter smtpTableAdapter = new ReportDataSetTableAdapters.SMTPTableAdapter();
            ReportDataSet.SMTPDataTable SMTPTable = (ReportDataSet.SMTPDataTable)smtpTableAdapter.GetData();
            ReportDataSet.SMTPRow SMTP = (ReportDataSet.SMTPRow)SMTPTable.Rows[0];

            //ReportDataSetTableAdapters.OWNERTableAdapter ownerTableAdapter = new ReportDataSetTableAdapters.OWNERTableAdapter();
            //ReportDataSet.OWNERDataTable ownerTable = (ReportDataSet.OWNERDataTable)ownerTableAdapter.GetData();
            //owner = (ReportDataSet.OWNERRow)ownerTable.Rows[0];

            // Force the report creation without requesting the parameter value from end-users.
            this.RequestParameters = false;

            rprIMGSTableAdapter.Fill(reportDataSet.RPR_IMGS);
            rprFaturaTableAdapter.Fill(reportDataSet.RPR_FATURA, AFBid, Usr);
            rprFaturaDtyTableAdapter.Fill(reportDataSet.RPR_FATURA_DTY, AFBid, "2");

            if (reportDataSet.RPR_FATURA[0].ISAGN == "T")     // Agent
            {
                rprFaturaMasterTableAdapter.Fill(reportDataSet.RPR_FATURA_MASTER, AFBid);
                //rprFaturaMasterCntnrsTableAdapter.Fill(reportDataSet.RPR_FATURA_MASTER_CNTNRS, AFBid);
                rprFaturaMasterHousesTableAdapter.Fill(reportDataSet.RPR_FATURA_MASTER_HOUSES, AFBid);
            }
            else
            {
                int nor = rprFaturaHouseTableAdapter.Fill(reportDataSet.RPR_FATURA_HOUSE, AFBid);
                if (nor > 0)
                    DetailReportMaster.Visible = false;
                else
                {
                    rprFaturaMasterTableAdapter.Fill(reportDataSet.RPR_FATURA_MASTER, AFBid);
                    DetailReportHouse.Visible = false;
                }
            }

            if (!reportDataSet.RPR_FATURA[0].IsOPIDNull())
                opInfoTableAdapter.Fill(reportDataSet.OP_INFO, reportDataSet.RPR_FATURA[0].OPID, reportDataSet.RPR_FATURA[0].OPHM);

            string drm = reportDataSet.RPR_FATURA[0].DRM;
            string eFtr = reportDataSet.RPR_FATURA[0].EFTR;

            antetli.Value = false;
            if (Antet == "Antetli")
                antetli.Value = true;

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
                //xrLabelTrh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                //xrLabelTrh2.Visible = true;
                xrLabelRef.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                xrLabelTrh.LocationF = new PointF(1380F, 475F); //PointF(1589.93F, 710F);//855,915,     1589
                xrLabelRef.LocationF = new PointF(1580F, 475F); //PointF(1589.93F, 775F);//915,975
                //xrLabelTrh2.LocationF = new PointF(1380F, 580F); //PointF(1589.93F, 710F);//855,915,     1589


                /*
                TopMargin.HeightF = 50F; // 150F;
                PageFooter.Visible = false;
                Detail.HeightF = 1000F; // 1200F;

                xrLabelAdr.SizeF = new System.Drawing.SizeF(800F, 300F);
                xrLabelTrh.LocationF = new PointF(1589.93F, 710F);//915
                xrLabelRef.LocationF = new PointF(1351.81F, 775F);//975
                */
            }

        }

    }
}
