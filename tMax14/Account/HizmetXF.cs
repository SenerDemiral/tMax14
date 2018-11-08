using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Account
{
    public partial class HizmetXF : DevExpress.XtraEditors.XtraForm
    {
        public HizmetXF()
        {
            InitializeComponent();

            ahtGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colUSEIN.ColumnEdit = Program.MF.AHTuseInRepositoryItemCheckedComboBoxEdit;

            colHSPNO_SNYI.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_ANYI.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_SIYI.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_AIYI.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;

            colHSPNO_SNYD.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_ANYD.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_SIYD.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_AIYD.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;


            gridControl1.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNO_SNYI2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_ANYI2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_SIYI2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_AIYI2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;

            colHSPNO_SNYD2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_ANYD2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_SIYD2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colHSPNO_AIYD2.ColumnEdit = Program.MF.AHPrepositoryItemSearchLookUpEdit;

            colMCAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;

            /*
            colDPTS.ColumnEdit = Program.MF.DPTrepositoryItemCheckedComboBoxEdit;
            colICFR.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colICIF.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colICIP.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colICPT.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colIDAP.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colIDAT.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colIDDP.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colIEXW.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colIFAS.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colIFCA.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colIFOB.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;*/

            colROTb.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTb.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colBRMb.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;

        }

        private void ahtBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ahtBindingSource.EndEdit();
            this.ahtTableAdapter.Update(this.accountDataSet.AHT);

            this.ahbTableAdapter.Update(this.accountDataSet.AHB);
        }

        private void HizmetXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.AHT' table. You can move, or remove it, as needed.
            this.ahtTableAdapter.Fill(this.accountDataSet.AHT);
            this.ahbTableAdapter.Fill(this.accountDataSet.AHB);

            EXBHmemoEdit.Properties.ReadOnly = Program.USTid != -1;
            EXBMmemoEdit.Properties.ReadOnly = Program.USTid != -1;
            EXBCmemoEdit.Properties.ReadOnly = Program.USTid != -1;
        }

        private void ahtGridView_ShowingEditor(object sender, CancelEventArgs e)
        {

        }

        private void ahtGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            
            object PK = Program.MF.mainQueriesTableAdapter.GET_PK("AHT");
            view.SetRowCellValue(e.RowHandle, colAHTID, PK);

        }

        private void ahbGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colAHTIDb, ahtGridView.GetFocusedRowCellValue(colAHTID));
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ahtGridControl.ShowPrintPreview();
        }

        private void hesaplariGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colHSPNO_SNYI.Visible = hesaplariGosterToolStripMenuItem.Checked;
            colHSPNO_ANYI.Visible = hesaplariGosterToolStripMenuItem.Checked;
            colHSPNO_SIYI.Visible = hesaplariGosterToolStripMenuItem.Checked;
            colHSPNO_AIYI.Visible = hesaplariGosterToolStripMenuItem.Checked;

            colHSPNO_SNYD.Visible = hesaplariGosterToolStripMenuItem.Checked;
            colHSPNO_ANYD.Visible = hesaplariGosterToolStripMenuItem.Checked;
            colHSPNO_SIYD.Visible = hesaplariGosterToolStripMenuItem.Checked;
            colHSPNO_AIYD.Visible = hesaplariGosterToolStripMenuItem.Checked;

        }

    }
}