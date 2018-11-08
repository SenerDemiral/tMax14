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

    public partial class AccAfbKlnDtyXF : DevExpress.XtraEditors.XtraForm
    {
        public int frtID;

        public AccAfbKlnDtyXF()
        {
            InitializeComponent();

            DateTime today = DateTime.Today;
            dateEdit1.EditValue = new DateTime(today.Year, today.Month, 1);
            today = today.AddMonths(1);
            dateEdit2.EditValue = new DateTime(today.Year, today.Month, 1);
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.aCC_AFBKLN_HDQ_DTYTableAdapter.Fill(this.accountRprDataSet.ACC_AFBKLN_HDQ_DTY, frtID, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue, hdqTFcheckEdit.EditValue.ToString());
                this.aCC_AFBKLN_HDQ_OZT_YTYTableAdapter.Fill(this.accountRprDataSet.ACC_AFBKLN_HDQ_OZT_YTY, frtID, (DateTime?)dateEdit1.EditValue, (DateTime?)dateEdit2.EditValue, hdqTFcheckEdit.EditValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DateTime today = dateEdit1.DateTime.AddMonths(1);
            dateEdit2.EditValue = new DateTime(today.Year, today.Month, 1);
        }

        private void dtyGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDVZ.GroupIndex == -1 || e.GroupLevel < colDVZ.GroupIndex) && (fn == "BRCKLN" || fn == "ALCKLN"))
                {
                    e.Exists = false;
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = dtyGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Müşteri Faturaları");
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