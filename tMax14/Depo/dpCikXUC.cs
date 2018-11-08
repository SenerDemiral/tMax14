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
    public partial class dpCikXUC : DevExpress.XtraEditors.XtraUserControl
    {
        XT.xtXUC xtFrm;
        //Docs.docForm docFrm;

        public dpCikXUC()
        {
            InitializeComponent();

            dpcGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colOPHM.ColumnEdit = Program.MF.hmRepositoryItemImageComboBox;

            dpcGridControl.DataSource = this.depoDataSet.DPC;
            Program.MF.GridControlSettings(dpcGridControl);
        }

        public void Save()  // Calling from MAIN
        {
            this.Validate();
            //this.dpcBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.depoDataSet);
        }

        private void dpCikXUC_Load(object sender, EventArgs e)
        {
            this.dpcTableAdapter.Fill(this.depoDataSet.DPC);
        }

        private void dpcGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dpcGridView.SetRowCellValue(e.RowHandle, colDPCID, Program.MF.mainQueriesTableAdapter.GET_PK("DPC"));
            dpcGridView.SetRowCellValue(e.RowHandle, colOPHM, "H");
        }

        private void dpcGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void tableExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool panelYok = true;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == "xtDockPanel")
                {
                    dockManager.Panels[i].Show();
                    panelYok = false;
                }
            }
            if (panelYok)
            {
                var xtDockPanel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Right);
                xtDockPanel.Name = "xtDockPanel";
                xtDockPanel.Text = "Table Extensions";

                xtFrm = new XT.xtXUC();
                xtFrm.RefTbl = "DPC";
                xtFrm.Dock = DockStyle.Fill;
                xtDockPanel.Controls.Add(xtFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor

                //xtFrm.NewBlob(dpcGridView.GetFocusedRowCellValue(colXTBLB));
                xtFrm.NewId(dpcGridView.GetFocusedRowCellValue(colDPCID), dpcGridView.GetFocusedRowCellValue(colXTBLB));
            }
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dpcGridView.DataRowCount == 0)
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
                int id = (int)dpcGridView.GetFocusedRowCellValue(colDPCID);
                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                panel.Name = "docPanel";

                docFrm = new Docs.docForm();
                docFrm.refTbl = "DPC";
                docFrm.refId = id;
                panel.Text = "Attachments " + docFrm.refTbl + "/" + id.ToString();
                docFrm.Dock = DockStyle.Fill;
                panel.Controls.Add(docFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor
            }*/
        }

    }
}
