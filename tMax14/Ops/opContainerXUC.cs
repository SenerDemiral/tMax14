using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.Ops
{
    public partial class opContainerXUC : DevExpress.XtraEditors.XtraUserControl
    {
        string layoutName = "Ops.opContainerXUC.opc";
        
        public opContainerXUC()
        {
            InitializeComponent();

            opcGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colOWNID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDPOID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSBSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNBCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colRHB.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colTAGS.ColumnEdit = Program.MF.TAGselOPSrepositoryItemCheckedComboBoxEdit;
            //colOPTYP.ColumnEdit = Program.MF.OpcOpTypRepositoryItemImageComboBox;
            colSTU.ColumnEdit = Program.MF.OpcStuRepositoryItemImageComboBox;
            colR2ID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colR4ID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colKTFR.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colKTFS.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colEKTF.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colBCR.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colSBDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;

            Program.MF.GridControlSettings(opcGridControl);

            colFRTIDc.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTIDc.ColumnEdit = Program.MF.AHTcontainerRepositoryItemGridLookUpEdit;
            colDVZc.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            //colKDY.ColumnEdit = Program.MF.KDYrepositoryItemImageComboBox;
            colBRMc.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;

            Program.MF.AHTcontainerRepositoryItemGridLookUpEdit.Closed += AHTcontainerRepositoryItemGridLookUpEdit_Closed;
            
            opcGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);
        }

        void AHTcontainerRepositoryItemGridLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal && opcGridControl.IsFocused)
            {
                var a = sender as GridLookUpEdit;

                if (a.OldEditValue != a.EditValue)
                {
                    DataRow row = (a.GetSelectedDataRow() as DataRowView).Row;
                    var kdy = row["KDY"];
                    //(opcGridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView).SetFocusedRowCellValue(colKDYc, kdy);     // KDV yok ???????
                }
            }
        }

        private void opContainerXUC_Load(object sender, EventArgs e)
        {
            Qry.qsvOpcXUC frm = new Qry.qsvOpcXUC();
            frm.saveHandler = Save;

            frm.OPC = opsDataSet.OPC;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            /*
            this.opcTableAdapter.Fill(this.opsDataSet.OPC, "", Program.USR);
            this.opccTableAdapter.ClearBeforeFill = false;
            for (int i = 0; i < this.opsDataSet.OPC.Rows.Count; i++)
            {
                this.opccTableAdapter.FillByOPC(this.opsDataSet.OPCC, (int)this.opsDataSet.OPC.Rows[i]["OPCID"]);
            }*/
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.opcBindingSource.EndEdit();
                this.opcTableAdapter.Update(this.opsDataSet.OPC);
                this.opccTableAdapter.Update(this.opsDataSet.OPCC);
                if (opcGridView.IsDataRow(opcGridView.FocusedRowHandle))    // Refresh
                {
                    object pk = opcGridView.GetFocusedRowCellValue(colOPCID);
                    this.opcTableAdapter.ClearBeforeFill = false;
                    this.opcTableAdapter.Fill(this.opsDataSet.OPC, string.Format("OPCID = {0}", pk), Program.USR);
                }
            }
            catch (Exception ex)
            {
                this.opsDataSet.OPC.RejectChanges();
                XtraMessageBox.Show(ex.Message, "OPC Save");
            }
        }
        
        private void oPCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void opcGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            object pk = Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
            opcGridView.SetRowCellValue(e.RowHandle, colOPCID, pk);
            opcGridView.SetRowCellValue(e.RowHandle, colRHB, "F");
            opcGridView.SetRowCellValue(e.RowHandle, colBCR, "F");
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = opcGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                opcGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                opcGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                opcGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                opcGridView.UpdateCurrentRow();
            }
        }

        private void sbHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opcGridView.IsDataRow(opcGridView.FocusedRowHandle))
                return;

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "OPC";
            frm.RefID = (int)opcGridView.GetFocusedRowCellValue(colOPCID);
            frm.RefInfo = opcGridView.GetFocusedRowCellDisplayText(colCNTNO);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = opcGridControl;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;
            link.CreateDocument();
            link.ShowPreview();
        }

        private void sbMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = opcGridView;

            if (!view.IsDataRow(view.FocusedRowHandle) || view.GetFocusedRowCellValue(colSBMID) == DBNull.Value)
                return;

            Ops.opMasterXUC frm = new Ops.opMasterXUC();
            frm.qsString = string.Format("OPMid = {0}", view.GetFocusedRowCellValue(colSBMID));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "Ops";
            panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText(colSBMID);

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
        }

        private void nbMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = opcGridView;

            if (!view.IsDataRow(view.FocusedRowHandle) || view.GetFocusedRowCellValue(colNBMID) == DBNull.Value)
                return;
            
            Ops.opMasterXUC frm = new Ops.opMasterXUC();
            frm.qsString = string.Format("OPMid = {0}", view.GetFocusedRowCellValue(colNBMID));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "Ops";
            panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText(colNBMID);

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = opcGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void chargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pvt.opcChargesXF frm = new Pvt.opcChargesXF();
            frm.opcID = (int)opcGridView.GetFocusedRowCellValue(colOPCID);
            frm.Show();
        }

        private void chrgGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            
            object pk = Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
            view.SetRowCellValue(e.RowHandle, colOPCCIDc, pk);
            view.SetRowCellValue(e.RowHandle, colTRHc, DateTime.Today);
            view.SetRowCellValue(e.RowHandle, colMIKc, 1);
            view.SetRowCellValue(e.RowHandle, colDVZc, "EUR");
        }

        private void createContainerChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opcID = (int)opcGridView.GetFocusedRowCellValue(colOPCID);
            opsQueriesTableAdapter.OPC_CHARGE_CREATE(opcID);

            this.opccTableAdapter.ClearBeforeFill = false;
            this.opccTableAdapter.FillByOPC(this.opsDataSet.OPCC, opcID);
        }

    }
}
