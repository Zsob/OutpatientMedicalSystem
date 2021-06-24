namespace OutpatientSystem
{
    partial class frm_LogIn
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
            this.components = new System.ComponentModel.Container();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Docter = new System.Windows.Forms.Button();
            this.gpb_User = new System.Windows.Forms.GroupBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.gpb_Docter = new System.Windows.Forms.GroupBox();
            this.btn_DoctorLogIn = new System.Windows.Forms.Button();
            this.txb_DoctorPassword = new System.Windows.Forms.TextBox();
            this.txb_DoctorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpb_User.SuspendLayout();
            this.gpb_Docter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_User
            // 
            this.btn_User.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_User.Location = new System.Drawing.Point(36, 12);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(126, 43);
            this.btn_User.TabIndex = 0;
            this.btn_User.Text = "用户登录";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Docter
            // 
            this.btn_Docter.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Docter.Location = new System.Drawing.Point(158, 12);
            this.btn_Docter.Name = "btn_Docter";
            this.btn_Docter.Size = new System.Drawing.Size(126, 43);
            this.btn_Docter.TabIndex = 1;
            this.btn_Docter.Text = "医生登录";
            this.btn_Docter.UseVisualStyleBackColor = true;
            this.btn_Docter.Click += new System.EventHandler(this.btn_Docter_Click);
            // 
            // gpb_User
            // 
            this.gpb_User.Controls.Add(this.btn_SignUp);
            this.gpb_User.Controls.Add(this.btn_LogIn);
            this.gpb_User.Controls.Add(this.txb_Password);
            this.gpb_User.Controls.Add(this.txb_No);
            this.gpb_User.Controls.Add(this.lbl_Password);
            this.gpb_User.Controls.Add(this.lbl_No);
            this.gpb_User.Location = new System.Drawing.Point(36, 73);
            this.gpb_User.Name = "gpb_User";
            this.gpb_User.Size = new System.Drawing.Size(409, 483);
            this.gpb_User.TabIndex = 2;
            this.gpb_User.TabStop = false;
            this.gpb_User.Text = "用户登陆";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignUp.Location = new System.Drawing.Point(160, 315);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(84, 30);
            this.btn_SignUp.TabIndex = 11;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_LogIn.Location = new System.Drawing.Point(160, 265);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(84, 30);
            this.btn_LogIn.TabIndex = 10;
            this.btn_LogIn.Text = "登陆";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Password.Location = new System.Drawing.Point(160, 197);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '☠';
            this.txb_Password.Size = new System.Drawing.Size(176, 28);
            this.txb_Password.TabIndex = 9;
            this.txb_Password.Text = "11";
            this.txb_Password.UseSystemPasswordChar = true;
            // 
            // txb_No
            // 
            this.txb_No.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_No.Location = new System.Drawing.Point(160, 138);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(176, 28);
            this.txb_No.TabIndex = 8;
            this.txb_No.Text = "3190707011";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(85, 196);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 20);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_No.Location = new System.Drawing.Point(85, 137);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(69, 20);
            this.lbl_No.TabIndex = 6;
            this.lbl_No.Text = "账号：";
            // 
            // gpb_Docter
            // 
            this.gpb_Docter.Controls.Add(this.btn_DoctorLogIn);
            this.gpb_Docter.Controls.Add(this.txb_DoctorPassword);
            this.gpb_Docter.Controls.Add(this.txb_DoctorID);
            this.gpb_Docter.Controls.Add(this.label1);
            this.gpb_Docter.Controls.Add(this.label2);
            this.gpb_Docter.Location = new System.Drawing.Point(36, 73);
            this.gpb_Docter.Name = "gpb_Docter";
            this.gpb_Docter.Size = new System.Drawing.Size(409, 483);
            this.gpb_Docter.TabIndex = 12;
            this.gpb_Docter.TabStop = false;
            this.gpb_Docter.Text = "医生登陆";
            this.gpb_Docter.Visible = false;
            // 
            // btn_DoctorLogIn
            // 
            this.btn_DoctorLogIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DoctorLogIn.Location = new System.Drawing.Point(160, 265);
            this.btn_DoctorLogIn.Name = "btn_DoctorLogIn";
            this.btn_DoctorLogIn.Size = new System.Drawing.Size(84, 30);
            this.btn_DoctorLogIn.TabIndex = 10;
            this.btn_DoctorLogIn.Text = "登陆";
            this.btn_DoctorLogIn.UseVisualStyleBackColor = true;
            this.btn_DoctorLogIn.Click += new System.EventHandler(this.btn_DoctorLogIn_Click);
            // 
            // txb_DoctorPassword
            // 
            this.txb_DoctorPassword.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_DoctorPassword.Location = new System.Drawing.Point(160, 197);
            this.txb_DoctorPassword.Name = "txb_DoctorPassword";
            this.txb_DoctorPassword.PasswordChar = '*';
            this.txb_DoctorPassword.Size = new System.Drawing.Size(176, 28);
            this.txb_DoctorPassword.TabIndex = 9;
            this.txb_DoctorPassword.Text = "1";
            this.txb_DoctorPassword.UseSystemPasswordChar = true;
            // 
            // txb_DoctorID
            // 
            this.txb_DoctorID.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_DoctorID.Location = new System.Drawing.Point(160, 138);
            this.txb_DoctorID.Name = "txb_DoctorID";
            this.txb_DoctorID.Size = new System.Drawing.Size(176, 28);
            this.txb_DoctorID.TabIndex = 8;
            this.txb_DoctorID.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(85, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "账号：";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(496, 616);
            this.Controls.Add(this.gpb_Docter);
            this.Controls.Add(this.gpb_User);
            this.Controls.Add(this.btn_Docter);
            this.Controls.Add(this.btn_User);
            this.Name = "frm_LogIn";
            this.Text = "登陆";
            this.gpb_User.ResumeLayout(false);
            this.gpb_User.PerformLayout();
            this.gpb_Docter.ResumeLayout(false);
            this.gpb_Docter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Docter;
        private System.Windows.Forms.GroupBox gpb_User;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.GroupBox gpb_Docter;
        private System.Windows.Forms.Button btn_DoctorLogIn;
        private System.Windows.Forms.TextBox txb_DoctorPassword;
        private System.Windows.Forms.TextBox txb_DoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}