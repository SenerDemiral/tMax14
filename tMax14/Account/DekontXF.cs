using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.Account
{
    public partial class DekontXF : DevExpress.XtraEditors.XtraForm
    {
        public DekontXF()
        {
            InitializeComponent();

            arbGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colDRM.ColumnEdit = Program.MF.AFBdrmRepositoryItemImageComboBox;
            colBRCFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colALCFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colBRCDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colALCDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            colAHTIDd.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colDVZd.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            Program.MF.GridControlSettings(this.arbGridControl);
        }

        public void Save()
        {
            this.Validate();
            this.arbBindingSource.EndEdit();
            this.arbTableAdapter.Update(this.accountDataSet.ARB);
            this.ardTableAdapter.Update(this.accountDataSet.ARD);
        }


        private void DekontXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }
        
        private void DekontXF_Load(object sender, EventArgs e)
        {
            this.arbTableAdapter.Fill(this.accountDataSet.ARB, "", Program.USR);
            this.arbTableAdapter.ClearBeforeFill = false;
            this.ardTableAdapter.ClearBeforeFill = false;
        }

        private void adbGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            int arbID = (int)accountQueriesTableAdapter.GET_PK("ACC");
            view.SetFocusedRowCellValue(colARBID, arbID);
            view.SetFocusedRowCellValue(colEDITABLE, "T");
            
            view.SetFocusedRowCellValue(colTRH, DateTime.Today);
            view.SetFocusedRowCellValue(colDRM, "A");   // Acik

            view.SetFocusedRowCellValue(colBRCDVZ, "TRL");
            view.SetFocusedRowCellValue(colBRCKUR, 1.0);

            view.SetFocusedRowCellValue(colALCDVZ, "TRL");
            view.SetFocusedRowCellValue(colALCKUR, 1.0);
        }

        private void adbGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = arbGridView;
            e.Cancel = view.GetFocusedRowCellValue(colEDITABLE).ToString() == "F";
        }

        private void dekontKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = arbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "A")
                return;

            if (!Program.MF.EntryCheck("Account.DekontXF.Kapat", false))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colARBID);
            try
            {
                Save();
                string OK = accountQueriesTableAdapter.ARB_KAPA(PK, Program.USR).ToString();
                if (OK == "T")
                    this.arbTableAdapter.Fill(this.accountDataSet.ARB, string.Format("ARBID = {0}", PK), Program.USR); //Refresh Clear=false
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void dekontAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = arbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRM).ToString() != "K")
                return;

            if (!Program.MF.EntryCheck("Account.DekontXF.Ac", false))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colARBID);
            try
            {
                string OK = accountQueriesTableAdapter.ARB_AC(PK, Program.USR).ToString();
                if (OK == "T")
                    this.arbTableAdapter.Fill(this.accountDataSet.ARB, string.Format("ARBid = {0}", PK), Program.USR); //Refresh Clear=false
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void arbDtyGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            int ardID = (int)accountQueriesTableAdapter.GET_PK("ACC");
            view.SetFocusedRowCellValue(colARDIDd, ardID);
            view.SetFocusedRowCellValue(colDVZd, "TRL");
        }

        private void arbGridView_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView view = arbGridView;
            //var aaa = e.ChildList.Count;

            if (view.GetFocusedRowCellValue(colEDITABLE).ToString() == "T")
            {
                arbDtyGridView.OptionsBehavior.Editable = true;
                arbDtyGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            }
            else
            {
                arbDtyGridView.OptionsBehavior.Editable = false;
                arbDtyGridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }

            int arbID = (int)view.GetRowCellValue(e.RowHandle, colARBID);

            int nor = this.accountDataSet.ARD.Select(string.Format("ARBID = {0}", arbID)).Length;
            if (nor == 0)
                this.ardTableAdapter.Fill(this.accountDataSet.ARD, arbID);
        }

        private void arbDtyGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            arbGridView.SetFocusedRowModified();
        }

        private void muhasebeFisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arbGridView.GetFocusedRowCellValue(colDRM).ToString() != "A")
            {
                int PK = (int)arbGridView.GetFocusedRowCellValue(colARBID);
                FisDetayXF frm = new FisDetayXF("R", PK);
                frm.ShowDialog();
            }

        }

    }
}