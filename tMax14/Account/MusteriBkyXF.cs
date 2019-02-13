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

namespace tMax14.Account
{
    public partial class MusteriBkyXF : DevExpress.XtraEditors.XtraForm
    {
        // KULLANILMIYOR
        public MusteriBkyXF()
        {
            InitializeComponent();
        }

        private void MusteriBkyXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.ACC_BKY' table. You can move, or remove it, as needed.
            this.aCC_BKYTableAdapter.Fill(this.accountDataSet.ACC_BKY);

        }

        private void accBkyGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDDVZ.GroupIndex == -1 || e.GroupLevel < colDDVZ.GroupIndex) && (fn == "DBRCBKY" || fn == "DALCBKY"))
                {
                    e.Exists = false;
                }
            }
        }

        private void hesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = accBkyGridView;

            FisDetayHistoryXF frm = new FisDetayHistoryXF();
            frm.iQry = string.Format("HspNo in ({0})", view.GetFocusedRowCellValue(colHSPNOS)); 
            //frm.info = view.GetFocusedRowCellValue(colHSPAD).ToString() + "  " + view.GetFocusedRowCellDisplayText(colHSPNOS);
            //frm.Show();

            frm.Dock = DockStyle.Fill;
            var dd = frm.Size.Height;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = view.GetFocusedRowCellDisplayText(colHSPAD) + "  " + view.GetFocusedRowCellDisplayText(colHSPNOS);
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            var ddd= dockManager.Panels.Count;
            if (dockManager.Panels.Count > 1)
            {
                dockManager.Panels[0].Show();
                panel.DockAsTab(dockManager.Panels[0], 0);
            }
        }
    }
}