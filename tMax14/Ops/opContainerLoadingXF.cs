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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace tMax14.Ops
{
    public partial class opContainerLoadingXF : DevExpress.XtraEditors.XtraForm
    {
        public int OPMid = 0;
        GridHitInfo downHitInfo = null;

        public opContainerLoadingXF()
        {
            InitializeComponent();


            opmclGridControl.AllowDrop = true;      // Drag&Drop
            
            opmclGridView.GroupFormat = "{1} {2}";

            opmclGridView.OptionsBehavior.Editable = true;
            opmclGridView.OptionsBehavior.AutoExpandAllGroups = true;
            opmclGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            opmclGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;

            opmclGridView.OptionsCustomization.AllowFilter = false;
            opmclGridView.OptionsCustomization.AllowGroup = false;
            
            opmclGridView.OptionsMenu.EnableColumnMenu = false;
            opmclGridView.OptionsMenu.EnableGroupPanelMenu = false;

            opmclGridView.OptionsView.ShowGroupPanel = false;

            opmclGridView.OptionsSelection.EnableAppearanceFocusedCell = false;

            colMOPPINF.GroupIndex = 0;
            colMOPPID.Visible = false;
            colHOPPID.Visible = false;

            opmclGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;

        }

        private void opContainerLoadingXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.opmclBindingSource.EndEdit();
            DialogResult dr = System.Windows.Forms.DialogResult.Yes;
            if (this.opsDataSet.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var! Kayıt yapılsın?", "OpsHouse Edit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    this.tableAdapterManager.UpdateAll(this.opsDataSet);
                }
            }
        }

        private void opContainerLoadingXF_Load(object sender, EventArgs e)
        {
            this.opmclTableAdapter.Fill(this.opsDataSet.OPM_CNTR_LOAD, OPMid);
        }

        private void Save()
        {
            this.Validate();
            this.opmclBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.opsDataSet);
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void opmclGridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            view.GetGroupRowDisplayText(e.RowHandle);
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            if (string.IsNullOrWhiteSpace(info.GroupValueText))
                info.GroupText = "Not Loaded";

        }

        private void opmclGridView_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None)
                return;

            if (view.GetRowCellValue(hitInfo.RowHandle, colOPHID) == DBNull.Value) // Grup kalmasi icin gonderilen bos satirlari kaldiramasin
                return;

            if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.RowHandle != GridControl.NewItemRowHandle)
                downHitInfo = hitInfo;
        }

        private void opmclGridView_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All);
                    downHitInfo = null;
                }
            }
        }

        private void opmclGridControl_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(GridHitInfo)))
            {
                GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
                if (downHitInfo == null)
                    return;

                GridControl grid = sender as GridControl;
                GridView view = grid.MainView as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle && hitInfo.RowHandle != GridControl.NewItemRowHandle) // && hitInfo.RowHandle < 0) Sadece target Group row
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void opmclGridControl_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.MainView as GridView;
            GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
            GridHitInfo trgHitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));

            object mOPPid, mOPPinf;
            if (trgHitInfo.RowHandle < 0)
            {
                mOPPid = view.GetGroupRowValue(trgHitInfo.RowHandle, colMOPPID);
                mOPPinf = view.GetGroupRowValue(trgHitInfo.RowHandle, colMOPPINF);
            }
            else
            {
                mOPPid = view.GetRowCellValue(trgHitInfo.RowHandle, colMOPPID);
                mOPPinf = view.GetRowCellValue(trgHitInfo.RowHandle, colMOPPINF);
            }

            view.SetRowCellValue(srcHitInfo.RowHandle, colMOPPID, mOPPid);
            view.SetRowCellValue(srcHitInfo.RowHandle, colMOPPINF, mOPPinf);
            view.UpdateCurrentRow();
        }

        private void paketBolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            GridView view = opmclGridView;
            if (view.FocusedRowHandle < 0 || view.GetFocusedRowCellValue(colHOPPID) == DBNull.Value)
            {
                MessageBox.Show("House package seçin");
                return;
            }

            if (string.IsNullOrWhiteSpace(NOPtoolStripTextBox.Text))
            {
                MessageBox.Show("Ayrılacak NOP girin");
                return;
            }
            
            int nNOP = Convert.ToInt32(NOPtoolStripTextBox.Text);

            int fNOP = 1;
            if (view.GetFocusedRowCellValue(colHNOP) != DBNull.Value)
                fNOP = (int)view.GetFocusedRowCellValue(colHNOP);

            int fGrW = 0;
            if (view.GetFocusedRowCellValue(colHGRW) != DBNull.Value)
                fGrW = (int)view.GetFocusedRowCellValue(colHGRW);

            decimal fVM3 = 0;
            if (view.GetFocusedRowCellValue(colHVM3) != DBNull.Value)
                fVM3 = (decimal)view.GetFocusedRowCellValue(colHVM3);
            
            int nGrW = fGrW * nNOP / fNOP;
            decimal nVM3 = fVM3 * nNOP / fNOP;
            string fTOP = view.GetFocusedRowCellDisplayText(colHTOP);

            //Modify Focused
            view.SetFocusedRowCellValue(colHNOP, fNOP - nNOP);
            view.SetFocusedRowCellValue(colHGRW, fGrW - nGrW);
            view.SetFocusedRowCellValue(colHVM3, fVM3 - nVM3);
            //Add new
            OpsDataSet.OPM_CNTR_LOADRow newRow = opsDataSet.OPM_CNTR_LOAD.NewOPM_CNTR_LOADRow();
            newRow.MOPPID = (int)view.GetFocusedRowCellValue(colMOPPID);
            newRow.MOPPINF = view.GetFocusedRowCellDisplayText(colMOPPINF);
            newRow.OPHID = (int)view.GetFocusedRowCellValue(colOPHID);
            //newRow.HOPPID = 999;  Null gitsin InsertProc halledecek
            newRow.HOPPINF = "Yeni";
            newRow.HTOP = fTOP;
            newRow.HNOP = nNOP;
            newRow.HGRW = nGrW;
            newRow.HVM3 = nVM3;
            opsDataSet.OPM_CNTR_LOAD.Rows.Add(newRow);*/
        }

    }
}