using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace tMax14
{
    public partial class ButceForm : DevExpress.XtraEditors.XtraForm
    {
        public ButceForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fieldROT.FilterValues.Add("E");
            fieldROT.FilterValues.Add("I");
            fieldROT.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included;
            
            fieldMOT.FilterValues.Add("A");
            fieldMOT.FilterValues.Add("S");
            fieldMOT.FilterValues.Add("T");
            fieldMOT.FilterValues.Add("R");
            fieldMOT.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included;

            butceTableAdapter.Fill(mainDataSet.BUTCE, dateEdit1.DateTime, dateEdit2.DateTime);

        }

        private void pivotGridControl1_CustomUnboundFieldData(object sender, DevExpress.XtraPivotGrid.CustomFieldDataEventArgs e)
        {
            /*
            if (e.Field.FieldName == "BC")
            {
                decimal brc = Convert.ToDecimal(e.GetListSourceColumnValue("BRCR"));
                decimal chw = Convert.ToDecimal(e.GetListSourceColumnValue("CHW"));
                if (chw == 0)
                    chw = 1;
                //decimal discount = Convert.ToDecimal(e.GetListSourceColumnValue("Discount"));
                e.Value = brc / chw;
            }*/
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }

        private void pivotGridControl1_FieldAreaChanged(object sender, DevExpress.XtraPivotGrid.PivotFieldEventArgs e)
        {
            showCalcDep(e.Field.UnboundExpression);
            /*
            if (e.Field == pivotGridField1)
                if (e.Field.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea)
                {
                    showCalcDep(e.Field.UnboundExpression);
                    //if (fieldCHW1.Area != DevExpress.XtraPivotGrid.PivotArea.DataArea)
                    //    fieldCHW1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
                }*/
        }

        private void showCalcDep(string exp)
        {
            string token;
            MatchCollection matches = Regex.Matches(exp, @"\[\S+\]");
            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    token = match.ToString().Trim(new Char[] { '[', ']' });
                    pivotGridControl1.Fields[token].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
                }
            }
        }

        private void pivotGridControl1_FieldUnboundExpressionChanged(object sender, DevExpress.XtraPivotGrid.PivotFieldEventArgs e)
        {
            showCalcDep(e.Field.UnboundExpression);
            e.Field.Caption = e.Field.UnboundExpression.Replace("field", "");
        }

        private void saveLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MF.XGLsave("ButceForm", 0, pivotGridControl1);

            //pivotGridControl1.SaveLayoutToXml(@"C:\deneme.xml");
        }

        private void restoreLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MF.XGLrestore("ButceForm", 0, pivotGridControl1);
            //pivotGridControl1.RestoreLayoutFromXml(@"C:\deneme.xml");

        }
    }
}
