namespace OutpatientSystem
{
    partial class frm_ChangeNumber
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.gbx_PatientInformation = new System.Windows.Forms.GroupBox();
            this.txb_Age = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txb_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.gbx_OldInformation = new System.Windows.Forms.GroupBox();
            this.cmb_OldDoctor = new System.Windows.Forms.ComboBox();
            this.cmb_OldIndication = new System.Windows.Forms.ComboBox();
            this.cmb_OldNoon = new System.Windows.Forms.ComboBox();
            this.lbl_OldNoon = new System.Windows.Forms.Label();
            this.dtp_OldDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_OldDate = new System.Windows.Forms.Label();
            this.lbl_OldDoctor = new System.Windows.Forms.Label();
            this.lbl_OldIndication = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Doctor = new System.Windows.Forms.ComboBox();
            this.cmb_Indication = new System.Windows.Forms.ComboBox();
            this.cmb_Noon = new System.Windows.Forms.ComboBox();
            this.lbl_Noon = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Doctor = new System.Windows.Forms.Label();
            this.lbl_Indication = new System.Windows.Forms.Label();
            this.gbx_PatientInformation.SuspendLayout();
            this.gbx_OldInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.White;
            this.btn_Confirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Confirm.Location = new System.Drawing.Point(12, 12);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(99, 49);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "确定";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.Location = new System.Drawing.Point(105, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 49);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // gbx_PatientInformation
            // 
            this.gbx_PatientInformation.Controls.Add(this.txb_Age);
            this.gbx_PatientInformation.Controls.Add(this.lbl_Age);
            this.gbx_PatientInformation.Controls.Add(this.txb_Gender);
            this.gbx_PatientInformation.Controls.Add(this.lbl_Gender);
            this.gbx_PatientInformation.Controls.Add(this.txb_Name);
            this.gbx_PatientInformation.Controls.Add(this.txb_Account);
            this.gbx_PatientInformation.Controls.Add(this.lbl_Name);
            this.gbx_PatientInformation.Controls.Add(this.lbl_Account);
            this.gbx_PatientInformation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbx_PatientInformation.Location = new System.Drawing.Point(12, 68);
            this.gbx_PatientInformation.Name = "gbx_PatientInformation";
            this.gbx_PatientInformation.Size = new System.Drawing.Size(698, 147);
            this.gbx_PatientInformation.TabIndex = 5;
            this.gbx_PatientInformation.TabStop = false;
            this.gbx_PatientInformation.Text = "患者信息";
            // 
            // txb_Age
            // 
            this.txb_Age.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Age.Location = new System.Drawing.Point(564, 92);
            this.txb_Age.Name = "txb_Age";
            this.txb_Age.Size = new System.Drawing.Size(119, 34);
            this.txb_Age.TabIndex = 7;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Age.Location = new System.Drawing.Point(496, 101);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(62, 25);
            this.lbl_Age.TabIndex = 6;
            this.lbl_Age.Text = "年龄";
            // 
            // txb_Gender
            // 
            this.txb_Gender.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Gender.Location = new System.Drawing.Point(338, 92);
            this.txb_Gender.Name = "txb_Gender";
            this.txb_Gender.Size = new System.Drawing.Size(119, 34);
            this.txb_Gender.TabIndex = 5;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(270, 101);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(62, 25);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "性别";
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Name.Location = new System.Drawing.Point(118, 92);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(119, 34);
            this.txb_Name.TabIndex = 3;
            // 
            // txb_Account
            // 
            this.txb_Account.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Account.Location = new System.Drawing.Point(251, 26);
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(328, 34);
            this.txb_Account.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(50, 101);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(62, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "姓名";
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Account.Location = new System.Drawing.Point(133, 35);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(112, 25);
            this.lbl_Account.TabIndex = 0;
            this.lbl_Account.Text = "就诊账号";
            // 
            // gbx_OldInformation
            // 
            this.gbx_OldInformation.Controls.Add(this.cmb_OldDoctor);
            this.gbx_OldInformation.Controls.Add(this.cmb_OldIndication);
            this.gbx_OldInformation.Controls.Add(this.cmb_OldNoon);
            this.gbx_OldInformation.Controls.Add(this.lbl_OldNoon);
            this.gbx_OldInformation.Controls.Add(this.dtp_OldDate);
            this.gbx_OldInformation.Controls.Add(this.lbl_OldDate);
            this.gbx_OldInformation.Controls.Add(this.lbl_OldDoctor);
            this.gbx_OldInformation.Controls.Add(this.lbl_OldIndication);
            this.gbx_OldInformation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbx_OldInformation.Location = new System.Drawing.Point(12, 231);
            this.gbx_OldInformation.Name = "gbx_OldInformation";
            this.gbx_OldInformation.Size = new System.Drawing.Size(698, 208);
            this.gbx_OldInformation.TabIndex = 8;
            this.gbx_OldInformation.TabStop = false;
            this.gbx_OldInformation.Text = "原挂号信息";
            // 
            // cmb_OldDoctor
            // 
            this.cmb_OldDoctor.Enabled = false;
            this.cmb_OldDoctor.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_OldDoctor.FormattingEnabled = true;
            this.cmb_OldDoctor.Location = new System.Drawing.Point(446, 46);
            this.cmb_OldDoctor.Name = "cmb_OldDoctor";
            this.cmb_OldDoctor.Size = new System.Drawing.Size(197, 31);
            this.cmb_OldDoctor.TabIndex = 10;
            // 
            // cmb_OldIndication
            // 
            this.cmb_OldIndication.Enabled = false;
            this.cmb_OldIndication.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_OldIndication.FormattingEnabled = true;
            this.cmb_OldIndication.Location = new System.Drawing.Point(105, 46);
            this.cmb_OldIndication.Name = "cmb_OldIndication";
            this.cmb_OldIndication.Size = new System.Drawing.Size(197, 31);
            this.cmb_OldIndication.TabIndex = 9;
            // 
            // cmb_OldNoon
            // 
            this.cmb_OldNoon.Enabled = false;
            this.cmb_OldNoon.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_OldNoon.FormattingEnabled = true;
            this.cmb_OldNoon.Location = new System.Drawing.Point(446, 133);
            this.cmb_OldNoon.Name = "cmb_OldNoon";
            this.cmb_OldNoon.Size = new System.Drawing.Size(197, 31);
            this.cmb_OldNoon.TabIndex = 8;
            // 
            // lbl_OldNoon
            // 
            this.lbl_OldNoon.AutoSize = true;
            this.lbl_OldNoon.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OldNoon.Location = new System.Drawing.Point(378, 133);
            this.lbl_OldNoon.Name = "lbl_OldNoon";
            this.lbl_OldNoon.Size = new System.Drawing.Size(62, 25);
            this.lbl_OldNoon.TabIndex = 7;
            this.lbl_OldNoon.Text = "午别";
            // 
            // dtp_OldDate
            // 
            this.dtp_OldDate.Enabled = false;
            this.dtp_OldDate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_OldDate.Location = new System.Drawing.Point(102, 130);
            this.dtp_OldDate.Name = "dtp_OldDate";
            this.dtp_OldDate.Size = new System.Drawing.Size(200, 34);
            this.dtp_OldDate.TabIndex = 6;
            // 
            // lbl_OldDate
            // 
            this.lbl_OldDate.AutoSize = true;
            this.lbl_OldDate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OldDate.Location = new System.Drawing.Point(37, 133);
            this.lbl_OldDate.Name = "lbl_OldDate";
            this.lbl_OldDate.Size = new System.Drawing.Size(62, 25);
            this.lbl_OldDate.TabIndex = 5;
            this.lbl_OldDate.Text = "日期";
            // 
            // lbl_OldDoctor
            // 
            this.lbl_OldDoctor.AutoSize = true;
            this.lbl_OldDoctor.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OldDoctor.Location = new System.Drawing.Point(378, 48);
            this.lbl_OldDoctor.Name = "lbl_OldDoctor";
            this.lbl_OldDoctor.Size = new System.Drawing.Size(62, 25);
            this.lbl_OldDoctor.TabIndex = 3;
            this.lbl_OldDoctor.Text = "医师";
            // 
            // lbl_OldIndication
            // 
            this.lbl_OldIndication.AutoSize = true;
            this.lbl_OldIndication.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OldIndication.Location = new System.Drawing.Point(37, 48);
            this.lbl_OldIndication.Name = "lbl_OldIndication";
            this.lbl_OldIndication.Size = new System.Drawing.Size(62, 25);
            this.lbl_OldIndication.TabIndex = 0;
            this.lbl_OldIndication.Text = "科室";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Doctor);
            this.groupBox1.Controls.Add(this.cmb_Indication);
            this.groupBox1.Controls.Add(this.cmb_Noon);
            this.groupBox1.Controls.Add(this.lbl_Noon);
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.lbl_Doctor);
            this.groupBox1.Controls.Add(this.lbl_Indication);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 208);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "现挂号信息";
            // 
            // cmb_Doctor
            // 
            this.cmb_Doctor.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Doctor.Location = new System.Drawing.Point(446, 46);
            this.cmb_Doctor.Name = "cmb_Doctor";
            this.cmb_Doctor.Size = new System.Drawing.Size(197, 31);
            this.cmb_Doctor.TabIndex = 10;
            // 
            // cmb_Indication
            // 
            this.cmb_Indication.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Indication.FormattingEnabled = true;
            this.cmb_Indication.Location = new System.Drawing.Point(105, 46);
            this.cmb_Indication.Name = "cmb_Indication";
            this.cmb_Indication.Size = new System.Drawing.Size(197, 31);
            this.cmb_Indication.TabIndex = 9;
            this.cmb_Indication.SelectedIndexChanged += new System.EventHandler(this.cmb_Indication_SelectedIndexChanged);
            // 
            // cmb_Noon
            // 
            this.cmb_Noon.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Noon.FormattingEnabled = true;
            this.cmb_Noon.Items.AddRange(new object[] {
            "上午",
            "下午"});
            this.cmb_Noon.Location = new System.Drawing.Point(446, 133);
            this.cmb_Noon.Name = "cmb_Noon";
            this.cmb_Noon.Size = new System.Drawing.Size(197, 31);
            this.cmb_Noon.TabIndex = 8;
            // 
            // lbl_Noon
            // 
            this.lbl_Noon.AutoSize = true;
            this.lbl_Noon.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Noon.Location = new System.Drawing.Point(378, 133);
            this.lbl_Noon.Name = "lbl_Noon";
            this.lbl_Noon.Size = new System.Drawing.Size(62, 25);
            this.lbl_Noon.TabIndex = 7;
            this.lbl_Noon.Text = "午别";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Date.Location = new System.Drawing.Point(102, 130);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 34);
            this.dtp_Date.TabIndex = 6;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Date.Location = new System.Drawing.Point(37, 133);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(62, 25);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "日期";
            // 
            // lbl_Doctor
            // 
            this.lbl_Doctor.AutoSize = true;
            this.lbl_Doctor.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Doctor.Location = new System.Drawing.Point(378, 48);
            this.lbl_Doctor.Name = "lbl_Doctor";
            this.lbl_Doctor.Size = new System.Drawing.Size(62, 25);
            this.lbl_Doctor.TabIndex = 3;
            this.lbl_Doctor.Text = "医师";
            // 
            // lbl_Indication
            // 
            this.lbl_Indication.AutoSize = true;
            this.lbl_Indication.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Indication.Location = new System.Drawing.Point(37, 48);
            this.lbl_Indication.Name = "lbl_Indication";
            this.lbl_Indication.Size = new System.Drawing.Size(62, 25);
            this.lbl_Indication.TabIndex = 0;
            this.lbl_Indication.Text = "科室";
            // 
            // frm_ChangeNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_OldInformation);
            this.Controls.Add(this.gbx_PatientInformation);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "frm_ChangeNumber";
            this.Text = "换号";
            this.gbx_PatientInformation.ResumeLayout(false);
            this.gbx_PatientInformation.PerformLayout();
            this.gbx_OldInformation.ResumeLayout(false);
            this.gbx_OldInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox gbx_PatientInformation;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.TextBox txb_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txb_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.GroupBox gbx_OldInformation;
        private System.Windows.Forms.Label lbl_OldIndication;
        private System.Windows.Forms.Label lbl_OldDoctor;
        private System.Windows.Forms.ComboBox cmb_OldNoon;
        private System.Windows.Forms.Label lbl_OldNoon;
        private System.Windows.Forms.DateTimePicker dtp_OldDate;
        private System.Windows.Forms.Label lbl_OldDate;
        private System.Windows.Forms.ComboBox cmb_OldDoctor;
        private System.Windows.Forms.ComboBox cmb_OldIndication;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Doctor;
        private System.Windows.Forms.ComboBox cmb_Indication;
        private System.Windows.Forms.ComboBox cmb_Noon;
        private System.Windows.Forms.Label lbl_Noon;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Doctor;
        private System.Windows.Forms.Label lbl_Indication;
    }
}