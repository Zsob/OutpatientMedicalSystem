namespace OutpatientSystem
{
    partial class frm_ChangePassword
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
            this.lbl_OldPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_ComfirmPassword = new System.Windows.Forms.Label();
            this.txb_OldPassword = new System.Windows.Forms.TextBox();
            this.txb_NewPassword = new System.Windows.Forms.TextBox();
            this.txb_ComfirmPassword = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_OldPassword
            // 
            this.lbl_OldPassword.AutoSize = true;
            this.lbl_OldPassword.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OldPassword.Location = new System.Drawing.Point(106, 71);
            this.lbl_OldPassword.Name = "lbl_OldPassword";
            this.lbl_OldPassword.Size = new System.Drawing.Size(106, 24);
            this.lbl_OldPassword.TabIndex = 0;
            this.lbl_OldPassword.Text = "旧密码：";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(106, 138);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(106, 24);
            this.lbl_NewPassword.TabIndex = 1;
            this.lbl_NewPassword.Text = "新密码：";
            // 
            // lbl_ComfirmPassword
            // 
            this.lbl_ComfirmPassword.AutoSize = true;
            this.lbl_ComfirmPassword.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ComfirmPassword.Location = new System.Drawing.Point(82, 204);
            this.lbl_ComfirmPassword.Name = "lbl_ComfirmPassword";
            this.lbl_ComfirmPassword.Size = new System.Drawing.Size(130, 24);
            this.lbl_ComfirmPassword.TabIndex = 2;
            this.lbl_ComfirmPassword.Text = "确认密码：";
            // 
            // txb_OldPassword
            // 
            this.txb_OldPassword.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_OldPassword.Location = new System.Drawing.Point(219, 69);
            this.txb_OldPassword.Name = "txb_OldPassword";
            this.txb_OldPassword.Size = new System.Drawing.Size(265, 28);
            this.txb_OldPassword.TabIndex = 3;
            this.txb_OldPassword.UseSystemPasswordChar = true;
            // 
            // txb_NewPassword
            // 
            this.txb_NewPassword.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_NewPassword.Location = new System.Drawing.Point(218, 140);
            this.txb_NewPassword.Name = "txb_NewPassword";
            this.txb_NewPassword.Size = new System.Drawing.Size(265, 28);
            this.txb_NewPassword.TabIndex = 4;
            this.txb_NewPassword.UseSystemPasswordChar = true;
            // 
            // txb_ComfirmPassword
            // 
            this.txb_ComfirmPassword.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ComfirmPassword.Location = new System.Drawing.Point(218, 204);
            this.txb_ComfirmPassword.Name = "txb_ComfirmPassword";
            this.txb_ComfirmPassword.Size = new System.Drawing.Size(265, 28);
            this.txb_ComfirmPassword.TabIndex = 5;
            this.txb_ComfirmPassword.UseSystemPasswordChar = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Change.Location = new System.Drawing.Point(255, 280);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(125, 36);
            this.btn_Change.TabIndex = 6;
            this.btn_Change.Text = "修改";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 363);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txb_ComfirmPassword);
            this.Controls.Add(this.txb_NewPassword);
            this.Controls.Add(this.txb_OldPassword);
            this.Controls.Add(this.lbl_ComfirmPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.lbl_OldPassword);
            this.Name = "frm_ChangePassword";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OldPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_ComfirmPassword;
        private System.Windows.Forms.TextBox txb_OldPassword;
        private System.Windows.Forms.TextBox txb_NewPassword;
        private System.Windows.Forms.TextBox txb_ComfirmPassword;
        private System.Windows.Forms.Button btn_Change;
    }
}