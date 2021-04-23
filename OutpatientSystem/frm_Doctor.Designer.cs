namespace OutpatientSystem
{
    partial class frm_Doctor
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
            this.mns_Doctor = new System.Windows.Forms.MenuStrip();
            this.锁定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.更改操作员口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_Doctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_Doctor
            // 
            this.mns_Doctor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mns_Doctor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_Doctor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.锁定ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.mns_Doctor.Location = new System.Drawing.Point(0, 0);
            this.mns_Doctor.Name = "mns_Doctor";
            this.mns_Doctor.Size = new System.Drawing.Size(1091, 40);
            this.mns_Doctor.TabIndex = 0;
            this.mns_Doctor.Text = "医师界面";
            // 
            // 锁定ToolStripMenuItem
            // 
            this.锁定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.锁定ToolStripMenuItem1,
            this.更改操作员口令ToolStripMenuItem});
            this.锁定ToolStripMenuItem.Name = "锁定ToolStripMenuItem";
            this.锁定ToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.锁定ToolStripMenuItem.Text = "控制台";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 锁定ToolStripMenuItem1
            // 
            this.锁定ToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.锁定ToolStripMenuItem1.Name = "锁定ToolStripMenuItem1";
            this.锁定ToolStripMenuItem1.Size = new System.Drawing.Size(233, 32);
            this.锁定ToolStripMenuItem1.Text = "锁定";
            this.锁定ToolStripMenuItem1.Click += new System.EventHandler(this.锁定ToolStripMenuItem1_Click);
            // 
            // 更改操作员口令ToolStripMenuItem
            // 
            this.更改操作员口令ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.更改操作员口令ToolStripMenuItem.Name = "更改操作员口令ToolStripMenuItem";
            this.更改操作员口令ToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.更改操作员口令ToolStripMenuItem.Text = "更改操作员口令";
            this.更改操作员口令ToolStripMenuItem.Click += new System.EventHandler(this.更改操作员口令ToolStripMenuItem_Click);
            // 
            // frm_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 689);
            this.Controls.Add(this.mns_Doctor);
            this.MainMenuStrip = this.mns_Doctor;
            this.Name = "frm_Doctor";
            this.Text = "医生系统";
            this.mns_Doctor.ResumeLayout(false);
            this.mns_Doctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_Doctor;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 更改操作员口令ToolStripMenuItem;
    }
}