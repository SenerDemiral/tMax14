using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Collections;
using DevExpress.XtraPrinting;
using DevExpress.XtraPivotGrid;

namespace tMax14.AccountRpr
{
    public partial class AccOdmPerformansXF : DevExpress.XtraEditors.XtraForm
    {
        public AccOdmPerformansXF()
        {
            InitializeComponent();
        }


        private void AccOdmPerformansXF_Load(object sender, EventArgs e)
        {
            dateEdit2.DateTime = DateTime.Today;
            dateEdit1.DateTime = DateTime.Today.AddDays(-90);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.accOdmPerformansTableAdapter.Fill(this.accountRprDataSet.ACC_ODM_PERFORMANS, dateEdit1.DateTime, dateEdit2.DateTime);
        }

        private void pivotGridControl1_CustomSummary(object sender, DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs e)
        {
            if (e.ColumnField == null)
                e.CustomValue = e.SummaryValue.Summary;
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                decimal tut, tutOdm, tutVde;
                if (e.IsGroupSummary)
                {
                    GridGroupSummaryItem itm = (GridGroupSummaryItem)e.Item;
                    tut = Convert.ToDecimal(gridView1.GetRowSummaryItem(e.GroupRowHandle, colTOPTUT).Value);
                    tutOdm = Convert.ToDecimal(gridView1.GetRowSummaryItem(e.GroupRowHandle, colTOPTUTXODMGUN).Value);
                    tutVde = Convert.ToDecimal(gridView1.GetRowSummaryItem(e.GroupRowHandle, colTOPTUTXVDEGUN).Value);

                    if (itm.FieldName == "ORTVDEGUN")
                        e.TotalValue = Math.Round(tutVde / tut, 0);
                    else if (itm.FieldName == "ORTODMGUN")
                        e.TotalValue = Math.Round(tutOdm / tut, 0);

                }
                else if (e.IsTotalSummary)
                {
                    GridColumnSummaryItem itm = (GridColumnSummaryItem)e.Item;
                    tut = Convert.ToDecimal(colTOPTUT.SummaryItem.SummaryValue);
                    tutOdm = Convert.ToDecimal(colTOPTUTXODMGUN.SummaryItem.SummaryValue);
                    tutVde = Convert.ToDecimal(colTOPTUTXVDEGUN.SummaryItem.SummaryValue);
                    if (tut != 0)
                    {
                        if (itm.FieldName == "ORTVDEGUN")
                            e.TotalValue = Math.Round(tutVde / tut, 0);
                        else if (itm.FieldName == "ORTODMGUN")
                            e.TotalValue = Math.Round(tutOdm / tut, 0);
                    }                        
                }
            }
        }

        private void gridView1_CustomDrawRowFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            /*
            if (e.Column == colORTODMGUN)
            {
                //GridGroupSummaryItem
                //DictionaryEntry ent = currentView.GetRowSummaryItem(e.RowHandle, gridView1_CustomDrawRowFooterCell.FocusedColumn);
                //DictionaryEntry ent = gridView1.GetGroupSummaryValues(e.RowHandle);
                //GridGroupSummaryItem ccc = gridView1.GetGroupSummaryValues(e.RowHandle);
                //var ddd = ccc["ShowInGroupColumnFooter = TOPTUT, FieldName = 'TOPTUT', DisplayFormat = '{0:0.##}', SummaryType = Sum"];
                decimal aTopTut = Convert.ToDecimal(colTOPTUT.SummaryItem.SummaryValue);
                decimal aTopTutOdmGun = Convert.ToDecimal(colTOPTUTXODMGUN.SummaryItem.SummaryValue);
                Text = $"{aTopTut}   {aTopTutOdmGun}";

                decimal tut = Convert.ToDecimal(gridView1.GetRowSummaryItem(e.RowHandle, colTOPTUT).Value);
                var tutOdm = Convert.ToDecimal(gridView1.GetRowSummaryItem(e.RowHandle, colTOPTUTXODMGUN).Value);
                decimal ortOdmGun = Math.Round(tutOdm / tut, 0);
                e.Info.DisplayText = $"{ortOdmGun}";
                //e.Info.Value = ortOdmGun;
            }
            else if (e.Column == colORTVDEGUN)
            {
                decimal tut = Convert.ToDecimal(gridView1.GetRowSummaryItem(e.RowHandle, colTOPTUT).Value);
                var tutVde = Convert.ToDecimal(gridView1.GetRowSummaryItem(e.RowHandle, colTOPTUTXVDEGUN).Value);
                decimal ortVdeGun = Math.Round(tutVde / tut, 0);
                e.Info.DisplayText = $"{ortVdeGun}";
                //e.Info.Value = ortVdeGun;
            }
            */
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridControl1;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = $"Ödeme Performans {dateEdit1.DateTime:dd.MM.yy} - {dateEdit2.DateTime:dd.MM.yy}";
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

        }

    }
}