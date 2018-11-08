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

namespace tMax14.AccountRpr
{
    public partial class DamgaVergisiXF : DevExpress.XtraEditors.XtraForm
    {
        public DamgaVergisiXF()
        {
            InitializeComponent();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = dAMGAV_SELGridControl;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = Text;
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dAMGAV_SELTableAdapter.Fill(this.accountRprDataSet.DAMGAV_SEL, dateEdit1.DateTime, Convert.ToInt32(sonPulNoSpinEdit.EditValue));
                //this.dAMGAV_SELTableAdapter.Fill(this.accountRprDataSet.DAMGAV_SEL, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(iTRHToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}