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

namespace tMax14.WAN
{
    public partial class matalanOrderXF : DevExpress.XtraEditors.XtraForm
    {
        public matalanOrderXF()
        {
            InitializeComponent();

            wmobGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
        }

        private void matalanOrderXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wanDataSet.WMOB' table. You can move, or remove it, as needed.
            this.wmobTableAdapter.Fill(this.wanDataSet1.WMOB);
            this.wmodTableAdapter.Fill(this.wanDataSet1.WMOD);

        }

        private void wmobGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("WMO");  //Tender/Teklif
            view.SetFocusedRowCellValue(colWMOBID, PK);
        }

        private void wmodGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("WMO");  //Tender/Teklif
            view.SetFocusedRowCellValue(colWMODIDd, PK);
        }

        object[] detayRow;

        private void satirKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)wmobGridControl.FocusedView;
            if (view.Name != wmodGridView.Name)
                return;

            int sri = view.GetDataSourceRowIndex(view.FocusedRowHandle);
            detayRow = this.wanDataSet1.WMOD.Rows[sri].ItemArray;

        }

        private void satirYapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)wmobGridControl.FocusedView;
            if (view.Name != wmodGridView.Name)
                return;

            if (detayRow == null)
                return;

            int masterRH = view.SourceRowHandle;

            wanDataSet.WMODRow newRow = wanDataSet1.WMOD.NewWMODRow();
            newRow.ItemArray = detayRow;
            newRow.WMOBID = (int)wmobGridView.GetRowCellValue(masterRH, colWMOBID);
            newRow.WMODID = (int)Program.MF.mainQueriesTableAdapter.GET_PK("WMO");
            wanDataSet1.WMOD.AddWMODRow(newRow);
        }

        private void detayContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            GridView view = (GridView)wmobGridControl.FocusedView;
            if (view.Name != wmodGridView.Name)
            {
                //e.Cancel = true;
                satirKopyalaToolStripMenuItem.Enabled = false;
                satirYapistirToolStripMenuItem.Enabled = false;
            }
            else
            {
                satirKopyalaToolStripMenuItem.Enabled = true;
                satirYapistirToolStripMenuItem.Enabled = true;
            }
        }

        private void satirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satirSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)wmobGridControl.FocusedView;
            if (view.Name == wmodGridView.Name)
                view.DeleteRow(view.FocusedRowHandle);
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wmobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wanDataSet1);
        }

    }
}