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
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_Charge = new System.Windows.Forms.Button();
            this.btn_Information = new System.Windows.Forms.Button();
            this.btn_Appointment = new System.Windows.Forms.Button();
            this.txb_Message = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Quite = new System.Windows.Forms.Button();
            this.btn_Settlement = new System.Windows.Forms.Button();
            this.grb_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_User
            // 
            this.grb_User.Controls.Add(this.btn_Settlement);
            this.grb_User.Controls.Add(this.btn_Quite);
            this.grb_User.Controls.Add(this.btn_ChangePassword);
            this.grb_User.Controls.Add(this.btn_Charge);
            this.grb_User.Controls.Add(this.btn_Information);
            this.grb_User.Controls.Add(this.btn_Appointment);
            this.grb_User.Location = new System.Drawing.Point(0, 85);
            this.grb_User.Name = "grb_User";
            this.grb_User.Size = new System.Drawing.Size(578, 546);
            this.grb_User.TabIndex = 0;
            this.grb_User.TabStop = false;
            this.grb_User.Text = "用户";
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ChangePassword.Location = new System.Drawing.Point(339, 222);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(171, 102);
            this.btn_ChangePassword.TabIndex = 3;
            this.btn_ChangePassword.TabStop = false;
            this.btn_ChangePassword.Text = "密码修改";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_Charge
            // 
            this.btn_Charge.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Charge.Location = new System.Drawing.Point(62, 222);
            this.btn_Charge.Name = "btn_Charge";
            this.btn_Charge.Size = new System.Drawing.Size(171, 102);
            this.btn_Charge.TabIndex = 2;
            this.btn_Charge.TabStop = false;
            this.btn_Charge.Text = "在线充值";
            this.btn_Charge.UseVisualStyleBackColor = true;
            this.btn_Charge.Click += new System.EventHandler(this.btn_Charge_Click);
            // 
            // btn_Information
            // 
            this.btn_Information.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Information.Location = new System.Drawing.Point(62, 82);
            this.btn_Information.Name = "btn_Information";
            this.btn_Information.Size = new System.Drawing.Size(171, 102);
            this.btn_Information.TabIndex = 1;
            this.btn_Information.TabStop = false;
            this.btn_Information.Text = "个人中心";
            this.btn_Information.UseVisualStyleBackColor = true;
            this.btn_Information.Click += new System.EventHandler(this.btn_Information_Click);
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Appointment.Location = new System.Drawing.Point(339, 82);
            this.btn_Appointment.Name = "btn_Appointment";
            this.btn_Appointment.Size = new System.Drawing.Size(171, 102);
            this.btn_Appointment.TabIndex = 0;
            this.btn_Appointment.TabStop = false;
            this.btn_Appointment.Text = "预约挂号";
            this.btn_Appointment.UseVisualStyleBackColor = true;
            this.btn_Appointment.Click += new System.EventHandler(this.btn_Appointment_Click);
            // 
            // txb_Message
            // 
            this.txb_Message.Enabled = false;
            this.txb_Message.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Message.Location = new System.Drawing.Point(77, 34);
            this.txb_Message.Name = "txb_Message";
            this.txb_Message.Size = new System.Drawing.Size(316, 36);
            this.txb_Message.TabIndex = 2;
            this.txb_Message.Text = "未登陆";
            this.txb_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Logout.Location = new System.Drawing.Point(425, 35);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(85, 33);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "注销";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Quite
            // 
            this.btn_Quite.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Quite.Location = new System.Drawing.Point(339, 370);
            this.btn_Quite.Name = "btn_Quite";
            this.btn_Quite.Size = new System.Drawing.Size(171, 102);
            this.btn_Quite.TabIndex = 4;
            this.btn_Quite.TabStop = false;
            this.btn_Quite.Text = "退出";
            this.btn_Quite.UseVisualStyleBackColor = true;
            this.btn_Quite.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Settlement
            // 
            this.btn_Settlement.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Settlement.Location = new System.Drawing.Point(62, 370);
            this.btn_Settlement.Name = "btn_Settlement";
            this.btn_Settlement.Size = new System.Drawing.Size(171, 102);
            this.btn_Settlement.TabIndex = 5;
            this.btn_Settlement.TabStop = false;
            this.btn_Settlement.Text = "结算";
            this.btn_Settlement.UseVisualStyleBackColor = true;
            this.btn_Settlement.Click += new System.EventHandler(this.btn_Settlement_Click);
            // 
            // frm_OutpatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 652);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.txb_Message);
            this.Controls.Add(this.grb_User);
            this.Name = "frm_OutpatientForm";
            this.Text = "医院门诊系统";
            this.grb_User.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_User;
        private System.Windows.Forms.TextBox txb_Message;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Appointment;
        private System.Windows.Forms.Button btn_Information;
        private System.Windows.Forms.Button btn_Charge;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_Settlement;
        private System.Windows.Forms.Button btn_Quite;
    }
}

