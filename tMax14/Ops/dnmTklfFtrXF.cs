using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class dnmTklfFtrXF : DevExpress.XtraEditors.XtraForm
    {
        int mID;
        public dnmTklfFtrXF(int mID)
        {
            InitializeComponent();

            this.mID = mID;


            tFaturaGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            
            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

        }

        private void dnmTklfFtrXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("DENEME Teklif->Fatura [{0}]", mID);

            try
            {
                this.tKLF_INS_FTR_DENEMETableAdapter.Fill(this.opsDataSet.TKLF_INS_FTR_DENEME, mID);
                //this.tKLF_INS_FTRTableAdapter.Fill(this.opsDataSet.TKLF_INS_FTR, new System.Nullable<int>(((int)(System.Convert.ChangeType(mIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void mergeCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mergeCellToolStripMenuItem.Checked = !mergeCellToolStripMenuItem.Checked;
            gridView1.OptionsView.AllowCellMerge = mergeCellToolStripMenuItem.Checked;
        }
    }
}