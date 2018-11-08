using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Depo
{
    public partial class gtpXUC : DevExpress.XtraEditors.XtraUserControl
    {
        List<int> mIds = new List<int>();
        
        public gtpXUC()
        {
            InitializeComponent();
        }

        private void gtpUC_Load(object sender, EventArgs e)
        {
            this.gtpTableAdapter.Fill(this.depoDataSet.GTP);
            this.gtpTableAdapter.ClearBeforeFill = false;
        }

        private void Save()
        {
            this.Validate();
            this.gtpBindingSource.EndEdit();
            storeModified();
            this.tableAdapterManager.UpdateAll(this.depoDataSet);
            refreshModified();
        }

        private void gtpGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gtpGridView.SetRowCellValue(e.RowHandle, colGTPID, depoQueriesTableAdapter.GET_PK("GTP"));
        }

        private void storeModified()
        {
            foreach (DepoDataSet.GTPRow dr in this.depoDataSet.GTP)
            {
                if (dr.HasErrors)
                    dr.ClearErrors();
                if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
                    mIds.Add(dr.GTPID);
            }
        }

        private void refreshModified()
        {
            //Refresh Modified ClearBeforeFill = False
            foreach (int PK in mIds)
                gtpTableAdapter.FillByPK(this.depoDataSet.GTP, PK);

            mIds.Clear();
        }

        private void gtpGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Save();   
        }

        private void GridControl_KeyDown(object sender, KeyEventArgs e)
        {
            // Master ve Detay icin calisiyor!!
            if (e.KeyCode == Keys.Insert && e.Control)
            {
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)(sender as DevExpress.XtraGrid.GridControl).FocusedView;
                view.AddNewRow();
            }
            else if (e.KeyCode == Keys.Delete && e.Control)
            {
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)(sender as DevExpress.XtraGrid.GridControl).FocusedView;

                if (!view.IsDataRow(view.FocusedRowHandle))
                    return;

                if (!view.IsDetailView && !view.IsMasterRowEmpty(view.FocusedRowHandle))
                {
                    XtraMessageBox.Show("Detayı var, önce onları silmelisiniz.!", "Delete Master Row");
                    return;
                }
                if (XtraMessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        view.DeleteRow(view.FocusedRowHandle);
                        Save();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Delete Row");
                    }
                }
            }
        }


    }
}
