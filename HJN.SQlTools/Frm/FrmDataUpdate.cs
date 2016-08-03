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
using System.Threading;
using System.Windows.Forms;

namespace MyDevHelper2.Frm
{
    public partial class FrmDataUpdate : BaseForm
    {

        public FrmDataUpdate()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object ee)
            {
                tbResult.Text = string.Empty;
                Thread.Sleep(1000);
                tbResult.Text = BuildUpdate();
                button2.Enabled = true;
            }));           
        }


        private string BuildUpdate()
        {
            if (FormMain.db == null)
            {
                MessageBox.Show("请连接数据库。");
                return string.Empty;
            }
            string tableName = FormMain.dbtable;
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(tbUpdateColumns.Text))
            {
                MessageBox.Show("生成更新语句必须显示指定列名");
                return string.Empty;
            }
            if (string.IsNullOrEmpty(tbUpdateWhere.Text))
            {
                MessageBox.Show("生成更新语句时，更新语句条件必须设置");
                return string.Empty;
            }


            //if (cbxIncludeExists.Checked && string.IsNullOrEmpty(tbIncludeExists.Text))
            //{
            //    MessageBox.Show("选择了包含Exists，必须填写Exists的判断列名");
            //    //throw new Exception("选择了包含Exists，必须填写Exists的判断列名");
            //    return string.Empty;
            //}

            DataTable dtColumns = ComUtil.GetColumnDT(FormMain.dbtable, FormMain.db);

            string sqlDataAllColumns = " select * from  [" + tableName + "] where 1=1 and " + (tbWhere.Text.Trim().Length == 0 ? " 1=1 " : tbWhere.Text);

            // DataTable dtData = db.ExecuteDataSet(sqldata).Tables[0];
            DataTable dtDataAllCOlumns = FormMain.db.ExecuteDataSet(sqlDataAllColumns).Tables[0];

            // 输出脚本

            foreach (DataRow dr in dtDataAllCOlumns.Rows)
            {
                string sqlStr = " UPDATE [" + tableName + "] SET ";
                string[] uploadCOlumns = tbUpdateColumns.Text.Replace("，", ",").Split(',');
                string updateCOntent = "", where = "";
                foreach (DataColumn dc in dtDataAllCOlumns.Columns)
                {
                    foreach (string column in uploadCOlumns)
                    {
                        if (column.ToLower() == dc.ColumnName.ToLower())
                        {
                            updateCOntent += " [" + dc.ColumnName + "]=" + ComUtil.GetVal(dr, dc) + ",";
                        }
                    }
                }
                string[] updateWhere = tbUpdateWhere.Text.Replace("，", ",").Split(',');
                if (updateWhere.Length == 0 && string.IsNullOrEmpty(tbUpdateWhere.Text))
                {
                    updateWhere = new string[0];
                    updateWhere[0] = tbUpdateWhere.Text;
                }
                if (updateWhere.Length != 0)
                {
                    foreach (string uw in updateWhere)
                    {
                        foreach (DataColumn dc in dtDataAllCOlumns.Columns)
                        {
                            if (uw.ToLower() == dc.ColumnName.ToLower())
                            {
                                if (string.IsNullOrEmpty(where))
                                    where += " [" + uw + "]=" + ComUtil.GetVal(dr, dc);
                                else
                                {
                                    where += " and [" + uw + "]=" + ComUtil.GetVal(dr, dc);
                                }
                            }
                        }
                    }
                    sqlStr = sqlStr + updateCOntent.TrimEnd(',') + " where " + where;
                }

                sb.AppendLine(sqlStr);
            }
            return sb.ToString();
        }
        private void btndown_Click(object sender, EventArgs e)
        {
            if (FormMain.db == null)
            {
                MessageBox.Show("请连接数据库。");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "脚本文件(*.sql)|*.sql";
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
            string script = BuildUpdate();
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

        private void cbxIncludeExists_CheckedChanged(object sender, EventArgs e)
        {
            //if(cbxIncludeExists.Checked)
            //{
            //    tbIncludeExists.Visible = true;
            //}
        }

        private void tbResult_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
