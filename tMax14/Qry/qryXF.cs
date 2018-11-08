using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Qry
{
    public partial class qryXF : DevExpress.XtraEditors.XtraForm
    {
        public string TBL = string.Empty;
        
        public qryXF()
        {
            InitializeComponent();
        }

        public void Save()
        {
            this.Validate();
            this.qRYBindingSource.EndEdit();
            this.qRYTableAdapter.Update(this.qryDataSet.QRY);

        }

        private void qryXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.qRYTableAdapter.FillByTBL(this.qryDataSet.QRY, TBL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            Program.MF.GridControlSettings(qryGridControl);
        }

        private void qryGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            qryGridView.SetRowCellValue(e.RowHandle, colQRYID, Program.MF.mainQueriesTableAdapter.GET_PK("QRY"));
            qryGridView.SetRowCellValue(e.RowHandle, colTBL, TBL);
        }

        private void qryXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }
    }
}