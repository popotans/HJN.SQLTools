using MyDevHelper2.Common;
using MyDevHelper2.Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using UtilityLibrary.WinControls;

namespace MyDevHelper2
{
    public partial class MainToolForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private OutlookBar outlookBar1 = null;
       
        private FrmTablebuild frmTablebuild = null;
        private FrmDataInsert frmDataInsert = null;
        private FrmDataUpdate frmDataUpdate = null;

        public MainToolForm()
        {
            InitializeComponent();
            this.HideOnClose = true;
            this.Load += MainToolForm_Load;
        }

        void MainToolForm_Load(object sender, EventArgs e)
        {
            InitTree();
           
            
        }

        private void InitTree()
        {
            treeView1.LabelEdit = false;//不可编辑

            List<MenuConfig> list = MenuConfig.LoadAll();
            foreach (var item in list)
            {
                TreeNode root = new TreeNode();
                root.Text = item.GroupName;
                root.Name = item.GroupCode;
                foreach (var menu in item.Menus)
                {
                    TreeNode node = new TreeNode();
                    node.Text = menu.Name;
                    node.Name = menu.Link;
                    root.Nodes.Add(node);
                }
                treeView1.Nodes.Add(root);
            }

            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.HideSelection = false;
            treeView1.ExpandAll();
            //自已绘制
            this.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.treeView1.DrawNode += new DrawTreeNodeEventHandler(treeView1_DrawNode);

            if (frmDataInsert == null || !frmDataInsert.Created)
            {
                frmDataInsert = new FrmDataInsert();
                frmDataInsert.TabText = treeView1.Nodes[0].Text;
                frmDataInsert.Show(this.DockPanel);
            }
        }

        //在绘制节点事件中，按自已想的绘制
        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            //e.DrawDefault = true; //我这里用默认颜色即可，只需要在TreeView失去焦点时选中节点仍然突显
            //return;

            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                //演示为绿底白字
                e.Graphics.FillRectangle(Brushes.DarkCyan, e.Node.Bounds);

                Font nodeFont = e.Node.NodeFont;

                if (nodeFont == null) nodeFont = ((TreeView)sender).Font;
                e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.White, Rectangle.Inflate(e.Bounds, 2, 0));
            }
            else
            {
                e.DrawDefault = true;
            }

            if ((e.State & TreeNodeStates.Focused) != 0)
            {
                using (Pen focusPen = new Pen(Color.Black))
                {
                    focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    Rectangle focusBounds = e.Node.Bounds;
                    focusBounds.Size = new Size(focusBounds.Width - 1, focusBounds.Height - 1);
                    e.Graphics.DrawRectangle(focusPen, focusBounds);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string frmname = treeView1.SelectedNode.Name;
              
                switch (frmname)
                {
              
                    case "FrmDataInsert":
                        if (frmDataInsert == null || !frmDataInsert.Created)
                        {
                            frmDataInsert = new FrmDataInsert();
                            frmDataInsert.TabText = treeView1.SelectedNode.Text;
                        }
                        frmDataInsert.Show(this.DockPanel);
                        break;
                    case "FrmDataUpdate":
                        if (frmDataUpdate == null || !frmDataUpdate.Created)
                        {
                            frmDataUpdate = new FrmDataUpdate();
                            frmDataUpdate.TabText = treeView1.SelectedNode.Text;
                        }
                        frmDataUpdate.Show(this.DockPanel);
                        break;
                    case "FrmTablebuild":
                        if (frmTablebuild == null || !frmTablebuild.Created)
                        {
                            frmTablebuild = new FrmTablebuild();
                            frmTablebuild.TabText = treeView1.SelectedNode.Text;
                        }
                        frmTablebuild.Show(this.DockPanel);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain ff = (FormMain)this.DockPanel.FindForm();
            ff.Frm1Show();
        }
    }
}
