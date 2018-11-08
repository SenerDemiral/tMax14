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

namespace tMax14.Users
{
    public partial class uspXF : DevExpress.XtraEditors.XtraForm
    {
        public uspXF()
        {
            InitializeComponent();

            uspTreeList.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDS.ColumnEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;
            //colENT.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            //colMDF.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
        }

        private void uSP_SELBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uspBindingSource.EndEdit();
            this.uspTableAdapter.Update(this.usersDataSet);

        }

        private void uspXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.USP_SEL' table. You can move, or remove it, as needed.
            this.uspTableAdapter.Fill(this.usersDataSet.USP_SEL);
            uspTreeList.OptionsBehavior.Editable = Program.MF.ModifyCheck("Users.uspXF", isSilent: true);

        }

        private void uspSelTreeList_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (uspTreeList.FocusedNode.GetValue(colTYP).ToString() == "U")
                e.Cancel = true;

            if (uspTreeList.FocusedColumn == colMDF)
            {
                if (uspTreeList.FocusedNode.GetValue(colTYP).ToString() == "M")
                    e.Cancel = true;
            }
        }
    }
}