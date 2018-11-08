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
    public partial class ophBosXF : DevExpress.XtraEditors.XtraForm
    {
        public int ophID;

        public ophBosXF()
        {
            InitializeComponent();

            vGridControl1.ExternalRepository = Program.MF.mainPersistentRepository;
            rowPSTU.Properties.RowEdit = Program.MF.OpsStuPrbRepositoryItemLookUpEdit;
            rowMALBDLDVZ.Properties.RowEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            rowPOD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowROH.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowAOH.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowRTR.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowDRBD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowDRCD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowDPOGIRTRH.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowDPOCIKTRH.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowCRRID.Properties.RowEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            rowDLVID.Properties.RowEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            rowARP.Properties.RowEdit = Program.MF.TFrepositoryItemCheckEdit;

            rowRTD.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
            rowAOC.Properties.RowEdit = Program.MF.TSrepositoryItemDateEdit;
        }

        private void ophBosXF_Load(object sender, EventArgs e)
        {
            ophBosSelTableAdapter.Fill(opsDataSet.OPH_BOS_SEL, ophID);

            OpsDataSet.OPH_BOS_SELRow row = (OpsDataSet.OPH_BOS_SELRow)opsDataSet.OPH_BOS_SEL.Rows[0];
            
            string E = row.EDITABLE;
            string CN;
            // Bos ise herzaman degisebilir
            // Doluysa E='T' ise degisebilir

            for (int i = 0; i < opsDataSet.OPH_BOS_SEL.Columns.Count; i++)
            {
                if (row[i] != DBNull.Value)
                {
                    opsDataSet.OPH_BOS_SEL.Columns[i].ReadOnly = true;
                    
                    if (E == "T") 
                    {
                        CN = opsDataSet.OPH_BOS_SEL.Columns[i].ColumnName;
                        if ( CN == "PSTU" || CN == "POD")
                            opsDataSet.OPH_BOS_SEL.Columns[i].ReadOnly = false;
                    }
                }
            }
        }

        private void saveSimpleButton_Click(object sender, EventArgs e)
        {
            ophBosSelTableAdapter.Update(opsDataSet.OPH_BOS_SEL);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
