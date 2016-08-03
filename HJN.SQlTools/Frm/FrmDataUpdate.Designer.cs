namespace MyDevHelper2.Frm
{
    partial class FrmDataUpdate
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpdateWhere = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWhere = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUpdateColumns = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btndown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "更新的列";
            // 
            // tbUpdateWhere
            // 
            this.tbUpdateWhere.Location = new System.Drawing.Point(108, 124);
            this.tbUpdateWhere.Multiline = true;
            this.tbUpdateWhere.Name = "tbUpdateWhere";
            this.tbUpdateWhere.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbUpdateWhere.Size = new System.Drawing.Size(729, 32);
            this.tbUpdateWhere.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 34);
            this.label5.TabIndex = 27;
            this.label5.Text = "查询sqlwhere\r\n（不含where）";
            // 
            // tbWhere
            // 
            this.tbWhere.Location = new System.Drawing.Point(108, 42);
            this.tbWhere.Multiline = true;
            this.tbWhere.Name = "tbWhere";
            this.tbWhere.Size = new System.Drawing.Size(729, 60);
            this.tbWhere.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 34);
            this.label6.TabIndex = 29;
            this.label6.Text = "updatewhere\r\n列名";
            // 
            // tbUpdateColumns
            // 
            this.tbUpdateColumns.Location = new System.Drawing.Point(108, 180);
            this.tbUpdateColumns.Multiline = true;
            this.tbUpdateColumns.Name = "tbUpdateColumns";
            this.tbUpdateColumns.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbUpdateColumns.Size = new System.Drawing.Size(729, 55);
            this.tbUpdateColumns.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(112, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "生成update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbResult.Location = new System.Drawing.Point(16, 298);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(821, 180);
            this.tbResult.TabIndex = 33;
            this.tbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbResult_KeyUp);
            // 
            // btndown
            // 
            this.btndown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndown.Location = new System.Drawing.Point(223, 250);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(75, 23);
            this.btndown.TabIndex = 37;
            this.btndown.Text = "Download";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // FrmDataUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 643);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbUpdateColumns);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUpdateWhere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbWhere);
            this.Controls.Add(this.label6);
            this.Name = "FrmDataUpdate";
            this.Text = "数据更新";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUpdateWhere;
  
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWhere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUpdateColumns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btndown;
    }
}