using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Qry
{
    public partial class qsvOpcXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Ops.OpsDataSet.OPCDataTable OPC;
        public delegate void Save();
        public Save saveHandler;

        int focusedRecord = 0;
        
        public qsvOpcXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            rowOwnID.Properties.RowEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;
            rowDpoID.Properties.RowEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;
            //rowStu.Properties.RowEdit = Program.MF.OpcStuRepositoryItemImageComboBox;
            rowStu.Properties.RowEdit = Program.MF.OpcStuRepositoryItemCheckedComboBoxEdit;
            rowBKMS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
        }

        private void qsvOpcXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvOPC", 0, qryDataSet.qsOPC);
            if (qryDataSet.qsOPC.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsOPC.NewqsOPCRow();
                qryDataSet.qsOPC.Rows.Add(newRow);
            }
        }

        private void qsvGridControl_CellValueChanging(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {

        }

        private void qsvGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prepareQry();
                Search();
                e.Handled = true;
            }
        }

        private void qsvGridControl_VisibleChanged(object sender, EventArgs e)
        {
            qsvGridControl.FocusedRecord = focusedRecord;
        }

        private void qsvGridControl_HiddenEditor(object sender, EventArgs e)
        {
            prepareQry();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(qryMemoEdit.Text))
                return;

            int nor = 0;
            Program.MF.startSW();
            focusedRecord = qsvGridControl.FocusedRecord;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                saveHandler();

                nor = opcTableAdapter.Fill(OPC, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("45'Containers", nor);

                Program.MF.QSsave("qsvOPC", 0, qryDataSet.qsOPC);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                {
                    var dp = this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel;
                    if (dp.Visibility == DevExpress.XtraBars.Docking.DockVisibility.AutoHide)
                        dp.HideImmediately();
                }
            }
        }

        private void prepareQry()
        {
            var view = qsvGridControl;
            if (view.FocusedRecord < 0)
            {
                Program.MF.QSsave("qsvOPC", 0, qryDataSet.qsOPC);
            }
            view.CloseEditor();

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOpcID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OPCID in ({0})", view.GetCellValue(rowOpcID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOwnID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OwnID in ({0})", view.GetCellValue(rowOwnID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDpoID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("DpoID in ({0})", view.GetCellValue(rowDpoID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowSBmID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("SBmID in ({0})", view.GetCellValue(rowSBmID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowNBmID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("NBmID in ({0})", view.GetCellValue(rowNBmID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowStu, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("Stu in ({0})", view.GetCellValue(rowStu, view.FocusedRecord)));
            }
            /*
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowStu, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("Stu = '{0}'", view.GetCellValue(rowStu, view.FocusedRecord)));
            }
            */
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowCntNo, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("CntNo like '%{0}'", view.GetCellValue(rowCntNo, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAgnRef, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AgnRef like '%{0}'", view.GetCellValue(rowAgnRef, view.FocusedRecord)));
            }


            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowBKMS, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");

                //MessageBox.Show(view.GetCellValue(rowBKMS, view.FocusedRecord).ToString());
                //string bkms = view.GetCellValue(rowBKMS, view.FocusedRecord).ToString().Replace("><", ">','<").Replace("<", "'<").Replace(">", ">'");
                //sb.AppendLine(string.Format("BKMS in ({0})", bkms));

                sb.Append("( ");
                string[] sa = view.GetCellValue(rowBKMS, view.FocusedRecord).ToString().Split(new char[] { ',' });
                for (int i = 0; i < sa.Length; i++)
                {
                    if (i > 0)
                        sb.Append(" or ");
                    sb.Append(string.Format("BKMS containing '{0}'", sa[i].Trim()));
                }
                sb.AppendLine(")");
            }

            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());
        }

    }
}
