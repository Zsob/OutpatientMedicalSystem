namespace OutpatientSystem
{
    partial class frm_Lock
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.gpb_Information = new System.Windows.Forms.GroupBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_LogIn = new System.Windows.Forms.Label();
            this.lbl_Console = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.lbl_LandingPerson = new System.Windows.Forms.Label();
            this.lbl_Verification = new System.Windows.Forms.Label();
            this.gpb_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Confirm.Enabled = false;
            this.btn_Confirm.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Confirm.Location = new System.Drawing.Point(87, 358);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(85, 32);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "解锁";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // gpb_Information
            // 
            this.gpb_Information.Controls.Add(this.lbl_LandingPerson);
            this.gpb_Information.Controls.Add(this.lbl_Tip);
            this.gpb_Information.Controls.Add(this.lbl_Console);
            this.gpb_Information.Controls.Add(this.lbl_LogIn);
            this.gpb_Information.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpb_Information.Location = new System.Drawing.Point(13, 30);
            this.gpb_Information.Name = "gpb_Information";
            this.gpb_Information.Size = new System.Drawing.Size(524, 223);
            this.gpb_Information.TabIndex = 1;
            this.gpb_Information.TabStop = false;
            this.gpb_Information.Text = "登陆信息";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(32, 291);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 20);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Password.Location = new System.Drawing.Point(107, 288);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(335, 30);
            this.txb_Password.TabIndex = 3;
            this.txb_Password.UseSystemPasswordChar = true;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_LogOut.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LogOut.Location = new System.Drawing.Point(357, 358);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(85, 32);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.Text = "退出";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_LogIn
            // 
            this.lbl_LogIn.AutoSize = true;
            this.lbl_LogIn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_LogIn.Location = new System.Drawing.Point(23, 43);
            this.lbl_LogIn.Name = "lbl_LogIn";
            this.lbl_LogIn.Size = new System.Drawing.Size(106, 24);
            this.lbl_LogIn.TabIndex = 0;
            this.lbl_LogIn.Text = "登陆人：";
            // 
            // lbl_Console
            // 
            this.lbl_Console.AutoSize = true;
            this.lbl_Console.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Console.Location = new System.Drawing.Point(23, 88);
            this.lbl_Console.Name = "lbl_Console";
            this.lbl_Console.Size = new System.Drawing.Size(274, 24);
            this.lbl_Console.TabIndex = 1;
            this.lbl_Console.Text = "工作台：医生门诊工作站";
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Tip.Location = new System.Drawing.Point(19, 133);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(370, 48);
            this.lbl_Tip.TabIndex = 2;
            this.lbl_Tip.Text = "本工作台正在使用，且已被锁定。\r\n只能由本人解除锁定。";
            // 
            // lbl_LandingPerson
            // 
            this.lbl_LandingPerson.AutoSize = true;
            this.lbl_LandingPerson.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_LandingPerson.Location = new System.Drawing.Point(120, 43);
            this.lbl_LandingPerson.Name = "lbl_LandingPerson";
            this.lbl_LandingPerson.Size = new System.Drawing.Size(0, 24);
            this.lbl_LandingPerson.TabIndex = 3;
            // 
            // lbl_Verification
            // 
            this.lbl_Verification.AutoSize = true;
            this.lbl_Verification.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Verification.Location = new System.Drawing.Point(448, 291);
            this.lbl_Verification.Name = "lbl_Verification";
            this.lbl_Verification.Size = new System.Drawing.Size(89, 20);
            this.lbl_Verification.TabIndex = 5;
            this.lbl_Verification.Text = "点此验证";
            this.lbl_Verification.Click += new System.EventHandler(this.lbl_Verification_Click);
            // 
            // frm_Lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 418);
            this.Controls.Add(this.lbl_Verification);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.gpb_Information);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "frm_Lock";
            this.Text = "锁定";
            this.gpb_Information.ResumeLayout(false);
            this.gpb_Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.GroupBox gpb_Information;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.Label lbl_Console;
        private System.Windows.Forms.Label lbl_LogIn;
        private System.Windows.Forms.Label lbl_LandingPerson;
        private System.Windows.Forms.Label lbl_Verification;
    }
}