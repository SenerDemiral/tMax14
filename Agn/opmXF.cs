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
    public partial class opmXF : DevExpress.XtraEditors.XtraForm
    {
        public opmXF()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.wAN_AGN_OPM_SELTableAdapter.Fill(this.agnDataSet.WAN_AGN_OPM_SEL, Program.AgnID, iQRYToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ophXF frm = new ophXF();
            object opmID = opmSelGridView.GetFocusedRowCellValue(colOPMID);
            frm.qry = string.Format("OPMid = {0}", opmID);
            frm.Text = string.Format("Houses of M{0}", opmID);
            Program.MF.tabbedView.AddDocument(frm);
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docXF frm = new docXF();
            object opmID = opmSelGridView.GetFocusedRowCellValue(colOPMID);
            frm.qry = string.Format("RefTbl = 'OPM' and RefID = {0}", opmID);
            frm.Text = string.Format("Attachments of M{0}", opmID);
            Program.MF.tabbedView.AddDocument(frm);

        }
    }
}