namespace MyDevHelper2
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combcon = new System.Windows.Forms.ComboBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.cbtable = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 27);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.RightToLeftLayout = true;
            this.dockPanel1.Size = new System.Drawing.Size(1066, 695);
            this.dockPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1066, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据源ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 数据源ToolStripMenuItem
            // 
            this.数据源ToolStripMenuItem.Name = "数据源ToolStripMenuItem";
            this.数据源ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.数据源ToolStripMenuItem.Text = "数据源";
            // 
            // combcon
            // 
            this.combcon.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combcon.FormattingEnabled = true;
            this.combcon.Location = new System.Drawing.Point(62, 2);
            this.combcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combcon.Name = "combcon";
            this.combcon.Size = new System.Drawing.Size(556, 25);
            this.combcon.TabIndex = 4;
            this.combcon.TextChanged += new System.EventHandler(this.combcon_TextChanged);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(635, 0);
            this.btnCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(87, 27);
            this.btnCon.TabIndex = 5;
            this.btnCon.Text = "测试连接";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnAddCon
            // 
            this.btnAddCon.Location = new System.Drawing.Point(728, 0);
            this.btnAddCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(87, 27);
            this.btnAddCon.TabIndex = 6;
            this.btnAddCon.Text = "保存连接";
            this.btnAddCon.UseVisualStyleBackColor = true;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // cbtable
            // 
            this.cbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtable.FormattingEnabled = true;
            this.cbtable.Location = new System.Drawing.Point(830, 0);
            this.cbtable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbtable.Name = "cbtable";
            this.cbtable.Size = new System.Drawing.Size(179, 25);
            this.cbtable.TabIndex = 8;
            this.cbtable.SelectedIndexChanged += new System.EventHandler(this.cbtable_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 722);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.btnAddCon);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.combcon);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "开发助手";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据源ToolStripMenuItem;
        private System.Windows.Forms.ComboBox combcon;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.ComboBox cbtable;
    }
}

