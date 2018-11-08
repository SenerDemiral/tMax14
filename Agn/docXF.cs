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
using System.IO;

namespace Agn
{
    public partial class docXF : DevExpress.XtraEditors.XtraForm
    {
        public string qry = "";
        string docDir = @"C:\SOS\DOCs";

        public docXF()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory(docDir);
        }

        private void docXF_Load(object sender, EventArgs e)
        {
            this.wAN_AGN_DOC_SELTableAdapter.Fill(this.agnDataSet.WAN_AGN_DOC_SEL, qry);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = docSelGridView;
            if (view.GetFocusedRowCellValue(colTYP) != DBNull.Value && view.GetFocusedRowCellValue(colTYP).ToString() != ".")
            {
                int docID = (int)view.GetFocusedRowCellValue(colDOCID);
                string fullfileName = docDir + @"\" + view.GetFocusedRowCellValue(colAD).ToString() + view.GetFocusedRowCellValue(colTYP).ToString();

                downLoadFile(docID, fullfileName);

                var proc = System.Diagnostics.Process.Start(fullfileName);
            }
        }

        private void downLoadFile(int docID, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] img = new byte[0];
            img = (byte[])agnQueriesTableAdapter.WAN_AGN_DOC_SEL_BLB(docID);
            int ArraySize = new int();
            ArraySize = img.GetLength(0);
            fs.Write(img, 0, ArraySize);
            fs.Close();
        }


    }
}