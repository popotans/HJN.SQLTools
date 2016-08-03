using MyDevHelper2.Common;
using MyDevHelper2.Frm;
using PWMIS.DataProvider.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MyDevHelper2
{
    public partial class FormMain : Form
    {
        private Frm1 frm1 = new Frm1();


        public static AdoHelper db;
        public static string dbtable;

        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            MainToolForm mainToolWin = new MainToolForm();
            mainToolWin.Show(this.dockPanel1, DockState.DockLeft);

            //FrmDefault fdf = new FrmDefault();
            //fdf.Show(this.dockPanel1);
            //fdf.IsHidden = false;
            List<Con> list=ConConfig.LoadAll();
            if(list.Count>0)
            {
                combcon.DataSource = list;
                combcon.DisplayMember = "name";
                combcon.ValueMember = "name";
            }

        }

        public void Frm1Show()
        {
            if (frm1 == null) frm1 = new Frm1();
            frm1.Show(this.dockPanel1);
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            db = DBContext.GetDB(combcon.Text);
            if (db != null)
            {
                string sqlTbs = "SELECT name FROM SysObjects Where XType='U' order by name  ";

                DataTable dt = db.ExecuteDataSet(sqlTbs).Tables[0];
                cbtable.DataSource = dt;
                cbtable.ValueMember = "name";
                cbtable.DisplayMember = "name";

                MessageBox.Show("连接成功。");
                dbtable = cbtable.Text;
            }
            else
            {
                MessageBox.Show("连接失败，请核对连接信息。");
            }
        }

        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbtable = cbtable.Text;
        }

        private void combcon_TextChanged(object sender, EventArgs e)
        {
            db = null;
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            
            if(ConConfig.IsExist(combcon.Text))
            {
                MessageBox.Show("该配置项已经存在。");
            }
            else
            {
                ConConfig.AddValue(combcon.Text);
                MessageBox.Show("保存成功。");
            }
        }



        /*
         
         private DockContent FindDocument(string text)
{
if (DockPanel.DocumentStyle == DocumentStyle.SystemMdi)
{
foreach (Form form in MdiChildren)
{
if (form.Text == text)
{
return form as DockContent;
}
}
return null;
}
else
{
foreach (DockContent content in DockPanel.Contents)
{
if (content.DockHandler.TabText == text)
{
return content;
}
}
return null;
}
}

public DockContent ShowContent(string caption, Type formType)
{
DockContent frm = FindDocument(caption);
if (frm == null)
{
frm = Activator.CreateInstance(formType) as DockContent;
frm.DockHandler.TabText = caption;
frm.Show(DockPanel);
} 
frm.Show(DockPanel,DockState.Document);
frm.BringToFront();
return frm;
}
         */
    }
}
