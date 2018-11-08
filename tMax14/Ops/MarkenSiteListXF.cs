using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ExcelDataReader;
using System.IO;
using System.Globalization;

namespace tMax14.Ops
{
    public partial class MarkenSiteListXF : DevExpress.XtraEditors.XtraForm
    {
        IExcelDataReader excelReader;
        DataSet result;
        
        public MarkenSiteListXF()
        {
            InitializeComponent();

        }

        private void MarkenSiteListXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'opsDataSet.ZMSL' table. You can move, or remove it, as needed.
            this.zmslTableAdapter.Fill(this.opsDataSet.ZMSL);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opsQueriesTableAdapter.ZMSL_DELETE_ALL();
            this.zmslTableAdapter.Update(this.opsDataSet.ZMSL);
        }

        private void newListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

                var ext = Path.GetExtension(openFileDialog.FileName);
                if (ext == ".xls")
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                else if (ext == ".xlsx")
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                if (excelReader == null) // || !excelReader.IsValid)
                {
                    MessageBox.Show("Selected file is not valid Excel file");
                    return;
                }
                /*
                excelReader.IsFirstRowAsColumnNames = true;
                result = excelReader.AsDataSet();
                mslGridControl.DataSource = result.Tables[0];
                mslGridView.OptionsView.ColumnAutoWidth = false;
                */

                CultureInfo culture = new CultureInfo("en-US");
                this.opsDataSet.ZMSL.Clear();
                int i = 0;
                excelReader.Read();
                while (excelReader.Read())
                {
                    i++;
                    OpsDataSet.ZMSLRow row = opsDataSet.ZMSL.NewZMSLRow();
                    //row.ID = i++;
                    // var bbb = excelReader.GetOrdinal("Template"); Calismiyor
                    row.TEMPLATE = excelReader.GetString(0);
                    //var aaa = excelReader.GetString(1);
                    //var ccc = Convert.ToDateTime(excelReader.GetValue(1), culture);
                    //var bbb = excelReader.GetDateTime(1);
                    row.LOADINGDATE = Convert.ToDateTime(excelReader.GetValue(1), culture); //excelReader.GetDateTime(1); //.ToString();  //Convert.ToDateTime(excelReader.GetString(1).Substring(0, 10));
                    //if (excelReader.GetValue(1).GetType().Name != "DateTime")
                    //    MessageBox.Show(excelReader.GetValue(1).GetType().Name);
                    //row.Status = excelReader.GetString(2);
                    row.PROTOCOL = excelReader.GetString(3);
                    row.SPONSOR = excelReader.GetString(4);
                    row.STUDY = excelReader.GetString(5);
                    row.SITE = excelReader.GetString(6);
                    row.CONSIGNEENAME = excelReader.GetString(18);
                    row.PICKUPNAME = excelReader.GetString(50);
                    row.PICKUPCOMPANY = excelReader.GetString(51);
                    row.PICKUPDEPARTMENT = excelReader.GetString(52);
                    row.PICKUPCITY = excelReader.GetString(55);
                    row.PICKUPPHONE = excelReader.GetString(59);

                    opsDataSet.ZMSL.AddZMSLRow(row);
                }
                excelReader.Close();
            }
        }
    }
}