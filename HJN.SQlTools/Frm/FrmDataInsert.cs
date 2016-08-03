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
    public partial class FrmDataInsert : BaseForm
    {

        public FrmDataInsert()
        {
            InitializeComponent();


        }


        /// <summary>
        /// 测试数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndata_Click(object sender, EventArgs e)
        {
            if (FormMain.db == null)
            {
                MessageBox.Show("请连接数据库。");
            }
            else
            {
                string columns = "";
                if (!string.IsNullOrEmpty(tbexcept.Text))
                {
                    DataTable dtColumns = ComUtil.GetColumnDT(FormMain.dbtable,FormMain.db);
                    foreach (DataRow dr in dtColumns.Rows)
                    {
                        string name = dr["字段名"].ToString().ToLower();
                        if (string.IsNullOrEmpty(tbexcept.Text))
                            columns += "[" + dr["字段名"] + "],";
                        else if (("," + tbexcept.Text + ",").ToLower().IndexOf("," + name + ",") == -1)
                        {
                            columns += "[" + dr["字段名"] + "],";
                        }
                    }
                    columns = columns.TrimEnd(',');
                }
                else
                {
                    columns =" * ";
                }


                string sqldata = " select top 500 " + columns + " from  [" + FormMain.dbtable + "]  where 1=1 and " + (tbsqlwhere.Text.Trim().Length == 0 ? " 1=1 " : tbsqlwhere.Text);
                DataTable dtData = FormMain.db.ExecuteDataSet(sqldata).Tables[0];
                dgvdata.DataSource = dtData;
            }
        }

        /// <summary>
        /// 生成insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btninsert_Click(object sender, EventArgs e)
        {

            btninsert.Enabled = false;
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object ee)
            {
                tbResult.Text = string.Empty;
                Thread.Sleep(1000);
                tbResult.Text = BuildInsert();
                btninsert.Enabled = true;
            }));      
           
           
        }


        private string BuildInsert()
        {
            string tableName = FormMain.dbtable; ;
            StringBuilder sb = new StringBuilder();
            if (cbxIncludeExists.Checked && string.IsNullOrEmpty(tbIncludeExists.Text))
            {
                //throw new Exception("选择了包含Exists，必须填写Exists的判断列名");
                MessageBox.Show("选择了包含Exists，必须填写Exists的判断列名");
                return string.Empty;
            }
            List<string> excludeCoumns = new List<string>();

            excludeCoumns.AddRange(tbIncludeExists.Text.Split(','));
            DataTable dtColumns = ComUtil.GetColumnDT(FormMain.dbtable,FormMain.db);
            string columns = "";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (DataRow dr in dtColumns.Rows)
            {
                string name = dr["字段名"].ToString().ToLower();
                string type = dr["字段类型"].ToString().ToLower();
                dic.Add(name, type);
                if (string.IsNullOrEmpty(tbexcept.Text))
                    columns += "[" + dr["字段名"] + "],";
                else if (("," + tbexcept.Text + ",").ToLower().IndexOf("," + name + ",") == -1)
                {
                    columns += "[" + dr["字段名"] + "],";
                }
            }
            columns = columns.TrimEnd(',');

            string sqldata = " select " + columns + " from  [" + tableName + "] where 1=1 and " + (tbsqlwhere.Text.Trim().Length == 0 ? " 1=1 " : tbsqlwhere.Text);

            string sqlDataAllColumns = " select * from  [" + tableName + "] where 1=1 and " + (tbsqlwhere.Text.Trim().Length == 0 ? " 1=1 " : tbsqlwhere.Text);

            DataTable dtData = FormMain.db.ExecuteDataSet(sqldata).Tables[0];
            DataTable dtDataAllCOlumns = FormMain.db.ExecuteDataSet(sqlDataAllColumns).Tables[0];

            // 输出脚本
           
            int i = 0;
            foreach (DataRow dr in dtDataAllCOlumns.Rows)
            {
                string sqlStr = @"INSERT INTO [" + tableName + "](";
                if (cbxIncludeExists.Checked)
                {
                    sqlStr = @"IF NOT EXISTS (SELECT * FROM [#tbname#] WHERE #where#) INSERT INTO [#tbname#](";

                    string[] existsColumns = tbIncludeExists.Text.Replace("，", ",").Split(',');
                    string where = "";
                    foreach (DataColumn dc in dtDataAllCOlumns.Columns)
                    {
                        foreach (string column in existsColumns)
                        {
                            if (column.ToLower() == dc.ColumnName.ToLower())
                            {
                                where += " [" + dc.ColumnName + "]=" + ComUtil.GetVal(dr, dc) + " AND";
                            }
                        }
                    }
                    where = where.TrimEnd(new char[] { 'A', 'N', 'D' });
                    sqlStr = sqlStr.Replace("#tbname#", tableName).Replace("#where#", where);
                }
                foreach (DataColumn dc in dtData.Columns)
                {
                    if (("," + tbexcept.Text.ToLower() + ",").IndexOf("," + dc.ColumnName.ToLower() + ",") > -1) continue;
                    sqlStr += "[" + dc.ColumnName + "],";
                }
                sqlStr = sqlStr.TrimEnd(',') + ") values (";
                foreach (DataColumn dc in dtData.Columns)
                {
                    //object v = dr[dc.ColumnName];
                    //if (dc.DataType == typeof(string))
                    //    s += "N'" + v.ToString().Replace("'", "''") + "',";
                    //else if (v.GetType() == typeof(DBNull))
                    //{
                    //    s += "NULL,";
                    //}
                    //else s += v.ToString() + ",";
                    if (("," + tbexcept.Text.ToLower() + ",").IndexOf("," + dc.ColumnName.ToLower() + ",") > -1) continue;
                    sqlStr += ComUtil.GetVal(dr, dc) + ",";
                }
                sqlStr = sqlStr.TrimEnd(',') + ") ";
                sb.AppendLine(sqlStr);
            }
            return sb.ToString();

        }

        /// <summary>
        /// 是否exist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxIncludeExists_CheckedChanged(object sender, EventArgs e)
        {
            this.tbIncludeExists.Visible = cbxIncludeExists.Checked;
        }

        /// <summary>
        /// 生成脚本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndown_Click(object sender, EventArgs e)
        {
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
            string script = BuildInsert();
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

        private void tbResult_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
