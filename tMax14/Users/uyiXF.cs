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
    public partial class uyiXF : DevExpress.XtraEditors.XtraForm
    {
        public uyiXF()
        {
            InitializeComponent();

            //uspSelTreeList.ExternalRepository = Program.MF.mainPersistentRepository;
            //colENT.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            //colMDF.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
        }

        private void uYIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uyiBindingSource.EndEdit();
            this.uyiTableAdapter.Update(this.usersDataSet);

        }

        private void uyiXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.UYI' table. You can move, or remove it, as needed.
            this.uyiTableAdapter.Fill(this.usersDataSet.UYI);

        }

        private void uspSelTreeList_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (uyıTreeList.FocusedNode.GetValue(colTYP).ToString() == "Y")
                e.Cancel = true;

            if (uyıTreeList.FocusedColumn == colMDF)
            {
                if (uyıTreeList.FocusedNode.GetValue(colTYP).ToString() == "M")
                    e.Cancel = true;
            }
        }
    }
}