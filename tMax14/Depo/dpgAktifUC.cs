using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;

namespace tMax14.Depo
{
    public partial class dpgAktifUC : DevExpress.XtraEditors.XtraUserControl
    {
        List<int> mIds = new List<int>();
        List<int> dIds = new List<int>();
        XT.xtXUC xtFrm = new XT.xtXUC();
        
        public dpgAktifUC()
        {
            InitializeComponent();

            dpgaGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colGTPID.ColumnEdit = Program.MF.gtpRepositoryItemSearchLookUpEdit;
            colGIRTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colFRTID.ColumnEdit = Program.MF.ftRepositoryItemSearchLookUpEdit;  //Gecici tMax06
            colGIRTAG.ColumnEdit = Program.MF.TagDepoRepositoryItemTextEdit;
            colCIKTAGc.ColumnEdit = Program.MF.TagDepoRepositoryItemTextEdit;
            colCIKTRHc.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            xtFrm.Dock = DockStyle.Fill;
            xtDockPanel.Controls.Add(xtFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor

            dpgaGridControl.DataSource = this.depoDataSet.DPGA;
            Program.MF.GridControlSettings(dpgaGridControl);

        }

        private void dpgAktifUserControl_Load(object sender, EventArgs e)
        {
            this.dpgaTableAdapter.Fill(this.depoDataSet.DPGA);
            this.dpgaTableAdapter.ClearBeforeFill = false;

            this.dpcTableAdapter.ClearBeforeFill = false;
            foreach (DepoDataSet.DPGARow dpgRow in this.depoDataSet.DPGA)
            {
                this.dpcTableAdapter.FillByDPG(this.depoDataSet.DPCA, dpgRow.DPGID);
            }
        }

        private void dpgAktifUC_Enter(object sender, EventArgs e)
        {
            Program.MF.Text = "depoEnter";

        }

        private void dpgAktifUC_Leave(object sender, EventArgs e)
        {
            Program.MF.Text = "depoLeaved";
            string xtBlb, xtTxt;
            if (xtFrm.GetBlob(out xtBlb, out xtTxt))
            {
                dpgaGridView.SetFocusedRowCellValue(colXTBLB, xtBlb);
                dpgaGridView.SetFocusedRowCellValue(colXTTXT, xtTxt);
            }

            Save();
        }

        private void dpgAktifUC_Resize(object sender, EventArgs e)
        {
            dpgaGridView.BestFitColumns();
        }

        private void Save()
        {
            try
            {
                this.Validate();
                this.dpgaBindingSource.EndEdit();
                storeModified();
                this.tableAdapterManager.UpdateAll(this.depoDataSet);
                refreshModified();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void storeModified()
        {
            foreach (DepoDataSet.DPGARow dr in this.depoDataSet.DPGA)
            {
                if (dr.HasErrors)
                    dr.ClearErrors();
                if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
                    mIds.Add(dr.DPGID);
            }
            foreach (DepoDataSet.DPCARow dr in this.depoDataSet.DPCA)
            {
                if (dr.HasErrors)
                    dr.ClearErrors();
                if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
                {
                    if (!mIds.Contains(dr.DPGID))
                        mIds.Add(dr.DPGID);
                    dIds.Add(dr.DPCID);
                }
            }
        }

        private void refreshModified()
        {
            //Refresh Modified ClearBeforeFill = False
            foreach (int PK in mIds)
                dpgaTableAdapter.FillByPK(this.depoDataSet.DPGA, PK);

            foreach (int PK in dIds)
                dpcTableAdapter.FillByPK(this.depoDataSet.DPCA, PK);

            mIds.Clear();
            dIds.Clear();
        }
        
        private void dpgaGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dpgaGridView.SetRowCellValue(e.RowHandle, colDPGID, depoQueriesTableAdapter.GET_PK("DPGC"));
            dpgaGridView.SetRowCellValue(e.RowHandle, colDRM, "A");
            dpgaGridView.SetRowCellValue(e.RowHandle, colGIRTRH, DateTime.Now);
        }

        private void dpcGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colDPCIDc, depoQueriesTableAdapter.GET_PK("DPGC"));
            dpcGridView.SetRowCellValue(e.RowHandle, colCIKTRHc, DateTime.Now);
        }

        // Modified or Added
        private void dpgaGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)    
        {
            Save();
            /*
            //dpgaTableAdapter.Update(dpgaGridView.GetDataRow(e.RowHandle));
            DataRow dr = ((DataRowView)e.Row).Row;
            if (dr.HasErrors)
                dr.ClearErrors();
            dpgaTableAdapter.Update(dr);*/
        }

