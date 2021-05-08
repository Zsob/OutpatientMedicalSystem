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
            this.锁定ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.更改操作员口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.患者列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabC_Diagnosis = new System.Windows.Forms.TabControl();
            this.tabP_PatientList = new System.Windows.Forms.TabPage();
            this.dgv_Patient = new System.Windows.Forms.DataGridView();
            this.grb_PatientInformatiom = new System.Windows.Forms.GroupBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txb_Age = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txb_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txb_PatientName = new System.Windows.Forms.TextBox();
            this.lbl_PatientName = new System.Windows.Forms.Label();
            this.tabP_Diagnosis = new System.Windows.Forms.TabPage();
            this.tabP_DoctorsOrder = new System.Windows.Forms.TabPage();
            this.btn_Fresh = new System.Windows.Forms.Button();
            this.btn_ChangeNumber = new System.Windows.Forms.Button();
            this.btn_Admission = new System.Windows.Forms.Button();
            this.btn_CancelAppointment = new System.Windows.Forms.Button();
            this.btn_AdmissionNotice = new System.Windows.Forms.Button();
            this.btn_EndOfVisit = new System.Windows.Forms.Button();
            this.btn_Appointment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.ptb_Photo = new System.Windows.Forms.PictureBox();
            this.mns_Doctor.SuspendLayout();
            this.tabC_Diagnosis.SuspendLayout();
            this.tabP_PatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.grb_PatientInformatiom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_Doctor
            // 
            this.mns_Doctor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mns_Doctor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_Doctor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.锁定ToolStripMenuItem,
            this.患者列表ToolStripMenuItem,
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
            // 患者列表ToolStripMenuItem
            // 
            this.患者列表ToolStripMenuItem.Name = "患者列表ToolStripMenuItem";
            this.患者列表ToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.患者列表ToolStripMenuItem.Text = "患者列表";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // tabC_Diagnosis
            // 
            this.tabC_Diagnosis.Controls.Add(this.tabP_PatientList);
            this.tabC_Diagnosis.Controls.Add(this.tabP_Diagnosis);
            this.tabC_Diagnosis.Controls.Add(this.tabP_DoctorsOrder);
            this.tabC_Diagnosis.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabC_Diagnosis.Location = new System.Drawing.Point(0, 107);
            this.tabC_Diagnosis.Name = "tabC_Diagnosis";
            this.tabC_Diagnosis.SelectedIndex = 0;
            this.tabC_Diagnosis.Size = new System.Drawing.Size(1091, 570);
            this.tabC_Diagnosis.TabIndex = 1;
            // 
            // tabP_PatientList
            // 
            this.tabP_PatientList.Controls.Add(this.dgv_Patient);
            this.tabP_PatientList.Controls.Add(this.grb_PatientInformatiom);
            this.tabP_PatientList.Location = new System.Drawing.Point(4, 30);
            this.tabP_PatientList.Name = "tabP_PatientList";
            this.tabP_PatientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_PatientList.Size = new System.Drawing.Size(1083, 536);
            this.tabP_PatientList.TabIndex = 0;
            this.tabP_PatientList.Text = "患者列表";
            this.tabP_PatientList.UseVisualStyleBackColor = true;
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.AllowUserToAddRows = false;
            this.dgv_Patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Patient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(6, 6);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.ReadOnly = true;
            this.dgv_Patient.RowTemplate.Height = 27;
            this.dgv_Patient.Size = new System.Drawing.Size(709, 512);
            this.dgv_Patient.TabIndex = 1;
            this.dgv_Patient.TabStop = false;
            this.dgv_Patient.Click += new System.EventHandler(this.dgv_Patient_Click);
            // 
            // grb_PatientInformatiom
            // 
            this.grb_PatientInformatiom.Controls.Add(this.ptb_Photo);
            this.grb_PatientInformatiom.Controls.Add(this.txb_Phone);
            this.grb_PatientInformatiom.Controls.Add(this.lbl_Phone);
            this.grb_PatientInformatiom.Controls.Add(this.txb_Age);
            this.grb_PatientInformatiom.Controls.Add(this.lbl_Age);
            this.grb_PatientInformatiom.Controls.Add(this.txb_Gender);
            this.grb_PatientInformatiom.Controls.Add(this.lbl_Gender);
            this.grb_PatientInformatiom.Controls.Add(this.txb_PatientName);
            this.grb_PatientInformatiom.Controls.Add(this.lbl_PatientName);
            this.grb_PatientInformatiom.Location = new System.Drawing.Point(724, 17);
            this.grb_PatientInformatiom.Name = "grb_PatientInformatiom";
            this.grb_PatientInformatiom.Size = new System.Drawing.Size(339, 501);
            this.grb_PatientInformatiom.TabIndex = 0;
            this.grb_PatientInformatiom.TabStop = false;
            this.grb_PatientInformatiom.Text = "患者挂号信息";
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(124, 228);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.ReadOnly = true;
            this.txb_Phone.Size = new System.Drawing.Size(204, 30);
            this.txb_Phone.TabIndex = 7;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Phone.Location = new System.Drawing.Point(56, 232);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(62, 25);
            this.lbl_Phone.TabIndex = 6;
            this.lbl_Phone.Text = "电话";
            // 
            // txb_Age
            // 
            this.txb_Age.Location = new System.Drawing.Point(124, 176);
            this.txb_Age.Name = "txb_Age";
            this.txb_Age.ReadOnly = true;
            this.txb_Age.Size = new System.Drawing.Size(204, 30);
            this.txb_Age.TabIndex = 5;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Age.Location = new System.Drawing.Point(56, 180);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(62, 25);
            this.lbl_Age.TabIndex = 4;
            this.lbl_Age.Text = "年龄";
            // 
            // txb_Gender
            // 
            this.txb_Gender.Location = new System.Drawing.Point(124, 125);
            this.txb_Gender.Name = "txb_Gender";
            this.txb_Gender.ReadOnly = true;
            this.txb_Gender.Size = new System.Drawing.Size(204, 30);
            this.txb_Gender.TabIndex = 3;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(56, 129);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(62, 25);
            this.lbl_Gender.TabIndex = 2;
            this.lbl_Gender.Text = "性别";
            // 
            // txb_PatientName
            // 
            this.txb_PatientName.Location = new System.Drawing.Point(124, 77);
            this.txb_PatientName.Name = "txb_PatientName";
            this.txb_PatientName.ReadOnly = true;
            this.txb_PatientName.Size = new System.Drawing.Size(204, 30);
            this.txb_PatientName.TabIndex = 1;
            // 
            // lbl_PatientName
            // 
            this.lbl_PatientName.AutoSize = true;
            this.lbl_PatientName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PatientName.Location = new System.Drawing.Point(6, 82);
            this.lbl_PatientName.Name = "lbl_PatientName";
            this.lbl_PatientName.Size = new System.Drawing.Size(112, 25);
            this.lbl_PatientName.TabIndex = 0;
            this.lbl_PatientName.Text = "患者姓名";
            // 
            // tabP_Diagnosis
            // 
            this.tabP_Diagnosis.Location = new System.Drawing.Point(4, 30);
            this.tabP_Diagnosis.Name = "tabP_Diagnosis";
            this.tabP_Diagnosis.Size = new System.Drawing.Size(1083, 536);
            this.tabP_Diagnosis.TabIndex = 1;
            this.tabP_Diagnosis.Text = "诊断";
            this.tabP_Diagnosis.UseVisualStyleBackColor = true;
            // 
            // tabP_DoctorsOrder
            // 
            this.tabP_DoctorsOrder.Location = new System.Drawing.Point(4, 30);
            this.tabP_DoctorsOrder.Name = "tabP_DoctorsOrder";
            this.tabP_DoctorsOrder.Size = new System.Drawing.Size(1083, 536);
            this.tabP_DoctorsOrder.TabIndex = 2;
            this.tabP_DoctorsOrder.Text = "医嘱";
            this.tabP_DoctorsOrder.UseVisualStyleBackColor = true;
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.BackColor = System.Drawing.Color.White;
            this.btn_Fresh.Location = new System.Drawing.Point(12, 52);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(99, 49);
            this.btn_Fresh.TabIndex = 2;
            this.btn_Fresh.Text = "刷新";
            this.btn_Fresh.UseVisualStyleBackColor = false;
            // 
            // btn_ChangeNumber
            // 
            this.btn_ChangeNumber.BackColor = System.Drawing.Color.White;
            this.btn_ChangeNumber.Location = new System.Drawing.Point(111, 52);
            this.btn_ChangeNumber.Name = "btn_ChangeNumber";
            this.btn_ChangeNumber.Size = new System.Drawing.Size(99, 49);
            this.btn_ChangeNumber.TabIndex = 3;
            this.btn_ChangeNumber.Text = "换号";
            this.btn_ChangeNumber.UseVisualStyleBackColor = false;
            // 
            // btn_Admission
            // 
            this.btn_Admission.BackColor = System.Drawing.Color.White;
            this.btn_Admission.Location = new System.Drawing.Point(210, 52);
            this.btn_Admission.Name = "btn_Admission";
            this.btn_Admission.Size = new System.Drawing.Size(99, 49);
            this.btn_Admission.TabIndex = 4;
            this.btn_Admission.Text = "接诊";
            this.btn_Admission.UseVisualStyleBackColor = false;
            this.btn_Admission.Click += new System.EventHandler(this.btn_Admission_Click);
            // 
            // btn_CancelAppointment
            // 
            this.btn_CancelAppointment.BackColor = System.Drawing.Color.White;
            this.btn_CancelAppointment.Location = new System.Drawing.Point(309, 52);
            this.btn_CancelAppointment.Name = "btn_CancelAppointment";
            this.btn_CancelAppointment.Size = new System.Drawing.Size(99, 49);
            this.btn_CancelAppointment.TabIndex = 5;
            this.btn_CancelAppointment.Text = "取消接诊";
            this.btn_CancelAppointment.UseVisualStyleBackColor = false;
            // 
            // btn_AdmissionNotice
            // 
            this.btn_AdmissionNotice.BackColor = System.Drawing.Color.White;
            this.btn_AdmissionNotice.Location = new System.Drawing.Point(408, 52);
            this.btn_AdmissionNotice.Name = "btn_AdmissionNotice";
            this.btn_AdmissionNotice.Size = new System.Drawing.Size(99, 49);
            this.btn_AdmissionNotice.TabIndex = 6;
            this.btn_AdmissionNotice.Text = "入院通知";
            this.btn_AdmissionNotice.UseVisualStyleBackColor = false;
            // 
            // btn_EndOfVisit
            // 
            this.btn_EndOfVisit.BackColor = System.Drawing.Color.White;
            this.btn_EndOfVisit.Location = new System.Drawing.Point(507, 52);
            this.btn_EndOfVisit.Name = "btn_EndOfVisit";
            this.btn_EndOfVisit.Size = new System.Drawing.Size(99, 49);
            this.btn_EndOfVisit.TabIndex = 7;
            this.btn_EndOfVisit.Text = "结束就诊";
            this.btn_EndOfVisit.UseVisualStyleBackColor = false;
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.BackColor = System.Drawing.Color.White;
            this.btn_Appointment.Location = new System.Drawing.Point(606, 52);
            this.btn_Appointment.Name = "btn_Appointment";
            this.btn_Appointment.Size = new System.Drawing.Size(99, 49);
            this.btn_Appointment.TabIndex = 8;
            this.btn_Appointment.Text = "预约";
            this.btn_Appointment.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(705, 52);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 49);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // ptb_Photo
            // 
            this.ptb_Photo.Location = new System.Drawing.Point(74, 292);
            this.ptb_Photo.Name = "ptb_Photo";
            this.ptb_Photo.Size = new System.Drawing.Size(228, 180);
            this.ptb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Photo.TabIndex = 8;
            this.ptb_Photo.TabStop = false;
            // 
            // frm_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 689);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Appointment);
            this.Controls.Add(this.btn_EndOfVisit);
            this.Controls.Add(this.btn_AdmissionNotice);
            this.Controls.Add(this.btn_CancelAppointment);
            this.Controls.Add(this.btn_Admission);
            this.Controls.Add(this.btn_ChangeNumber);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.tabC_Diagnosis);
            this.Controls.Add(this.mns_Doctor);
            this.MainMenuStrip = this.mns_Doctor;
            this.Name = "frm_Doctor";
            this.Text = "医生系统";
            this.mns_Doctor.ResumeLayout(false);
            this.mns_Doctor.PerformLayout();
            this.tabC_Diagnosis.ResumeLayout(false);
            this.tabP_PatientList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.grb_PatientInformatiom.ResumeLayout(false);
            this.grb_PatientInformatiom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_Doctor;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 更改操作员口令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 患者列表ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabC_Diagnosis;
        private System.Windows.Forms.TabPage tabP_PatientList;
        private System.Windows.Forms.GroupBox grb_PatientInformatiom;
        private System.Windows.Forms.TextBox txb_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txb_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox txb_PatientName;
        private System.Windows.Forms.Label lbl_PatientName;
        private System.Windows.Forms.TabPage tabP_Diagnosis;
        private System.Windows.Forms.TabPage tabP_DoctorsOrder;
        private System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Button btn_Fresh;
        private System.Windows.Forms.Button btn_ChangeNumber;
        private System.Windows.Forms.Button btn_Admission;
        private System.Windows.Forms.Button btn_CancelAppointment;
        private System.Windows.Forms.Button btn_AdmissionNotice;
        private System.Windows.Forms.Button btn_EndOfVisit;
        private System.Windows.Forms.Button btn_Appointment;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox ptb_Photo;
    }
}