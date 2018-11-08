using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace tMax14.Genel
{
    public partial class rptdXF : DevExpress.XtraEditors.XtraForm
    {
        public int RPTid;

        public rptdXF()
        {
            InitializeComponent();
        }

        private void rptdXF_Load(object sender, EventArgs e)
        {
            this.rpdtTableAdapter.Fill(this.genelDataSet.RPTD, RPTid);
        }

        private void rPTDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.rptdBindingSource.EndEdit();
            ClearEmptyTRF();
            this.rpdtTableAdapter.Update(this.genelDataSet.RPTD);

        }

        private void richEditControl1_DocumentLoaded(object sender, EventArgs e)
        {
            var rec = sender as DevExpress.XtraRichEdit.RichEditControl;
            rec.Document.DefaultCharacterProperties.FontName = "Tahoma";
            rec.Document.DefaultCharacterProperties.FontSize = 10;
        }

        private void ClearEmptyTRF()
        {
            
            RichEditControl rec = new RichEditControl();
            for (int i = 0; i < this.genelDataSet.RPTD.Rows.Count; i++)
            {

                if (this.genelDataSet.RPTD.Rows[i]["DTYNOT"] != DBNull.Value)
                {
                    rec.RtfText = this.genelDataSet.RPTD.Rows[i]["DTYNOT"].ToString();
                    if (string.IsNullOrWhiteSpace(rec.Text))
                        this.genelDataSet.RPTD.Rows[i]["DTYNOT"] = DBNull.Value;
                }
            }
        }

        private void rptdGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            rptdGridView.SetRowCellValue(e.RowHandle, colRPTID, RPTid);
            rptdGridView.SetRowCellValue(e.RowHandle, colDKEY2, "");
            rptdGridView.SetRowCellValue(e.RowHandle, colDVAL2, "");
        }
    }
}