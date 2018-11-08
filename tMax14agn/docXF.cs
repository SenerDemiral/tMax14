using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tMax14agn
{
    public partial class docXF : DevExpress.XtraEditors.XtraUserControl
    {
        public string iQry;
        
        public docXF()
        {
            InitializeComponent();
        }

        private void docGridControl_Load(object sender, EventArgs e)
        {
            try
            {
                this.docTableAdapter.Fill(this.dataSet.DOC, iQry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void openAttachment()
        {
            if (docGridView.GetFocusedRowCellValue(colTYP) != DBNull.Value && docGridView.GetFocusedRowCellValue(colTYP).ToString() != ".")
            {
                int docID = (int)docGridView.GetFocusedRowCellValue(colDOCID);
                string fullfileName = string.Format("{0}{1}{2}", Path.GetTempPath(), docGridView.GetFocusedRowCellValue(colDOCID), docGridView.GetFocusedRowCellValue(colTYP));
                
                if (downLoadFile(docID, fullfileName))
                {
                    var proc = System.Diagnostics.Process.Start(fullfileName);
                }
            }
        }

        private bool downLoadFile(int docID, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] img = new byte[0];
            img = (byte[])queriesTableAdapter.WAN_AGN_DOC_SEL_BLB(docID);
            if (img != null)
            {
                int ArraySize = new int();
                ArraySize = img.GetLength(0);
                fs.Write(img, 0, ArraySize);
                fs.Close();
                return true;
            }
            return false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAttachment();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!docGridView.IsEmpty && docGridView.GetFocusedRowCellValue(colTYP) != DBNull.Value && docGridView.GetFocusedRowCellValue(colTYP).ToString() != ".")
            {
                int docID = (int)docGridView.GetFocusedRowCellValue(colDOCID);
                saveFileDialog.FileName = docGridView.GetFocusedRowCellDisplayText(colAD) + docGridView.GetFocusedRowCellDisplayText(colTYP);
                saveFileDialog.InitialDirectory = @"\\tsclient\C";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    downLoadFile(docID, saveFileDialog.FileName);
                    MessageBox.Show("Saved : " + saveFileDialog.FileName);
                }
            }
        }

    }
}
