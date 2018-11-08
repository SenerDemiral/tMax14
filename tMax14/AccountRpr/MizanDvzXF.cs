using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace tMax14.AccountRpr
{
    public partial class MizanDvzXF : DevExpress.XtraEditors.XtraForm
    {
        public MizanDvzXF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.mznDvzTableAdapter.Fill(this.accountRprDataSet.ACC_MIZAN_DVZ, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue, SklAslCheckEdit.EditValue.ToString());
                pivotGridControl1.BestFit();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mznDvzGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                //if (e.IsGroupSummary && e.GroupLevel != colBDVZ.GroupIndex && fn == "BTUTBRT")
                if (colDVZ.GroupIndex == -1 && (fn == "DBRC" || fn == "DALC" || fn == "DBRCBKY" || fn == "DALCBKY"))
                    e.Exists = false;
                else if (e.GroupLevel < colDVZ.GroupIndex && (fn == "DBRC" || fn == "DALC" || fn == "DBRCBKY" || fn == "DALCBKY"))
                    e.Exists = false;
            }

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = mznDvzGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("MİZAN Dövizli {0:dd.MM.yy} - {1:dd.MM.yy}", dateEdit1.EditValue, dateEdit2.EditValue);
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void pivotGridControl1_FieldAreaChanged(object sender, DevExpress.XtraPivotGrid.PivotFieldEventArgs e)
        {
            if (e.Field.FieldName == "DVZ")
            {
                if (e.Field.Area == DevExpress.XtraPivotGrid.PivotArea.FilterArea)
                {
                    fieldDBRC.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                    fieldDALC.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
                    fieldDBKY.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;

                    fieldABRC.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
                    fieldAALC.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
                    fieldABKY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
                }
            }
            pivotGridControl1.BestFit();
            /*
            if (fieldDBRC.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea ||
                fieldDALC.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea ||
                fieldDBKY.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea)
            {
                pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            }
            else
                pivotGridControl1.OptionsView.ShowColumnGrandTotals = true;
            */
        }

        private void pivotGridControl1_CustomCellValue(object sender, DevExpress.XtraPivotGrid.PivotCellValueEventArgs e)
        {
            //if (e.RowValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal)
            //    e.Value = 0;
            if (e.ColumnValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal && 
                (e.DataField.FieldName == "DBRC" || e.DataField.FieldName == "DALC" || e.DataField.FieldName == "DBKY"))
                e.Value = "!";
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = pivotGridControl1;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("MİZAN Dövizli {0:dd.MM.yy} - {1:dd.MM.yy}", dateEdit1.EditValue, dateEdit2.DateTime.AddDays(-1));
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