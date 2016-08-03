namespace MyDevHelper2.Frm
{
    partial class FrmDataInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbIncludeExists = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btndown = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndata = new System.Windows.Forms.Button();
            this.cbxIncludeExists = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbexcept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsqlwhere = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbResult.Location = new System.Drawing.Point(28, 285);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(898, 175);
            this.tbResult.TabIndex = 26;
            this.tbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbResult_KeyUp);
            // 
            // tbIncludeExists
            // 
            this.tbIncludeExists.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIncludeExists.Location = new System.Drawing.Point(173, 213);
            this.tbIncludeExists.Name = "tbIncludeExists";
            this.tbIncludeExists.Size = new System.Drawing.Size(753, 23);
            this.tbIncludeExists.TabIndex = 24;
            this.tbIncludeExists.Visible = false;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(27, 466);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowTemplate.Height = 23;
            this.dgvdata.Size = new System.Drawing.Size(899, 213);
            this.dgvdata.TabIndex = 23;
            // 
            // btndown
            // 
            this.btndown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndown.Location = new System.Drawing.Point(275, 249);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(75, 23);
            this.btndown.TabIndex = 22;
            this.btndown.Text = "Download";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninsert.Location = new System.Drawing.Point(182, 249);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 21;
            this.btninsert.Text = "生成Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndata
            // 
            this.btndata.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndata.Location = new System.Drawing.Point(86, 249);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(75, 23);
            this.btndata.TabIndex = 20;
            this.btndata.Text = "测试数据";
            this.btndata.UseVisualStyleBackColor = true;
            this.btndata.Click += new System.EventHandler(this.btndata_Click);
            // 
            // cbxIncludeExists
            // 
            this.cbxIncludeExists.AutoSize = true;
            this.cbxIncludeExists.BackColor = System.Drawing.Color.Transparent;
            this.cbxIncludeExists.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxIncludeExists.Location = new System.Drawing.Point(86, 214);
            this.cbxIncludeExists.Name = "cbxIncludeExists";
            this.cbxIncludeExists.Size = new System.Drawing.Size(83, 21);
            this.cbxIncludeExists.TabIndex = 19;
            this.cbxIncludeExists.Text = "包含Exists";
            this.cbxIncludeExists.UseVisualStyleBackColor = false;
            this.cbxIncludeExists.CheckedChanged += new System.EventHandler(this.cbxIncludeExists_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(24, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "属性";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(24, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "排除的列";
            // 
            // tbexcept
            // 
            this.tbexcept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbexcept.Location = new System.Drawing.Point(86, 148);
            this.tbexcept.Multiline = true;
            this.tbexcept.Name = "tbexcept";
            this.tbexcept.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbexcept.Size = new System.Drawing.Size(840, 55);
            this.tbexcept.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "sqlwhere";
            // 
            // tbsqlwhere
            // 
            this.tbsqlwhere.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbsqlwhere.Location = new System.Drawing.Point(87, 40);
            this.tbsqlwhere.Multiline = true;
            this.tbsqlwhere.Name = "tbsqlwhere";
            this.tbsqlwhere.Size = new System.Drawing.Size(840, 89);
            this.tbsqlwhere.TabIndex = 13;
            // 
            // FrmDataInsert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(945, 663);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbIncludeExists);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btndata);
            this.Controls.Add(this.cbxIncludeExists);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbexcept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbsqlwhere);
            this.Name = "FrmDataInsert";
            this.Text = "数据导入";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsqlwhere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbexcept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxIncludeExists;
        private System.Windows.Forms.Button btndata;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox tbIncludeExists;
        private System.Windows.Forms.TextBox tbResult;

    }
}