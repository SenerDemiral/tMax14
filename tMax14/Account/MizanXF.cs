using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace tMax14.Account
{
    public partial class MizanXF : DevExpress.XtraEditors.XtraForm
    {
        public MizanXF()
        {
            InitializeComponent();

            dateEdit1.DateTime = new DateTime(DateTime.Today.Year, 1, 1, 0, 0, 0);
            dateEdit2.DateTime = new DateTime(DateTime.Today.Year+1, 1, 1, 0, 0, 0);
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.accMizanTableAdapter.Fill(this.accountDataSet.ACC_MIZAN, dateEdit1.DateTime, dateEdit2.DateTime, SklAslCheckEdit.EditValue.ToString(), DvrCheckEdit.EditValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = accMizanGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("MİZAN  {0:dd.MM.yy} - {1:dd.MM.yy}", dateEdit1.DateTime, dateEdit2.DateTime.AddDays(-1));
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