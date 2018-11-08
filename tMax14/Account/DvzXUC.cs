using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace tMax14.Account
{
    public partial class DvzXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public DvzXUC()
        {
            InitializeComponent();

            trhDateEdit.DateTime = DateTime.Today;
        }

        private void trhDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.dVZ_SELTableAdapter.FillByTrh(this.accountDataSet.DVZ_SEL, trhDateEdit.DateTime, (DateTime?)trh2DateEdit.EditValue);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = dvzGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Döviz Kurları");
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
