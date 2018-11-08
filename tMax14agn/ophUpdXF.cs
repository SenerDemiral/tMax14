using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14agn
{
    public partial class ophUpdXF : DevExpress.XtraEditors.XtraForm
    {
        public int ophID;

        public ophUpdXF()
        {
            InitializeComponent();

            vGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            rowNSTU.Properties.RowEdit = Program.MF.OPSTNrepositoryItemLookUpEdit;
            rowPSTU.Properties.RowEdit = Program.MF.OPSTPrepositoryItemLookUpEdit;
        }

        private void ophUpdXF_Load(object sender, EventArgs e)
        {
            wAN_AGN_OPH_UPD_SELTableAdapter.Fill(dataSet.WAN_AGN_OPH_UPD_SEL, ophID);

            var view = vGridControl;
            string fn;
            for (int i = 0; i < view.Rows.Count; i++)
            {
                fn = view.Rows[i].Properties.FieldName;
                if (fn.StartsWith("E_"))
                {
                    var e_row = view.GetRowByFieldName(fn);
                    var e_rowVal = view.GetCellValue(e_row, view.FocusedRecord);
                    if (e_rowVal.ToString() == "F")
                    {
                        var row = view.GetRowByFieldName(fn.Substring(2));
                        row.Properties.ReadOnly = true;
                    }
                }
            }
        }

        private void updateSimpleButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wANAGNOPHUPDSELBindingSource.EndEdit();
            if (this.dataSet.HasChanges())
            {
                wAN_AGN_OPH_UPD_SELTableAdapter.Update(this.dataSet.WAN_AGN_OPH_UPD_SEL);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}