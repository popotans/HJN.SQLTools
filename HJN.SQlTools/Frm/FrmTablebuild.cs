using MyDevHelper2.Common;
using PWMIS.DataProvider.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDevHelper2.Frm
{

    public partial class FrmTablebuild : BaseForm
    {

        public FrmTablebuild()
        {
            InitializeComponent();

        }



        private void btncreate_Click(object sender, EventArgs e)
        {
            tbResult.Text = BuildClass();

        }

        private string BuildClass()
        {
            if (FormMain.db == null)
            {
                MessageBox.Show("请连接数据库。");
                return string.Empty;
            }
            string rts = string.Empty;
            if (string.IsNullOrEmpty(tbSql.Text))
            {
                //MessageBox.Show("请输入要生成的数据库脚本。");
                tbSql.Text = "select * from " + FormMain.dbtable;
            }

            DataTable dt = FormMain.db.ExecuteDataSet(tbSql.Text).Tables[0];
            if (string.IsNullOrEmpty(tbClassname.Text))
                tbClassname.Text = "LeiMing";
            rts = ClassGenerateHelper.DataTableToClass(dt, tbClassname.Text);

            return rts;
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "代码文件(*.cs)|*.cs";
            //设置默认文件类型显示顺序 
            saveFileDialog1.FilterIndex = 1;
            //保存对话框是否记忆上次打开的目录 
            saveFileDialog1.RestoreDirectory = true;

            //选择保存路径
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("您取消了保存！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            };

            this.Cursor = Cursors.WaitCursor;
            string script = BuildClass();
            tbResult.Text = script;

            MemoryStream m = ComUtil.GenerateStreamFromString(script);
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            BinaryWriter w = new BinaryWriter(fs);
            w.Write(m.ToArray());
            fs.Close();
            m.Close();
            this.Cursor = Cursors.Default;
            MessageBox.Show("数据导出成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
