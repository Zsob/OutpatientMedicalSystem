namespace OutpatientSystem
{
    partial class frm_MyImformation
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
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.lbl__Birthday = new System.Windows.Forms.Label();
            this.dtp_Birthday = new System.Windows.Forms.DateTimePicker();
            this.ptb_Photo = new System.Windows.Forms.PictureBox();
            this.btn_OpenPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Female.Location = new System.Drawing.Point(266, 94);
            this.rdb_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(58, 29);
            this.rdb_Female.TabIndex = 60;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "女";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Male.Location = new System.Drawing.Point(161, 96);
            this.rdb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(58, 29);
            this.rdb_Male.TabIndex = 59;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "男";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // txb_No
            // 
            this.txb_No.Enabled = false;
            this.txb_No.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_No.Location = new System.Drawing.Point(161, 13);
            this.txb_No.Margin = new System.Windows.Forms.Padding(4);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(263, 36);
            this.txb_No.TabIndex = 55;
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Name.Location = new System.Drawing.Point(161, 54);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(263, 36);
            this.txb_Name.TabIndex = 56;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Phone.Location = new System.Drawing.Point(161, 133);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(263, 36);
            this.txb_Phone.TabIndex = 57;
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_No.Location = new System.Drawing.Point(16, 13);
            this.lbl_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(137, 25);
            this.lbl_No.TabIndex = 49;
            this.lbl_No.Text = "身份证号：";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(66, 55);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(87, 25);
            this.lbl_Name.TabIndex = 50;
            this.lbl_Name.Text = "姓名：";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(66, 96);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(87, 25);
            this.lbl_Gender.TabIndex = 51;
            this.lbl_Gender.Text = "性别：";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Phone.Location = new System.Drawing.Point(41, 133);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(112, 25);
            this.lbl_Phone.TabIndex = 54;
            this.lbl_Phone.Text = "手机号：";
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Change.Location = new System.Drawing.Point(295, 380);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(129, 37);
            this.btn_Change.TabIndex = 61;
            this.btn_Change.Text = "修改";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // lbl__Birthday
            // 
            this.lbl__Birthday.AutoSize = true;
            this.lbl__Birthday.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl__Birthday.Location = new System.Drawing.Point(16, 176);
            this.lbl__Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl__Birthday.Name = "lbl__Birthday";
            this.lbl__Birthday.Size = new System.Drawing.Size(137, 25);
            this.lbl__Birthday.TabIndex = 62;
            this.lbl__Birthday.Text = "出生日期：";
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.CalendarFont = new System.Drawing.Font("宋体", 15F);
            this.dtp_Birthday.Font = new System.Drawing.Font("宋体", 15F);
            this.dtp_Birthday.Location = new System.Drawing.Point(161, 176);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.Size = new System.Drawing.Size(263, 36);
            this.dtp_Birthday.TabIndex = 63;
            // 
            // ptb_Photo
            // 
            this.ptb_Photo.Location = new System.Drawing.Point(21, 231);
            this.ptb_Photo.Name = "ptb_Photo";
            this.ptb_Photo.Size = new System.Drawing.Size(187, 143);
            this.ptb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Photo.TabIndex = 64;
            this.ptb_Photo.TabStop = false;
            // 
            // btn_OpenPhoto
            // 
            this.btn_OpenPhoto.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenPhoto.Location = new System.Drawing.Point(46, 380);
            this.btn_OpenPhoto.Name = "btn_OpenPhoto";
            this.btn_OpenPhoto.Size = new System.Drawing.Size(129, 37);
            this.btn_OpenPhoto.TabIndex = 65;
            this.btn_OpenPhoto.Text = "打开照片";
            this.btn_OpenPhoto.UseVisualStyleBackColor = true;
            this.btn_OpenPhoto.Click += new System.EventHandler(this.btn_OpenPhoto_Click);
            // 
            // frm_MyImformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 429);
            this.Controls.Add(this.btn_OpenPhoto);
            this.Controls.Add(this.ptb_Photo);
            this.Controls.Add(this.dtp_Birthday);
            this.Controls.Add(this.lbl__Birthday);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.rdb_Female);
            this.Controls.Add(this.rdb_Male);
            this.Controls.Add(this.txb_No);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Phone);
            this.Name = "frm_MyImformation";
            this.Text = "个人中心";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label lbl__Birthday;
        private System.Windows.Forms.DateTimePicker dtp_Birthday;
        private System.Windows.Forms.PictureBox ptb_Photo;
        private System.Windows.Forms.Button btn_OpenPhoto;
    }
}