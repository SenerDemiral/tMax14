using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using FirebirdSql.Data.FirebirdClient;
using System.Text.RegularExpressions;

namespace tMax14.Qry
{
    public partial class qryPrmsForm : DevExpress.XtraEditors.XtraForm
    {
        //public FbCommand fbCommand = new FbCommand();
        private string prmStr;
        public string TBL = string.Empty;

        public string getPrmStr()
        {
            return prmStr;
        }

        public string getQryNme()
        {
            return qryGridView.GetFocusedRowCellDisplayText(colAD);
        }

        public qryPrmsForm()
        {
            InitializeComponent();
        }

        private void qryPrmsForm_Load(object sender, EventArgs e)
        {
            vGridControl1.Rows.Clear();
            this.qRYTableAdapter.FillByTBL(this.qryDataSet.QRY, TBL);

            //parse();
        }

        private void qryGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            prmStr = string.Empty;
            if (qryGridView.DataRowCount == 0 || qryGridView.FocusedRowHandle < 0)
                return;

            parse(qryGridView.GetFocusedRowCellDisplayText(colWHR));
        }

        public void parse(string srcTxt)
        {
            string uct;
            string[] sa = new string[100];
            srcTxt = Regex.Replace(srcTxt, @"\s+", " ");

            //MessageBox.Show(srcTxt);
            
            sa = Regex.Split(srcTxt, @"( )|(,)|(\*)|(=)|(>)|(<)|(\()|(\))");
            vGridControl1.Rows.Clear();
            //dt = new DataTable();

            for (int i = 0; i < sa.Length; i++)
            {
                if (sa[i].StartsWith("@"))
                {
                    //ColumnType ara @param/ColumnType/DefaultValue
                    string[] ct = sa[i].Split(new Char[] { '/' });
                    if (ct.Length == 1)
                        uct = "S";
                    else 
                    {
                        uct = ct[1];
                        sa[i] = ct[0];
                    }

                    DevExpress.XtraVerticalGrid.Rows.EditorRow vr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
                    vr.Name = ct[0];
                    vr.Tag = uct;
                    vr.Appearance.Options.UseTextOptions = true; 
                    switch (uct)
                    {
                        case "D":
                            vr.Properties.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
                            vr.Properties.RowEdit = dateRepositoryItemDateEdit;
                            
                            break;
                        case "T":
                            vr.Properties.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
                            vr.Properties.RowEdit = timeRepositoryItemDateEdit;
                            break;
                        case "DT":
                            vr.Properties.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
                            vr.Properties.RowEdit = dateTimeRepositoryItemDateEdit;
                            break;
                        case "I":
                            vr.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
                            vr.Properties.RowEdit = intRepositoryItemTextEdit;
                            vr.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                            break;
                        case "N":
                            vr.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                            vr.Properties.RowEdit = decimalRepositoryItemTextEdit;
                            break;
                        default:
                            vr.Properties.UnboundType = DevExpress.Data.UnboundColumnType.String;
                            //vr.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                            break;

                    }
                    if (ct.Length == 3)
                        vr.Properties.Value = ct[2];    //DefaultValue
                    //vr.Properties.Caption = ct[0] + " " + sa[i - 4] + sa[i - 2] + " " + vr.Properties.UnboundType.ToString();
                    vr.Properties.Caption = ct[0] + " " + sa[i - 3] + sa[i - 2] + sa[i - 1];
                    vr.Properties.ToolTip = sa[i - 3] + sa[i - 2] + sa[i - 1] + " " + vr.Properties.UnboundType.ToString();
                    vGridControl1.Rows.Add(vr);
                }
            }
            
            StringBuilder sb = new StringBuilder();

            foreach (string s in sa)
            {
                sb.Append(s);
            }
            prmStr = sb.ToString();
            //if (vGridControl1.Rows.Count == 0)
            //    OKsimpleButton.PerformClick();
        }

