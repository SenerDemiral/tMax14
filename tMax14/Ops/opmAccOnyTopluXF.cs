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

namespace tMax14.Ops
{
    public partial class opmAccOnyTopluXF : DevExpress.XtraEditors.XtraForm
    {
        public opmAccOnyTopluXF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            opmAccOnyTopluTableAdapter.Fill(opsDataSet.OPM_ACC_ONY_TOPLU, Program.USR, ATD1dateEdit.DateTime, ATD2dateEdit.DateTime, TOBtextEdit.Text, ROTtextEdit.Text, MOTtextEdit.Text);
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = gridView1;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Ops.opMasterXUC frm = new Ops.opMasterXUC();
            frm.qsString = string.Format("OPMid = {0}", view.GetFocusedRowCellValue(colOPMID));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "Ops";
            panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText(colOPMID);

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);

        }

        private void profitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMaster.opMasterProfitXF", isSilent: true))
                return;

            int OPMid = (int)gridView1.GetFocusedRowCellValue(colOPMID);
            opMasterProfitXF frm = new opMasterProfitXF();
            frm.OPMid = OPMid;
            frm.ShowDialog();
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("OK olanlar onaylanacak. Eminmisiniz?", "Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;

            gridView1.UpdateCurrentRow();
            gridView1.BeginSort();

            int dataRowCount = gridView1.DataRowCount;
            for (int i = 0; i < dataRowCount; i++)
            {
                object cellValue = gridView1.GetRowCellValue(i, colOPMID);
                if (gridView1.GetRowCellValue(i, colOK).ToString() == "T")
                {
                    gridView1.FocusedRowHandle = i;
                    gridView1.SetFocusedRowCellValue(colDRM, "OK");
                    gridView1.UpdateCurrentRow();
                }
            }
            gridView1.EndSort();

            int nor = opmAccOnyTopluTableAdapter.Update(opsDataSet.OPM_ACC_ONY_TOPLU);
            if (nor > 0)
                opmAccOnyTopluTableAdapter.Fill(opsDataSet.OPM_ACC_ONY_TOPLU, Program.USR, ATD1dateEdit.DateTime, ATD2dateEdit.DateTime, TOBtextEdit.Text, ROTtextEdit.Text, MOTtextEdit.Text);
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)gridView1.GetFocusedRowCellValue(colOPMID);
            string bkms = opsQueriesTableAdapter.OPM_BKMS_TOGGLE(OPMid, Program.USRtag).ToString();
            gridView1.SetFocusedRowCellValue(colBKMS, bkms);
            /*
            string BKMS = gridView1.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                gridView1.SetFocusedRowCellValue(colBKMS, BKMS);
                gridView1.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                gridView1.SetFocusedRowCellValue(colBKMS, BKMS);
                gridView1.UpdateCurrentRow();
            }
            */
        }


    }
}