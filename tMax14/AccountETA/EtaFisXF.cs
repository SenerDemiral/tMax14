using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace tMax14.AccountETA
{
    public partial class EtaFisXF : DevExpress.XtraEditors.XtraForm
    {
        bool OK = true;
        StringBuilder sbXML = new StringBuilder();

        public EtaFisXF()
        {
            InitializeComponent();
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                this.etaFisTableAdapter.Fill(this.acccountEtaDataSet.ETA_FIS, dateEdit1.DateTime, dateEdit2.DateTime);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            // Set OK T/F
            OK = true;
            foreach (AcccountEtaDataSet.ETA_FISRow row in this.acccountEtaDataSet.ETA_FIS.Rows)
            {
                if (row.OK == "F")
                {
                    OK = false;
                    this.acccountEtaDataSet.ETA_FIS.FindByAVBIDAVDID(row.AVBID, 0).OK = "F";
                }
            }
            // Hata varsa ilk kayitda da belirt
            if (!OK)
                this.acccountEtaDataSet.ETA_FIS.FindByAVBIDAVDID(0, 0).OK = "F";

            sbXML.Clear();
            
            if (OK)
            {
                foreach (AcccountEtaDataSet.ETA_FISRow row in this.acccountEtaDataSet.ETA_FIS.Rows)
                {
                    if (!row.IsXMLNull())
                        sbXML.Append(row.XML);
                }
                //create a random temporary file with an .xml file extension
                var path = Path.GetTempPath();
                var fileName = Guid.NewGuid().ToString() + ".xml";
                var fullFileName = Path.Combine(path, fileName);
                File.WriteAllText(fullFileName, sbXML.ToString());
                webBrowser1.Navigate(fullFileName);
            }

            exportSimpleButton.Enabled = OK;
            Cursor = Cursors.Default;
        }

        private void exportSimpleButton_Click(object sender, EventArgs e)
        {
            //string fileName = string.Format(@"C:\ETA-Fis-{0:yyyy-MM}.xml", dateEdit1.DateTime);
            System.IO.Directory.CreateDirectory(@"C:\tMax2ETA");    //Create Dir if not exists
            string fileName = string.Format(@"C:\tMax2ETA\ETA-Fis-{0:yyyy-MM-dd-HH-mm}.xml", DateTime.Now);

            System.IO.File.WriteAllText(fileName, sbXML.ToString(), Encoding.UTF8);
            XtraMessageBox.Show("Dosya: " + fileName, "Fiş Export ETA");

        }
    }
}