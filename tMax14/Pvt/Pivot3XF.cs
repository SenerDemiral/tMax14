using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;

namespace tMax14.Pvt
{
    public partial class Pivot3XF : DevExpress.XtraEditors.XtraForm
    {
        public Pivot3XF()
        {
            InitializeComponent();
            printToolStripMenuItem.Enabled = Program.MF.EntryCheck("Pvt.Pivot3XF.Print", true);
        }

        private void Pivot3XF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pvtDataSet.PVT_3' table. You can move, or remove it, as needed.
            this.pVT_3TableAdapter.Fill(this.pvtDataSet.PVT_3);

        }

        private void pivotGridControl1_FieldAreaChanged(object sender, DevExpress.XtraPivotGrid.PivotFieldEventArgs e)
        {
            showCalcDep(e.Field.UnboundExpression);
        }

        private void showCalcDep(string exp)
        {
            string token;
            MatchCollection matches = Regex.Matches(exp, @"\[\S+\]");
            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    token = match.ToString().Trim(new Char[] { '[', ']' });
                    pivotGridControl1.Fields[token].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
                }
            }
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Pvt.Pivot3XF";
            frm.origin = pivotGridControl1;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }
    }
}