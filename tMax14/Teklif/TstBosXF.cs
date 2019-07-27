using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Teklif
{
    public partial class TstBosXF : DevExpress.XtraEditors.XtraForm
    {
        public int tstID = 0;

        public TstBosXF()
        {
            InitializeComponent();
            vGridControl1.ExternalRepository = Program.MF.mainPersistentRepository;
            rowRFSTYP.Properties.RowEdit = Program.MF.TstRfsTypRositoryItemLookUpEdit;
        }

        private void TstBosXF_Load(object sender, EventArgs e)
        {
            tstBosSelTableAdapter.Fill(teklifDataSet.TST_BOS_SEL, tstID, Program.USR);

            TeklifDataSet.TST_BOS_SELRow row = (TeklifDataSet.TST_BOS_SELRow)teklifDataSet.TST_BOS_SEL.Rows[0];

            string E = row.EDITABLE;
            // E='T' ise degisebilir

            for (int i = 0; i < teklifDataSet.TST_BOS_SEL.Columns.Count; i++)
            {
                teklifDataSet.TST_BOS_SEL.Columns[i].ReadOnly = true;
                if (E == "T")
                {
                    teklifDataSet.TST_BOS_SEL.Columns[i].ReadOnly = false;
                }
            }
        }

        private void kaydetSimpleButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tstBosSelBindingSource.EndEdit();
            tstBosSelTableAdapter.Update(teklifDataSet.TST_BOS_SEL);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}