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
    public partial class qsOphoXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Order.OrderDataSet.OPHODataTable OPHO;
        int focusedRecord = 0;

        public qsOphoXUC()
        {
            InitializeComponent();
        }

        private void qsOphoXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsOPHO", 0, qryDataSet.qsOPHO);
            if (qryDataSet.qsOPHO.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsOPHO.NewqsOPHORow();
                //newRow.Own = "F";
                qryDataSet.qsOPHO.Rows.Add(newRow);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            int nor = 0;
            Program.MF.startSW();
            focusedRecord = qsvGridControl.FocusedRecord;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = 0; // ophoTableAdapter.Fill(OPHO, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Matalan Orders", nor);

                Program.MF.QSsave("qsvTAF", 0, qryDataSet.qsTAF);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                {
                    var dp = this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel;
                    if (dp.Visibility == DevExpress.XtraBars.Docking.DockVisibility.AutoHide)
                        dp.HideImmediately();
                }
            }
        }

    
    }
}
