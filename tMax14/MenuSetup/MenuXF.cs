using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;

namespace tMax14.MenuSetup
{
    public partial class MenuXF : DevExpress.XtraEditors.XtraForm
    {
        public MenuXF()
        {
            InitializeComponent();
        }

        private void MenuXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menuSetupDataSet.MNU' table. You can move, or remove it, as needed.
            this.mnuTableAdapter.Fill(this.menuSetupDataSet.MNU);

        }

        private void treeList1_BeforeDragNode(object sender, DevExpress.XtraTreeList.BeforeDragNodeEventArgs e)
        {
            if (e.Node.GetValue(colCANDRAG).ToString() == "F")
                e.CanDrag = false;  // to Cancel Drag&Drop for this node
        }

        private void treeList1_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.HasChildren)
                e.Appearance.Font = treeList1.Appearance.EvenRow.Font;
        }

        private void treeList1_DragOver(object sender, DragEventArgs e)
        {
            //Text = e.AllowedEffect.ToString() + "  --  " + e.Effect.ToString();
            
        }

        private void treeList1_DragDrop(object sender, DragEventArgs e)
        {
            TreeListNode dragNode, targetNode;
            dragNode = e.Data.GetData(typeof(TreeListNode)) as TreeListNode;
            //targetNode = GetTargetRootNode(treeList1.PointToClient(new Point(e.X, e.Y)));
            targetNode = treeList1.CalcHitInfo(treeList1.PointToClient(new Point(e.X, e.Y))).Node;
            
            Text = targetNode.GetValue("AD").ToString();
            //if (targetNode.GetValue("FRM") != DBNull.Value)
            //    e.Effect = DragDropEffects.None;
        }

        public TreeListNode GetTargetRootNode(Point point)
        {
            TreeListNode Target = treeList1.CalcHitInfo(point).Node;

            object op = Target.Level;
            if (Target.ParentNode != null)
                do
                {
                    Target = Target.ParentNode;

                } while (Target.ParentNode != null);

            return Target;

        }
    }
}