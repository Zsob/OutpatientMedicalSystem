namespace OutpatientSystem
{
    partial class frm_OutpatientForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_User = new System.Windows.Forms.GroupBox();
            this.grb_Docter = new System.Windows.Forms.GroupBox();
            this.txb_Message = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grb_User
            // 
            this.grb_User.Location = new System.Drawing.Point(0, 38);
            this.grb_User.Name = "grb_User";
            this.grb_User.Size = new System.Drawing.Size(543, 602);
            this.grb_User.TabIndex = 0;
            this.grb_User.TabStop = false;
            this.grb_User.Text = "用户";
            // 
            // grb_Docter
            // 
            this.grb_Docter.Location = new System.Drawing.Point(577, 38);
            this.grb_Docter.Name = "grb_Docter";
            this.grb_Docter.Size = new System.Drawing.Size(543, 602);
            this.grb_Docter.TabIndex = 1;
            this.grb_Docter.TabStop = false;
            this.grb_Docter.Text = "医师";
            // 
            // txb_Message
            // 
            this.txb_Message.Enabled = false;
            this.txb_Message.Location = new System.Drawing.Point(13, 7);
            this.txb_Message.Name = "txb_Message";
            this.txb_Message.Size = new System.Drawing.Size(316, 25);
            this.txb_Message.TabIndex = 2;
            this.txb_Message.Text = "未登陆";
            this.txb_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(361, 8);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(85, 33);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "注销";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // OutpatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 643);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.txb_Message);
            this.Controls.Add(this.grb_Docter);
            this.Controls.Add(this.grb_User);
            this.Name = "OutpatientForm";
            this.Text = "医院门诊系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_User;
        private System.Windows.Forms.GroupBox grb_Docter;
        private System.Windows.Forms.TextBox txb_Message;
        private System.Windows.Forms.Button btn_Logout;
    }
}

