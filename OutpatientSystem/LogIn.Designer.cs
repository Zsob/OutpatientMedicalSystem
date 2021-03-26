namespace OutpatientSystem
{
    partial class LogIn
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
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_No.Location = new System.Drawing.Point(23, 77);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(69, 20);
            this.lbl_No.TabIndex = 0;
            this.lbl_No.Text = "账号：";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(23, 136);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 20);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "密码：";
            // 
            // txb_No
            // 
            this.txb_No.Location = new System.Drawing.Point(98, 78);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(163, 25);
            this.txb_No.TabIndex = 2;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(98, 137);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(163, 25);
            this.txb_Password.TabIndex = 3;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(81, 207);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(84, 30);
            this.btn_LogIn.TabIndex = 4;
            this.btn_LogIn.Text = "登陆";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(81, 254);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(84, 30);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 328);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_No);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_No);
            this.Name = "LogIn";
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_SignUp;
    }
}