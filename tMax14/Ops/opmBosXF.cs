using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tMax14.Ops
{
    public partial class opmBosXF : DevExpress.XtraEditors.XtraForm
    {
        public int opmID;

        public opmBosXF()
        {
            InitializeComponent();

            vGridControl1.ExternalRepository = Program.MF.mainPersistentRepository;
            rowPSTU.Properties.RowEdit = Program.MF.OpsStuPrbRepositoryItemLookUpEdit;
            rowETD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowETA.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowATD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowATA.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowWBD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowPOD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowRTR.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowRTD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowROH.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowAOC.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowTPAD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowTPDD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowTPAD2.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowTPDD2.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowOBTT.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowRETA.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowRETD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowLCD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
        }

        private void opmBosXF_Load(object sender, EventArgs e)
        {
            opmBosSelTableAdapter.Fill(opsDataSet.OPM_BOS_SEL, opmID);
            int nor = oppBosSelTableAdapter.Fill(opsDataSet.OPP_BOS_SEL, opmID);

            OpsDataSet.OPM_BOS_SELRow row = (OpsDataSet.OPM_BOS_SELRow)opsDataSet.OPM_BOS_SEL.Rows[0];
            string E = row.EDITABLE;
            string CN;
            // Bos ise herzaman degisebilir
            // Doluysa E='T' ise degisebilir

            for (int i = 0; i < opsDataSet.OPM_BOS_SEL.Columns.Count; i++)
            {
                if (row[i] != DBNull.Value)
                {
                    opsDataSet.OPM_BOS_SEL.Columns[i].ReadOnly = true;

                    if (E == "T")
                    {
                        CN = opsDataSet.OPM_BOS_SEL.Columns[i].ColumnName;
                        if (CN == "PSTU" || CN == "POD" || CN == "ETA" || CN == "TRI")
                            opsDataSet.OPM_BOS_SEL.Columns[i].ReadOnly = false;
                    }
                }
            }
        }

        private void saveSimpleButton_Click(object sender, EventArgs e)
        {
            opmBosSelTableAdapter.Update(opsDataSet.OPM_BOS_SEL);
            oppBosSelTableAdapter.Update(opsDataSet.OPP_BOS_SEL);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void oppGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (oppGridView.GetFocusedRowCellDisplayText(colEDITABLE) == "F")
                e.Cancel = true;
        }
    }
}
