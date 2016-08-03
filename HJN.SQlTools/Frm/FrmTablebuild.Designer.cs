namespace MyDevHelper2.Frm
{
    partial class FrmTablebuild
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
            this.btncreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClassname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSql = new System.Windows.Forms.TextBox();
            this.btndown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbResult.Location = new System.Drawing.Point(77, 237);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(821, 196);
            this.tbResult.TabIndex = 33;
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncreate.Location = new System.Drawing.Point(78, 188);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 32;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "类名";
            // 
            // tbClassname
            // 
            this.tbClassname.Location = new System.Drawing.Point(77, 129);
            this.tbClassname.Multiline = true;
            this.tbClassname.Name = "tbClassname";
            this.tbClassname.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbClassname.Size = new System.Drawing.Size(821, 37);
            this.tbClassname.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "sql";
            // 
            // tbSql
            // 
            this.tbSql.Location = new System.Drawing.Point(77, 49);
            this.tbSql.Multiline = true;
            this.tbSql.Name = "tbSql";
            this.tbSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSql.Size = new System.Drawing.Size(821, 55);
            this.tbSql.TabIndex = 26;
            // 
            // btndown
            // 
            this.btndown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndown.Location = new System.Drawing.Point(163, 188);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(75, 23);
            this.btndown.TabIndex = 34;
            this.btndown.Text = "Download";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // FrmTablebuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 475);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbClassname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSql);
            this.Name = "FrmTablebuild";
            this.Text = "生成表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClassname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSql;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btndown;
    }
}