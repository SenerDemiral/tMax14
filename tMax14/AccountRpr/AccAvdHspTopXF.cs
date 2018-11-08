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

namespace tMax14.AccountRpr
{
    public partial class AccAvdHspTopXF : DevExpress.XtraEditors.XtraForm
    {
        public AccAvdHspTopXF()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aCC_AVD_HSPTOPTableAdapter.Fill(this.accountRprDataSet.ACC_AVD_HSPTOP, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(tRHLTToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gridView1_EndGrouping(object sender, EventArgs e)
        {
            MessageBox.Show(colDVZ.GroupIndex.ToString());

            
        }

        private void hesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = gridView1;

            AccountRpr.AvdHstXF frm = new AccountRpr.AvdHstXF();
            frm.HspNo = view.GetFocusedRowCellDisplayText(colHSPNO);
            frm.FRTid = 0;
            frm.info = string.Format("{0} • {1}", view.GetFocusedRowCellDisplayText(colHSPNO), view.GetFocusedRowCellDisplayText(colHSPAD));
            frm.Show();

        }
    }
}