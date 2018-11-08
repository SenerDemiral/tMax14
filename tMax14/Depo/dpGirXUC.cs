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
    public partial class dpGirXUC : DevExpress.XtraEditors.XtraUserControl
    {
        XT.xtXUC xtFrm;
        //Docs.docForm docFrm;

        public dpGirXUC()
        {
            InitializeComponent();

            dpgGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colOPHM.ColumnEdit = Program.MF.hmRepositoryItemImageComboBox;

            dpgGridControl.DataSource = this.depoDataSet.DPG;
            Program.MF.GridControlSettings(dpgGridControl);
        }

        public void Save()  // Calling from MAIN
        {
            this.Validate();
            //this.dpgBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.depoDataSet);
        }

        private void dpGirXUC_Load(object sender, EventArgs e)
        {
            this.dpgTableAdapter.Fill(this.depoDataSet.DPG);
        }

        private void dpgGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dpgGridView.SetRowCellValue(e.RowHandle, colDPGID, Program.MF.mainQueriesTableAdapter.GET_PK("DPG"));
            dpgGridView.SetRowCellValue(e.RowHandle, colOPHM, "H");
        }

        private void dpgGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view.GetRowCellValue(e.RowHandle, colOPID) == DBNull.Value)
            {
                e.ErrorText = "HMid girilmemiş";
                e.Valid = false;
            }
        }

        private void dockManager_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            //e.Panel.Dispose();
            var aaa = e.Panel.IsDisposed.ToString();
        }

        private void dpgGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (xtFrm != null)
            {/*
                if (e.PrevFocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    string xtBlb, xtTxt;
                    if (xtFrm.GetBlob(out xtBlb, out xtTxt))
                    {
                        dpgGridView.SetRowCellValue(e.PrevFocusedRowHandle, colXTBLB, xtBlb);
                        dpgGridView.SetRowCellValue(e.PrevFocusedRowHandle, colXTTXT, xtTxt);
                        Save();
                    }
                }*/
                xtFrm.NewId(dpgGridView.GetFocusedRowCellValue(colDPGID), dpgGridView.GetFocusedRowCellValue(colXTBLB));
            }
        }

        private void tableExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dpgGridView.DataRowCount == 0)
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

                xtFrm.NewId(dpgGridView.GetFocusedRowCellValue(colDPGID), dpgGridView.GetFocusedRowCellValue(colXTBLB));
            }
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dpgGridView.DataRowCount == 0)
                return;
            /*
            bool panelYok = true;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == "docPanel")
                {
                    dockManager.Panels[i].Show();
                    panelYok = false;
                }
            }
            if (panelYok)
            {
                int id = (int)dpgGridView.GetFocusedRowCellValue(colDPGID);
                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                panel.Name = "docPanel";
   
                docFrm = new Docs.docForm();
                docFrm.refTbl = "DPG";
                docFrm.refId = id;
                panel.Text = "Attachments " + docFrm.refTbl + "/" + id.ToString();
                docFrm.Dock = DockStyle.Fill;
                panel.Controls.Add(docFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor
            }*/
        }
    }
}
