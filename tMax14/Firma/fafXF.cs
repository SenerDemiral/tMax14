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

namespace tMax14.Firma
{
    public partial class fafXF : DevExpress.XtraEditors.XtraForm
    {
        public fafXF()
        {
            InitializeComponent();

            fafGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHM1.ColumnEdit = Program.MF.hmRepositoryItemImageComboBox;
            colTOB1.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colROT1.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT1.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colFRTID1.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTID1.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFTRTUR1.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colDVZ1.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBRM1.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;

            fafTestGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHM2.ColumnEdit = Program.MF.hmRepositoryItemImageComboBox;
            colTOB2.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colROT2.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT2.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colFRTID2.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTID2.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFTRTUR2.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colDVZ2.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBRM2.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
        }

        private void fAFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fAFBindingSource.EndEdit();
            this.fAFTableAdapter.Update(this.firmaDataSet.FAF);

        }

        private void fafXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.FAF' table. You can move, or remove it, as needed.
            this.fAFTableAdapter.Fill(this.firmaDataSet.FAF);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fAF_SEL_TESTTableAdapter.Fill(this.firmaDataSet.FAF_SEL_TEST, new System.Nullable<int>(((int)(System.Convert.ChangeType(mIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            int PK = (int)firmaQueriesTableAdapter.GET_PK("FAF");
            view.SetFocusedRowCellValue(colFAFID1, PK);

        }

        private void OpsFrtRepositoryItemImageComboBox_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colHM1).ToString() == "M" && e.Value.ToString().StartsWith("h"))
                e.AcceptValue = false;
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAFBindingNavigatorSaveItem.PerformClick();

            int PK = (int)gridView1.GetFocusedRowCellValue(colFAFID1);
            int dHid = (int)firmaQueriesTableAdapter.FAF_DUP(PK);
            if (dHid != 0)
            {
                this.fAFTableAdapter.Fill(this.firmaDataSet.FAF);
            }

        }
    }
}