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

namespace Agn
{
    public partial class ophXF : DevExpress.XtraEditors.XtraForm
    {
        public string qry = "";

        public ophXF()
        {
            InitializeComponent();
        }

        private void ophXF_Load(object sender, EventArgs e)
        {
            this.ophSelTableAdapter.Fill(this.agnDataSet.WAN_AGN_OPH_SEL, Program.AgnID, qry);
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docXF frm = new docXF();
            object ophID = ophSelGridView.GetFocusedRowCellValue(colOPHID);
            frm.qry = string.Format("RefTbl = 'OPH' and RefID = {0}", ophID);
            frm.Text = string.Format("Attachments of H{0}", ophID);
            Program.MF.tabbedView.AddDocument(frm);
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = ophSelGridView;

            houeseOppXUC frm = new houeseOppXUC();
            frm.ophID = (int)view.GetFocusedRowCellValue(colOPHID);
            //frm.info = view.GetFocusedRowCellValue(colHSPAD).ToString() + "  " + view.GetFocusedRowCellDisplayText(colHSPNOS);
            //frm.Show();

            frm.Dock = DockStyle.Fill;
            var dd = frm.Size.Height;
            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
            panel.Text = view.GetFocusedRowCellDisplayText(colOPHID);
            panel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
            panel.Controls.Add(frm);
            var ddd = dockManager.Panels.Count;
            if (dockManager.Panels.Count > 1)
            {
                dockManager.Panels[0].Show();
                panel.DockAsTab(dockManager.Panels[0], 0);
            }

        }
    }
}