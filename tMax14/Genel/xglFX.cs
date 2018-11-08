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

namespace tMax14.Genel
{
    public partial class xglFX : DevExpress.XtraEditors.XtraForm
    {
        public string id = "";
        public object origin;
        string layout;

        public xglFX()
        {
            InitializeComponent();
        }

        private void xGL_SELBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xglSelBindingSource.EndEdit();
            this.xglSelTableAdapter.Update(this.genelDataSet.XGL_SEL);
        }

        private void xglGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            xglGridView.SetRowCellValue(e.RowHandle, colUSR, Program.USR);
            xglGridView.SetRowCellValue(e.RowHandle, colID,  id);
            xglGridView.SetRowCellValue(e.RowHandle, colLAYOUT, originLayout());
            //setToolStripMenuItem.PerformClick();
        }

        private void xglFX_Load(object sender, EventArgs e)
        {
            int nor = this.xglSelTableAdapter.Fill(this.genelDataSet.XGL_SEL, Program.USR, id);

            //MessageBox.Show(string.Format("nor:{0} Usr:{1} Id:{2}", nor, Program.USR, id));
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (origin is DevExpress.XtraPivotGrid.PivotGridControl)
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(xglGridView.GetFocusedRowCellDisplayText(colLAYOUT));
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                (origin as DevExpress.XtraPivotGrid.PivotGridControl).RestoreLayoutFromStream(stream);
                stream.Close();
            }
            if (origin is DevExpress.XtraGrid.Views.Grid.GridView)
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(xglGridView.GetFocusedRowCellDisplayText(colLAYOUT));
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                (origin as DevExpress.XtraGrid.Views.Grid.GridView).RestoreLayoutFromStream(stream);
                stream.Close();
            }

            if (origin is DevExpress.XtraGrid.GridControl)
            {
                foreach (GridView view in (origin as DevExpress.XtraGrid.GridControl).ViewCollection)
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(xglGridView.GetFocusedRowCellDisplayText(colLAYOUT));
                    System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                    stream.Seek(0, System.IO.SeekOrigin.Begin);
                    view.RestoreLayoutFromStream(stream);
                    stream.Close();
                }
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xglGridView.SetFocusedRowCellValue(colLAYOUT, originLayout());
            xGL_SELBindingNavigatorSaveItem.PerformClick(); // Save
        }


        private string originLayout()
        {
            System.IO.Stream str = new System.IO.MemoryStream();

            if (origin is DevExpress.XtraPivotGrid.PivotGridControl)
                (origin as DevExpress.XtraPivotGrid.PivotGridControl).SaveLayoutToStream(str);
            else if (origin is DevExpress.XtraGrid.Views.Grid.GridView)
                (origin as DevExpress.XtraGrid.Views.Grid.GridView).SaveLayoutToStream(str);

            str.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamReader reader = new System.IO.StreamReader(str);

            layout = reader.ReadToEnd();

            str.Close();

            return layout;
        }
    }
}