        public string prepareQryStr()
        {
            // cmndTxt : MOT = @MOT and ROT = @ROT gibi gelir
            string qryStr = prmStr;

            for (int i = 0; i < vGridControl1.Rows.Count; i++)
            {
                FbParameter fbp = new FbParameter();

                string name = vGridControl1.Rows[i].Name;//vGridControl1.Rows[i].Properties.Caption;
                object value = vGridControl1.Rows[i].Properties.Value;
                string valueStr = "";

                if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    MessageBox.Show("Değer boş olamaz");
                    return "";
                }
                else
                    switch (vGridControl1.Rows[i].Tag.ToString())
                    {
                        case "S":
                            valueStr = string.Format("'{0}'", value);
                            break;
                        case "I":
                            valueStr = string.Format("{0}", value);
                            break;
                        case "N":
                            valueStr = string.Format("{0}", value);
                            break;
                        case "D":
                            valueStr = string.Format("'{0:dd.MM.yyyy}'", value);
                            break;
                        case "T":
                            valueStr = string.Format("'{0:HH:mm:ss}'", value);
                            break;
                        case "DT":
                            valueStr = string.Format("'{0:dd.MM.yyyy HH:mm:ss}'", value);
                            break;
                    }

                qryStr = qryStr.Replace(name, valueStr);
            }
            return qryStr;
        }

        private void prepareCommand(FbCommand fbCommand, string dstTxt)
        {
            fbCommand.Parameters.Clear();
            fbCommand.CommandText = dstTxt;

            if (string.IsNullOrWhiteSpace(fbCommand.CommandText))
                fbCommand.CommandText = "LM_TS > @LM_TS";
            else
                fbCommand.CommandText += " and LM_TS > @LM_TS";

            FbParameter dfbp = new FbParameter();   // Default param
            dfbp.ParameterName = "@LM_TS";
            dfbp.FbDbType = FbDbType.TimeStamp;
            dfbp.Value = DateTime.MinValue;
            fbCommand.Parameters.Add(dfbp);

            for (int i = 0; i < vGridControl1.Rows.Count; i++)
            {
                FbParameter fbp = new FbParameter();

                fbp.ParameterName = vGridControl1.Rows[i].Name;//vGridControl1.Rows[i].Properties.Caption;
                fbp.Value = vGridControl1.Rows[i].Properties.Value;
                if (fbp.Value != DBNull.Value && fbp.Value.ToString() == "")
                    fbp.Value = DBNull.Value;

                if (fbp.Value == DBNull.Value)
                    MessageBox.Show("DBNull");    // Deger girilmediginde null
                if (fbp.Value == null)
                    MessageBox.Show("Null");

                switch (vGridControl1.Rows[i].Tag.ToString())
                {
                    case "S":
                        fbp.FbDbType = FbDbType.VarChar;
                        break;
                    case "I":
                        fbp.FbDbType = FbDbType.Integer;
                        break;
                    case "N":
                        fbp.FbDbType = FbDbType.Numeric;
                        break;
                    case "D":
                        fbp.FbDbType = FbDbType.Date;
                        break;
                    case "T":
                        fbp.FbDbType = FbDbType.Time;
                        break;
                    case "DT":
                        fbp.FbDbType = FbDbType.TimeStamp;
                        break;
                }
                fbCommand.Parameters.Add(fbp);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void qRYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qRYBindingSource.EndEdit();
            this.qRYTableAdapter.Update(this.qryDataSet.QRY);
        }

        public void doQry(DataTable dataTable, FbCommand fbCommand, string dstTxt)
        {
            Program.MF.startSW();
            int nor = 0;
            Cursor.Current = Cursors.WaitCursor;
            prepareCommand(fbCommand, dstTxt);

            StringBuilder columns = new StringBuilder();
            foreach (DataColumn dc in dataTable.Columns)
            {
                if (columns.Length > 0)
                    columns.Append(",");
                columns.Append(dc.ColumnName);
            }

            fbCommand.CommandText = "SELECT " + columns.ToString() + " FROM " + dataTable.TableName + " WHERE " + fbCommand.CommandText;

            FbConnection c = new FbConnection(Properties.Settings.Default.ConnectionString);
            c.Open();
            FbTransaction trans = c.BeginTransaction();
            try
            {
                fbCommand.CommandType = CommandType.Text;
                fbCommand.Connection = c;
                fbCommand.Transaction = trans;

                FbDataAdapter fbDataAdapter = new FbDataAdapter();
                fbDataAdapter.SelectCommand = fbCommand;
                nor = fbDataAdapter.Fill(dataTable);

                trans.Commit();
                fbCommand.Parameters["@LM_TS"].Value = (DateTime)Program.MF.mainQueriesTableAdapter.GET_SERVERTIME();
                //Program.MF.Text = nor.ToString() + " firstread  " + fbCommand.Parameters["@LM_TS"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
            finally
            {
                c.Close();
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Query", nor);
            }

        }
        public void doQry(string tblName, DataTable dataTable, FbCommand fbCommand, string dstTxt)
        {
            Program.MF.startSW();
            int nor = 0;
            Cursor.Current = Cursors.WaitCursor;
            prepareCommand(fbCommand, dstTxt);

            StringBuilder columns = new StringBuilder();
            foreach (DataColumn dc in dataTable.Columns)
            {
                if (columns.Length > 0)
                    columns.Append(",");
                columns.Append(dc.ColumnName);
            }

            fbCommand.CommandText = "SELECT " + columns.ToString() + " FROM " + tblName + " WHERE " + fbCommand.CommandText;

            FbConnection c = new FbConnection(Properties.Settings.Default.ConnectionString);
            c.Open();
            FbTransaction trans = c.BeginTransaction();
            try
            {
                fbCommand.CommandType = CommandType.Text;
                fbCommand.Connection = c;
                fbCommand.Transaction = trans;

                FbDataAdapter fbDataAdapter = new FbDataAdapter();
                fbDataAdapter.SelectCommand = fbCommand;
                nor = fbDataAdapter.Fill(dataTable);

                trans.Commit();
                fbCommand.Parameters["@LM_TS"].Value = (DateTime)Program.MF.mainQueriesTableAdapter.GET_SERVERTIME();
                //Program.MF.Text = nor.ToString() + " firstread  " + fbCommand.Parameters["@LM_TS"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
            finally
            {
                c.Close();
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Query", nor);
            }

        }

        public void reQry(DataTable dataTable, FbCommand fbCommand)
        {
            Program.MF.startSW();
            int nor = 0;
            Cursor.Current = Cursors.WaitCursor;

            FbConnection c = new FbConnection(Properties.Settings.Default.ConnectionString);
            c.Open();
            FbTransaction trans = c.BeginTransaction();
            try
            {
                fbCommand.CommandType = CommandType.Text;
                fbCommand.Connection = c;
                fbCommand.Transaction = trans;

                FbDataAdapter fbDataAdapter = new FbDataAdapter();
                fbDataAdapter.SelectCommand = fbCommand;
                nor = fbDataAdapter.Fill(dataTable);

                trans.Commit();
                fbCommand.Parameters["@LM_TS"].Value = (DateTime)Program.MF.mainQueriesTableAdapter.GET_SERVERTIME();
                //Program.MF.Text = nor.ToString() + " reread  " + fbCommand.Parameters["@LM_TS"].Value.ToString() + "  " + fbCommand.CommandText;
            }
            catch
            {
                trans.Rollback();
            }
            finally
            {
                c.Close();
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Query", nor);
            }

        }

        private void editQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qry.qryXF frm = new qryXF();
            frm.TBL = TBL;
            frm.ShowDialog();
            frm.Dispose();
            vGridControl1.Rows.Clear();
            this.qRYTableAdapter.FillByTBL(this.qryDataSet.QRY, TBL);
        }

    }
}