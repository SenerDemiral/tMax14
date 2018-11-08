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
using DevExpress.XtraGrid;

namespace tMax14.Account
{
    public partial class Muavin : DevExpress.XtraEditors.XtraUserControl
    {
        public string HspNo;
        public int FRTid;

        public Muavin()
        {
            InitializeComponent();

            accMuavinGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNO.ColumnEdit = Program.MF.AHPrepositoryItemLookUpEdit;
        }

        private void Muavin_Load(object sender, EventArgs e)
        {
            if (FRTid != 0)
            {
                Text = string.Format("{0} Hesap Hareketleri", FRTid);
                colHSPNO.Visible = true;
            }
            else
            {                
                Text = string.Format("{0} Hesap Hareketleri", HspNo);
                colHSPNO.Visible = false;
            }

            this.accMuavinTableAdapter.Fill(this.accountDataSet.ACC_MUAVIN, HspNo, FRTid);
        }

        private void accMuavingridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            // RunningTotal  http://www.devexpress.com/Support/Center/Question/Details/Q366364

            GridView view = (GridView)sender;
            int rh = view.GetRowHandle(e.ListSourceRowIndex);

            if (e.Column == colREFID)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetRowCellValue(rh, colREFTO));
            
            if (e.Column.FieldName != "aRunTotal") return;

            int firstRowHandle = view.GroupCount == 0 ? 0 : view.GetChildRowHandle(view.GetParentRowHandle(rh), 0);
            decimal qta = 0;
            for (int i = firstRowHandle; i <= rh; i++)
            {
                if (view.GetRowCellValue(i, colBA).ToString() == "B")
                    qta += Convert.ToDecimal(view.GetRowCellValue(i, colATUT));
                else
                    qta -= Convert.ToDecimal(view.GetRowCellValue(i, colATUT));
            }
            if (qta < 0)
                e.DisplayText = (Math.Abs(qta)).ToString("N") + " A";
            else if (qta > 0)
                e.DisplayText = qta.ToString("N") + " B";
            else
                e.DisplayText = "";
        }

        private void accMuavingridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDDVZ.GroupIndex == -1 || e.GroupLevel < colDDVZ.GroupIndex) && (fn == "DBRC" || fn == "DALC"))
                {
                    e.Exists = false;
                }
            }
        }

    }
}