        // Modified or Added
        private void dpcGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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
                e.Handled = true;
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
                        int PK = (int)view.GetFocusedRowCellValue(colDPGID);
                        if (!mIds.Contains(PK))
                            mIds.Add(PK);
                        view.DeleteRow(view.FocusedRowHandle);
                        Save();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Delete Row");
                    }
                }
                e.Handled = true;
            }
        }

        DockPanel firstDockPanel;

        private void firmaUrunDetaylariToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            Depo.DepoDataSet.DPGARow dpgaRow = (Depo.DepoDataSet.DPGARow)dpgaGridView.GetFocusedDataRow();

            string panelName = "#" + dpgaRow.DPGID.ToString();

            bool found = false;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == panelName)
                {
                    found = true;
                    dockManager.Panels[i].Show();
                    dockManager.Panels[i].Focus();
                    break;
                }
            }

            if (!found)
            {
                dpvUC frm = new dpvUC();
                frm.dpgaRow = dpgaRow;

                frm.Dock = DockStyle.Fill;

                DockPanel docPanel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                docPanel.Name = panelName;
                //docPanel.Visibility = DockVisibility.AutoHide;
                docPanel.Text = panelName;
                //dockManager.Panels.
                docPanel.Controls.Add(frm);     // Panel Show edilene kadar FormLoad cagrilmiyor

                if (dockManager.Panels.Count == 1)
                    firstDockPanel = docPanel;
                else
                    docPanel.DockAsTab(firstDockPanel);
            }*/
        }

        private void dockManager_ClosedPanel(object sender, DockPanelEventArgs e)
        {
            //e.Panel.Dispose();
        }

        private void tableExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Depo.DepoDataSet.DPGARow dpgaRow = (Depo.DepoDataSet.DPGARow)dpgaGridView.GetFocusedDataRow();

            //string panelName = "#" + dpgaRow.DPGID.ToString();
            string panelName = "TableExt";

            bool found = false;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == panelName)
                {
                    found = true;
                    dockManager.Panels[i].Show();
                    dockManager.Panels[i].Focus();
                    break;
                }
            }

            if (!found)
            {
                XT.xtvUC frm = new XT.xtvUC();
                frm.RefTbl = "DPG";
                frm.RefId = dpgaRow.DPGID;
                //frm.dpgaRow = dpgaRow;
                SourceRowChanged +=  frm.AdviseChildSourceRowChanged;

                frm.Dock = DockStyle.Fill;

                DockPanel docPanel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                docPanel.Name = panelName;
                //docPanel.Visibility = DockVisibility.AutoHide;
                docPanel.Text = panelName;
                //dockManager.Panels.
                docPanel.Controls.Add(frm);     // Panel Show edilene kadar FormLoad cagrilmiyor

                if (dockManager.Panels.Count == 1)
                    firstDockPanel = docPanel;
                else
                    docPanel.DockAsTab(firstDockPanel);
            }*/
        }


        private void tableExtensions2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dpgaGridView.DataRowCount == 0)
                return;

            bool panelYok = true;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == "xtPanel")
                {
                    dockManager.Panels[i].Show();
                    panelYok = false;
                }
            }
            if (panelYok)
            {
                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Right);
                panel.Name = "xtPanel";
                panel.Text = "Table Extensions";

                xtFrm = new XT.xtXUC();
                xtFrm.RefTbl = "DPG";
                xtFrm.Dock = DockStyle.Fill;
                panel.Controls.Add(xtFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor

                xtFrm.NewId(dpgaGridView.GetFocusedRowCellValue(colDPGID), dpgaGridView.GetFocusedRowCellValue(colXTBLB));
            }
        }



        public event EventHandler<SourceRowChangedEventArgs> SourceRowChanged;

        protected virtual void OnSourceRowChanged(SourceRowChangedEventArgs e)
        {
            EventHandler<SourceRowChangedEventArgs> eh = SourceRowChanged;
            if (eh != null)
                eh(this, e);
        }

        private void dpgaGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //SourceRowChangedEventArgs ea = new SourceRowChangedEventArgs((int)dpgaGridView.GetRowCellValue(e.FocusedRowHandle, colDPGID));
            //OnSourceRowChanged(ea);  // Rise
            //if (xtFrmVisible)
            {/*
                if (e.PrevFocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    string xtBlb, xtTxt;
                    if (xtFrm.GetBlob(out xtBlb, out xtTxt))
                    {
                        dpgaGridView.SetRowCellValue(e.PrevFocusedRowHandle, colXTBLB, xtBlb);
                        dpgaGridView.SetRowCellValue(e.PrevFocusedRowHandle, colXTTXT, xtTxt);
                    }
                }*/
                xtFrm.NewId(dpgaGridView.GetFocusedRowCellValue(colDPGID), dpgaGridView.GetFocusedRowCellValue(colXTBLB));
            }
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dpgaGridControl.ShowPrintPreview();
        }

        private void dpgaGridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            if (!dpgaGridControl.IsPrinting)
            {
                if (e.RowHeight > 100)
                    e.RowHeight = 100;
            }
        }


    }

    public class SourceRowChangedEventArgs : EventArgs
    {
        private int id;

        public SourceRowChangedEventArgs(int id)
        {
            this.id = id;
        }

        public int ID
        {
            get { return id; }
        }
    }
}
