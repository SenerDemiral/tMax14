using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class opMasterLoadingXF : DevExpress.XtraEditors.XtraForm
    {
        int posNo = 0;
        string OrderFieldName = "MIDX";
        //DataTable dstTable;
        Ops.OpsDataSet.OPHDataTable dstTable = new OpsDataSet.OPHDataTable();
        public Ops.OpsDataSet.OPM_SELRow opmRow;

        public opMasterLoadingXF()
        {
            InitializeComponent();

            dstGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colEXDd.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colNSTUd.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemLookUpEdit;
            colROTd.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTd.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colORGd.ColumnEdit = Program.MF.locRepositoryItemPopupContainerEdit;
            colDSTd.ColumnEdit = Program.MF.locRepositoryItemPopupContainerEdit; //SearchLookUpEdit;// RepositoryItemPopupContainerEdit;
            colMNFIDd.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colSHPIDd.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colCNEIDd.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //ftRepositoryItemSearchLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colTUSs.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;

            srcGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colNSTUs.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemLookUpEdit;
            colEXDs.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colEOHs.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROTs.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTs.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colTUSs.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            
            colORGs.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;            ////////////// LOC OKUNMUYIR
            colDSTs.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;  //SearchLookUpEdit;
            
            //colDSTs.ColumnEdit = Program.MF.locRepositoryItemPopupContainerEdit; //SearchLookUpEdit;// RepositoryItemPopupContainerEdit;
            colMNFIDs.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colSHPIDs.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colCNEIDs.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //ftRepositoryItemSearchLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
        
        
        }

        private void opMasterLoading_Load(object sender, EventArgs e)
        {
            this.ophTableAdapter.FillByNoMstr(this.opsDataSet.OPH);
            StringBuilder sb = new StringBuilder();

            sb.Append("[NSTU] <> 'AB' and ");   // Aborted
            sb.Append("[NSTU] <> 'C' and ");    // Cancelled
            sb.Append("[NSTU] <> 'QC' and ");   // QC Failed
            sb.Append("[ROT] = '" + opmRow.ROT + "' and ");
            sb.Append("[MOT] = '" + opmRow.MOT + "'");
            if (!opmRow.IsORGNull())
                sb.Append(" and [ORG] like '" + opmRow.ORG.Substring(0, 2) + "%'");
            if (!opmRow.IsDSTNull())
                sb.Append(" and [DST] like '" + opmRow.DST.Substring(0, 2) + "%'");

            srcGridView.ActiveFilterString = sb.ToString();

            //dstTable = this.opsDataSet.OPH.Clone();
            dstGridControl.DataSource = dstTable;
            //dstGridView.PopulateColumns();

            this.ophTableAdapter.FillByOPM(dstTable, opmRow.OPMID);
            foreach (Ops.OpsDataSet.OPHRow ophRow in dstTable.Rows)
            {
                if (!ophRow.IsMIDXNull() && ophRow.MIDX > posNo)
                    posNo = ophRow.MIDX;
            }
            posNo++;

            dstGridView.Columns[OrderFieldName].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dstGridView.OptionsCustomization.AllowSort = false;
            dstGridView.OptionsView.ShowGroupPanel = false;
        }

        private void src2dst()
        {
            if (srcGridView.RowCount == 0)
                return;

            if (dstGridView.RowCount == 0)
                posNo = 0;
            object[] values = srcGridView.GetDataRow(srcGridView.FocusedRowHandle).ItemArray;
            values[srcGridView.Columns["MIDX"].ColumnHandle] = posNo++;
            dstTable.Rows.Add(values);
            
            /*
            DataRow row;

            row = dstTable.NewRow(); // dataSet.Tables[0].NewRow();
            row[OrderFieldName] = posNo++;
            row["OPHID"] = srcGridView.GetFocusedRowCellValue("OPHID");
            dstTable.Rows.Add(row);//dataSet.Tables[0].Rows.Add(row);
            */
            srcGridView.DeleteRow(srcGridView.FocusedRowHandle);
        }

        private void dst2src()
        {
            if (dstGridView.RowCount == 0)
                return;

            object[] values = dstGridView.GetDataRow(dstGridView.FocusedRowHandle).ItemArray;
            //values[srcGridView.Columns["MIDX"].ColumnHandle] = posNo++;
            this.opsDataSet.OPH.Rows.Add(values);
            /*
            object id = dstGridView.GetFocusedRowCellValue("OPHID");
            DataView dv = new DataView(this.opsDataSet.OPH, "OPHID=" + id.ToString(), string.Empty, DataViewRowState.Deleted);
            if (dv.Count == 1) // We found the row, and it was DataViewRowState.Deleted
                dv[0].Row.RejectChanges(); // "UnDelete" it
            */
            dstGridView.DeleteRow(dstGridView.FocusedRowHandle);
        }

        private void upDst()
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = dstGridView;
            view.GridControl.Focus();
            int index = view.FocusedRowHandle;
            if (index <= 0) return;

            DataRow row1 = view.GetDataRow(index);
            DataRow row2 = view.GetDataRow(index - 1);
            object val1 = row1[OrderFieldName];
            object val2 = row2[OrderFieldName];
            row1[OrderFieldName] = val2;
            row2[OrderFieldName] = val1;

            view.FocusedRowHandle = index - 1;
        }
        
        private void downDst()
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = dstGridView;
            view.GridControl.Focus();
            int index = view.FocusedRowHandle;
            if (index < 0 || index >= view.DataRowCount - 1) return;

            DataRow row1 = view.GetDataRow(index);
            DataRow row2 = view.GetDataRow(index + 1);
            object val1 = row1[OrderFieldName];
            object val2 = row2[OrderFieldName];
            row1[OrderFieldName] = val2;
            row2[OrderFieldName] = val1;

            view.FocusedRowHandle = index + 1;
        }

        private void upDstSimpleButton_Click(object sender, EventArgs e)
        {
            upDst();
        }

        private void downDstSimpleButton_Click(object sender, EventArgs e)
        {
            downDst();
        }

        private void src2dstSimpleButton_Click(object sender, EventArgs e)
        {
            src2dst();
        }

        private void dst2srcSimpleButton_Click(object sender, EventArgs e)
        {
            dst2src();
        }

        private void opMasterLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sss = string.Empty;
            int? OPHid = null;
            int? Midx = null;

            DataView deleted = new DataView(dstTable, string.Empty, string.Empty, DataViewRowState.Deleted);
            for (int i=0; i < deleted.Count; i++)
            {
                // House'dan Masteri cikart
                // OPHID:House,OPMID:Null,MIDX:Null
                OPHid = (int)deleted[i].Row["OPHID", DataRowVersion.Original];
                opsQueriesTableAdapter.OPH_UPD_OPM("D", OPHid, null, null);
            }

            DataView modified = new DataView(dstTable, string.Empty, string.Empty, DataViewRowState.ModifiedCurrent);
            for (int i = 0; i < modified.Count; i++)
            {
                // OPHID:House,OPMID:Master,MIDX:mIndex
                sss = modified[i].Row["OPHID", DataRowVersion.Current].ToString();
                OPHid = (int)modified[i].Row["OPHID", DataRowVersion.Current];
                Midx = (int)modified[i].Row["MIDX", DataRowVersion.Current];
                opsQueriesTableAdapter.OPH_UPD_OPM("U", OPHid, opmRow.OPMID, Midx);
            }

            DataView added = new DataView(dstTable, string.Empty, string.Empty, DataViewRowState.Added);
            for (int i = 0; i < added.Count; i++)
            {
                OPHid = (int)added[i].Row["OPHID", DataRowVersion.Current];
                Midx = (int)added[i].Row["MIDX", DataRowVersion.Current];
                opsQueriesTableAdapter.OPH_UPD_OPM("I", OPHid, opmRow.OPMID, Midx);
            }
           
            /*
            //DataRowView
            DataView dv = new DataView(dstTable, string.Empty, string.Empty, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
            foreach (DataRowView rowView in dv)
            {
                sss = rowView.Row["OPHID", DataRowVersion.Original].ToString();
            }
            */
            //e.Cancel = true;
        }


    }
}
