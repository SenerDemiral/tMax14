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
    public partial class EtaFisAcilisXF : DevExpress.XtraEditors.XtraForm
    {
        bool OK = true;
        StringBuilder sbXML = new StringBuilder();

        public EtaFisAcilisXF()
        {
            InitializeComponent();
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                this.etaFisAcilisTableAdapter.Fill(this.acccountEtaDataSet.ETA_FIS_ACILIS, dateEdit2.DateTime);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            sbXML.Clear();
            sbXML.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            sbXML.AppendLine("<MUHASEBE>");
            sbXML.AppendLine("<FIS>");
            //sbXML.AppendLine("<MUHASEBE xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");

            foreach (AcccountEtaDataSet.ETA_FIS_ACILISRow row in this.acccountEtaDataSet.ETA_FIS_ACILIS.Rows)
            {
                if (!row.IsXMLNull())
                    sbXML.Append(row.XML);
            }

            sbXML.AppendLine("</FIS>");
            sbXML.Append("</MUHASEBE>");

            //create a random temporary file with an .xml file extension
            var path = Path.GetTempPath();
            var fileName = Guid.NewGuid().ToString() + ".xml";
            var fullFileName = Path.Combine(path, fileName);
            File.WriteAllText(fullFileName, sbXML.ToString());
            webBrowser1.Navigate(fullFileName);

            exportSimpleButton.Enabled = OK;
            Cursor = Cursors.Default;

        }

        private void exportSimpleButton_Click(object sender, EventArgs e)
        {
            string fileName = string.Format(@"C:\ETA-FisAcilis-{0:yyyy-MM-dd-HH-mm}.xml", DateTime.Now);

            System.IO.File.WriteAllText(fileName, sbXML.ToString(), Encoding.UTF8);
            XtraMessageBox.Show("Dosya: " + fileName, "Açılış Fiş Export ETA");
        }
    }
}