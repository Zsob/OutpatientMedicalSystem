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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ptb_Photo = new System.Windows.Forms.PictureBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txb_Age = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txb_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txb_PatientName = new System.Windows.Forms.TextBox();
            this.lbl_PatientName = new System.Windows.Forms.Label();
            this.tabP_Diagnosis = new System.Windows.Forms.TabPage();
            this.btn_tab1_Save = new System.Windows.Forms.Button();
            this.btn_tab1_Delete = new System.Windows.Forms.Button();
            this.btn_tab1_Insert = new System.Windows.Forms.Button();
            this.gpb_Information = new System.Windows.Forms.GroupBox();
            this.txb_tab1_Age = new System.Windows.Forms.TextBox();
            this.lbl_tab1_Age = new System.Windows.Forms.Label();
            this.txb_tab1_Gender = new System.Windows.Forms.TextBox();
            this.lbl_tab1_Gender = new System.Windows.Forms.Label();
            this.txb_tab1_Name = new System.Windows.Forms.TextBox();
            this.lbl_tab1_Name = new System.Windows.Forms.Label();
            this.dgv_Diagnosis = new System.Windows.Forms.DataGridView();
            this.Column_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Disease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_DiagnosticDictionary = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.tvw_Diseases = new System.Windows.Forms.TreeView();
            this.tabP_DoctorsOrder = new System.Windows.Forms.TabPage();
            this.btn_tab2_Delete = new System.Windows.Forms.Button();
            this.btn_tab2_Insert = new System.Windows.Forms.Button();
            this.btn_tab2_Save = new System.Windows.Forms.Button();
            this.lbl_DoctorOrder = new System.Windows.Forms.Label();
            this.dgv_DoctorOrder = new System.Windows.Forms.DataGridView();
            this.Column_MedicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DrugDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Pack = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_Frequency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_FrequencyDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Pinyin = new System.Windows.Forms.TextBox();
            this.lbl_Pinyin = new System.Windows.Forms.Label();
            this.dgv_Medicines = new System.Windows.Forms.DataGridView();
            this.btn_Fresh = new System.Windows.Forms.Button();
            this.btn_ChangeNumber = new System.Windows.Forms.Button();
            this.btn_Admission = new System.Windows.Forms.Button();
            this.btn_CancelAppointment = new System.Windows.Forms.Button();
            this.btn_AdmissionNotice = new System.Windows.Forms.Button();
            this.btn_EndOfVisit = new System.Windows.Forms.Button();
            this.btn_Appointment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_tab1_Clear = new System.Windows.Forms.Button();
            this.mns_Doctor.SuspendLayout();
            this.tabC_Diagnosis.SuspendLayout();
            this.tabP_PatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.grb_PatientInformatiom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).BeginInit();
            this.tabP_Diagnosis.SuspendLayout();
            this.gpb_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diagnosis)).BeginInit();
            this.gpb_DiagnosticDictionary.SuspendLayout();
            this.tabP_DoctorsOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicines)).BeginInit();
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
            this.tabC_Diagnosis.SelectedIndexChanged += new System.EventHandler(this.tabC_Diagnosis_SelectedIndexChanged);
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
            this.dgv_Patient.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Patient_CellEnter);
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
            // ptb_Photo
            // 
            this.ptb_Photo.Location = new System.Drawing.Point(74, 292);
            this.ptb_Photo.Name = "ptb_Photo";
            this.ptb_Photo.Size = new System.Drawing.Size(228, 180);
            this.ptb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Photo.TabIndex = 8;
            this.ptb_Photo.TabStop = false;
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
            this.tabP_Diagnosis.Controls.Add(this.btn_tab1_Clear);
            this.tabP_Diagnosis.Controls.Add(this.btn_tab1_Save);
            this.tabP_Diagnosis.Controls.Add(this.btn_tab1_Delete);
            this.tabP_Diagnosis.Controls.Add(this.btn_tab1_Insert);
            this.tabP_Diagnosis.Controls.Add(this.gpb_Information);
            this.tabP_Diagnosis.Controls.Add(this.dgv_Diagnosis);
            this.tabP_Diagnosis.Controls.Add(this.gpb_DiagnosticDictionary);
            this.tabP_Diagnosis.Location = new System.Drawing.Point(4, 30);
            this.tabP_Diagnosis.Name = "tabP_Diagnosis";
            this.tabP_Diagnosis.Size = new System.Drawing.Size(1083, 536);
            this.tabP_Diagnosis.TabIndex = 1;
            this.tabP_Diagnosis.Text = "诊断";
            this.tabP_Diagnosis.UseVisualStyleBackColor = true;
            // 
            // btn_tab1_Save
            // 
            this.btn_tab1_Save.BackColor = System.Drawing.Color.White;
            this.btn_tab1_Save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tab1_Save.Location = new System.Drawing.Point(981, 464);
            this.btn_tab1_Save.Name = "btn_tab1_Save";
            this.btn_tab1_Save.Size = new System.Drawing.Size(99, 49);
            this.btn_tab1_Save.TabIndex = 12;
            this.btn_tab1_Save.TabStop = false;
            this.btn_tab1_Save.Text = "保存";
            this.btn_tab1_Save.UseVisualStyleBackColor = false;
            this.btn_tab1_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_tab1_Delete
            // 
            this.btn_tab1_Delete.BackColor = System.Drawing.Color.White;
            this.btn_tab1_Delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tab1_Delete.Location = new System.Drawing.Point(981, 160);
            this.btn_tab1_Delete.Name = "btn_tab1_Delete";
            this.btn_tab1_Delete.Size = new System.Drawing.Size(99, 49);
            this.btn_tab1_Delete.TabIndex = 11;
            this.btn_tab1_Delete.TabStop = false;
            this.btn_tab1_Delete.Text = "删除";
            this.btn_tab1_Delete.UseVisualStyleBackColor = false;
            this.btn_tab1_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_tab1_Insert
            // 
            this.btn_tab1_Insert.BackColor = System.Drawing.Color.White;
            this.btn_tab1_Insert.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tab1_Insert.Location = new System.Drawing.Point(981, 105);
            this.btn_tab1_Insert.Name = "btn_tab1_Insert";
            this.btn_tab1_Insert.Size = new System.Drawing.Size(99, 49);
            this.btn_tab1_Insert.TabIndex = 10;
            this.btn_tab1_Insert.TabStop = false;
            this.btn_tab1_Insert.Text = "插入";
            this.btn_tab1_Insert.UseVisualStyleBackColor = false;
            this.btn_tab1_Insert.Click += new System.EventHandler(this.tvw_Diseases_DoubleClick);
            // 
            // gpb_Information
            // 
            this.gpb_Information.Controls.Add(this.txb_tab1_Age);
            this.gpb_Information.Controls.Add(this.lbl_tab1_Age);
            this.gpb_Information.Controls.Add(this.txb_tab1_Gender);
            this.gpb_Information.Controls.Add(this.lbl_tab1_Gender);
            this.gpb_Information.Controls.Add(this.txb_tab1_Name);
            this.gpb_Information.Controls.Add(this.lbl_tab1_Name);
            this.gpb_Information.Location = new System.Drawing.Point(355, 4);
            this.gpb_Information.Name = "gpb_Information";
            this.gpb_Information.Size = new System.Drawing.Size(720, 85);
            this.gpb_Information.TabIndex = 2;
            this.gpb_Information.TabStop = false;
            this.gpb_Information.Text = "患者信息";
            // 
            // txb_tab1_Age
            // 
            this.txb_tab1_Age.Location = new System.Drawing.Point(594, 30);
            this.txb_tab1_Age.Name = "txb_tab1_Age";
            this.txb_tab1_Age.ReadOnly = true;
            this.txb_tab1_Age.Size = new System.Drawing.Size(84, 30);
            this.txb_tab1_Age.TabIndex = 9;
            // 
            // lbl_tab1_Age
            // 
            this.lbl_tab1_Age.AutoSize = true;
            this.lbl_tab1_Age.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tab1_Age.Location = new System.Drawing.Point(526, 35);
            this.lbl_tab1_Age.Name = "lbl_tab1_Age";
            this.lbl_tab1_Age.Size = new System.Drawing.Size(62, 25);
            this.lbl_tab1_Age.TabIndex = 8;
            this.lbl_tab1_Age.Text = "年龄";
            // 
            // txb_tab1_Gender
            // 
            this.txb_tab1_Gender.Location = new System.Drawing.Point(421, 30);
            this.txb_tab1_Gender.Name = "txb_tab1_Gender";
            this.txb_tab1_Gender.ReadOnly = true;
            this.txb_tab1_Gender.Size = new System.Drawing.Size(59, 30);
            this.txb_tab1_Gender.TabIndex = 7;
            // 
            // lbl_tab1_Gender
            // 
            this.lbl_tab1_Gender.AutoSize = true;
            this.lbl_tab1_Gender.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tab1_Gender.Location = new System.Drawing.Point(353, 35);
            this.lbl_tab1_Gender.Name = "lbl_tab1_Gender";
            this.lbl_tab1_Gender.Size = new System.Drawing.Size(62, 25);
            this.lbl_tab1_Gender.TabIndex = 6;
            this.lbl_tab1_Gender.Text = "性别";
            // 
            // txb_tab1_Name
            // 
            this.txb_tab1_Name.Location = new System.Drawing.Point(159, 30);
            this.txb_tab1_Name.Name = "txb_tab1_Name";
            this.txb_tab1_Name.ReadOnly = true;
            this.txb_tab1_Name.Size = new System.Drawing.Size(157, 30);
            this.txb_tab1_Name.TabIndex = 2;
            // 
            // lbl_tab1_Name
            // 
            this.lbl_tab1_Name.AutoSize = true;
            this.lbl_tab1_Name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tab1_Name.Location = new System.Drawing.Point(86, 35);
            this.lbl_tab1_Name.Name = "lbl_tab1_Name";
            this.lbl_tab1_Name.Size = new System.Drawing.Size(62, 25);
            this.lbl_tab1_Name.TabIndex = 1;
            this.lbl_tab1_Name.Text = "姓名";
            // 
            // dgv_Diagnosis
            // 
            this.dgv_Diagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Diagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Diagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_No,
            this.Column_Disease});
            this.dgv_Diagnosis.Location = new System.Drawing.Point(355, 95);
            this.dgv_Diagnosis.Name = "dgv_Diagnosis";
            this.dgv_Diagnosis.ReadOnly = true;
            this.dgv_Diagnosis.RowTemplate.Height = 27;
            this.dgv_Diagnosis.Size = new System.Drawing.Size(614, 427);
            this.dgv_Diagnosis.TabIndex = 1;
            this.dgv_Diagnosis.TabStop = false;
            this.dgv_Diagnosis.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_Diagnosis_ColumnAdded);
            // 
            // Column_No
            // 
            this.Column_No.HeaderText = "序号";
            this.Column_No.Name = "Column_No";
            this.Column_No.ReadOnly = true;
            // 
            // Column_Disease
            // 
            this.Column_Disease.HeaderText = "病症";
            this.Column_Disease.Name = "Column_Disease";
            this.Column_Disease.ReadOnly = true;
            // 
            // gpb_DiagnosticDictionary
            // 
            this.gpb_DiagnosticDictionary.Controls.Add(this.btn_Search);
            this.gpb_DiagnosticDictionary.Controls.Add(this.txb_Search);
            this.gpb_DiagnosticDictionary.Controls.Add(this.tvw_Diseases);
            this.gpb_DiagnosticDictionary.Location = new System.Drawing.Point(4, 4);
            this.gpb_DiagnosticDictionary.Name = "gpb_DiagnosticDictionary";
            this.gpb_DiagnosticDictionary.Size = new System.Drawing.Size(331, 529);
            this.gpb_DiagnosticDictionary.TabIndex = 0;
            this.gpb_DiagnosticDictionary.TabStop = false;
            this.gpb_DiagnosticDictionary.Text = "诊断字典";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(217, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(98, 32);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "搜索";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(6, 30);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(205, 30);
            this.txb_Search.TabIndex = 1;
            // 
            // tvw_Diseases
            // 
            this.tvw_Diseases.Location = new System.Drawing.Point(6, 66);
            this.tvw_Diseases.Name = "tvw_Diseases";
            this.tvw_Diseases.Size = new System.Drawing.Size(319, 457);
            this.tvw_Diseases.TabIndex = 0;
            this.tvw_Diseases.DoubleClick += new System.EventHandler(this.tvw_Diseases_DoubleClick);
            // 
            // tabP_DoctorsOrder
            // 
            this.tabP_DoctorsOrder.Controls.Add(this.btn_tab2_Delete);
            this.tabP_DoctorsOrder.Controls.Add(this.btn_tab2_Insert);
            this.tabP_DoctorsOrder.Controls.Add(this.btn_tab2_Save);
            this.tabP_DoctorsOrder.Controls.Add(this.lbl_DoctorOrder);
            this.tabP_DoctorsOrder.Controls.Add(this.dgv_DoctorOrder);
            this.tabP_DoctorsOrder.Controls.Add(this.txb_Pinyin);
            this.tabP_DoctorsOrder.Controls.Add(this.lbl_Pinyin);
            this.tabP_DoctorsOrder.Controls.Add(this.dgv_Medicines);
            this.tabP_DoctorsOrder.Location = new System.Drawing.Point(4, 30);
            this.tabP_DoctorsOrder.Name = "tabP_DoctorsOrder";
            this.tabP_DoctorsOrder.Size = new System.Drawing.Size(1083, 536);
            this.tabP_DoctorsOrder.TabIndex = 2;
            this.tabP_DoctorsOrder.Text = "医嘱";
            this.tabP_DoctorsOrder.UseVisualStyleBackColor = true;
            // 
            // btn_tab2_Delete
            // 
            this.btn_tab2_Delete.BackColor = System.Drawing.Color.White;
            this.btn_tab2_Delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tab2_Delete.Location = new System.Drawing.Point(981, 160);
            this.btn_tab2_Delete.Name = "btn_tab2_Delete";
            this.btn_tab2_Delete.Size = new System.Drawing.Size(99, 49);
            this.btn_tab2_Delete.TabIndex = 15;
            this.btn_tab2_Delete.TabStop = false;
            this.btn_tab2_Delete.Text = "删除";
            this.btn_tab2_Delete.UseVisualStyleBackColor = false;
            this.btn_tab2_Delete.Click += new System.EventHandler(this.btn_tab2_Delete_Click);
            // 
            // btn_tab2_Insert
            // 
            this.btn_tab2_Insert.BackColor = System.Drawing.Color.White;
            this.btn_tab2_Insert.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tab2_Insert.Location = new System.Drawing.Point(981, 105);
            this.btn_tab2_Insert.Name = "btn_tab2_Insert";
            this.btn_tab2_Insert.Size = new System.Drawing.Size(99, 49);
            this.btn_tab2_Insert.TabIndex = 14;
            this.btn_tab2_Insert.TabStop = false;
            this.btn_tab2_Insert.Text = "插入";
            this.btn_tab2_Insert.UseVisualStyleBackColor = false;
            this.btn_tab2_Insert.Click += new System.EventHandler(this.btn_tab2_Insert_Click);
            // 
            // btn_tab2_Save
            // 
            this.btn_tab2_Save.BackColor = System.Drawing.Color.White;
            this.btn_tab2_Save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tab2_Save.Location = new System.Drawing.Point(981, 484);
            this.btn_tab2_Save.Name = "btn_tab2_Save";
            this.btn_tab2_Save.Size = new System.Drawing.Size(99, 49);
            this.btn_tab2_Save.TabIndex = 13;
            this.btn_tab2_Save.TabStop = false;
            this.btn_tab2_Save.Text = "保存";
            this.btn_tab2_Save.UseVisualStyleBackColor = false;
            this.btn_tab2_Save.Click += new System.EventHandler(this.btn_SaveOrder_Click);
            // 
            // lbl_DoctorOrder
            // 
            this.lbl_DoctorOrder.AutoSize = true;
            this.lbl_DoctorOrder.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DoctorOrder.Location = new System.Drawing.Point(384, 7);
            this.lbl_DoctorOrder.Name = "lbl_DoctorOrder";
            this.lbl_DoctorOrder.Size = new System.Drawing.Size(62, 25);
            this.lbl_DoctorOrder.TabIndex = 10;
            this.lbl_DoctorOrder.Text = "医嘱";
            // 
            // dgv_DoctorOrder
            // 
            this.dgv_DoctorOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DoctorOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_DoctorOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoctorOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MedicalName,
            this.Column_DrugDosage,
            this.Column_Pack,
            this.Column_Frequency,
            this.Column_FrequencyDAY});
            this.dgv_DoctorOrder.Location = new System.Drawing.Point(389, 43);
            this.dgv_DoctorOrder.Name = "dgv_DoctorOrder";
            this.dgv_DoctorOrder.RowTemplate.Height = 27;
            this.dgv_DoctorOrder.Size = new System.Drawing.Size(590, 493);
            this.dgv_DoctorOrder.TabIndex = 9;
            this.dgv_DoctorOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DoctorOrder_CellEndEdit);
            // 
            // Column_MedicalName
            // 
            this.Column_MedicalName.HeaderText = "药品名称";
            this.Column_MedicalName.Name = "Column_MedicalName";
            this.Column_MedicalName.ReadOnly = true;
            this.Column_MedicalName.Width = 118;
            // 
            // Column_DrugDosage
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column_DrugDosage.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_DrugDosage.HeaderText = "药品数量";
            this.Column_DrugDosage.Name = "Column_DrugDosage";
            this.Column_DrugDosage.Width = 118;
            // 
            // Column_Pack
            // 
            this.Column_Pack.HeaderText = "包装";
            this.Column_Pack.Items.AddRange(new object[] {
            "瓶",
            "支",
            "盒",
            "袋",
            "片"});
            this.Column_Pack.Name = "Column_Pack";
            this.Column_Pack.Width = 55;
            // 
            // Column_Frequency
            // 
            this.Column_Frequency.HeaderText = "频次";
            this.Column_Frequency.Items.AddRange(new object[] {
            "每天",
            "每周"});
            this.Column_Frequency.Name = "Column_Frequency";
            this.Column_Frequency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Frequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Frequency.Width = 78;
            // 
            // Column_FrequencyDAY
            // 
            this.Column_FrequencyDAY.HeaderText = "日/周";
            this.Column_FrequencyDAY.Name = "Column_FrequencyDAY";
            this.Column_FrequencyDAY.Width = 88;
            // 
            // txb_Pinyin
            // 
            this.txb_Pinyin.Location = new System.Drawing.Point(76, 7);
            this.txb_Pinyin.Name = "txb_Pinyin";
            this.txb_Pinyin.Size = new System.Drawing.Size(130, 30);
            this.txb_Pinyin.TabIndex = 8;
            this.txb_Pinyin.TextChanged += new System.EventHandler(this.txb_Pinyin_TextChanged);
            // 
            // lbl_Pinyin
            // 
            this.lbl_Pinyin.AutoSize = true;
            this.lbl_Pinyin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Pinyin.Location = new System.Drawing.Point(8, 12);
            this.lbl_Pinyin.Name = "lbl_Pinyin";
            this.lbl_Pinyin.Size = new System.Drawing.Size(62, 25);
            this.lbl_Pinyin.TabIndex = 1;
            this.lbl_Pinyin.Text = "拼音";
            // 
            // dgv_Medicines
            // 
            this.dgv_Medicines.AllowUserToAddRows = false;
            this.dgv_Medicines.AllowUserToDeleteRows = false;
            this.dgv_Medicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicines.Location = new System.Drawing.Point(3, 43);
            this.dgv_Medicines.Name = "dgv_Medicines";
            this.dgv_Medicines.ReadOnly = true;
            this.dgv_Medicines.RowTemplate.Height = 27;
            this.dgv_Medicines.Size = new System.Drawing.Size(354, 490);
            this.dgv_Medicines.TabIndex = 0;
            this.dgv_Medicines.DoubleClick += new System.EventHandler(this.btn_tab2_Insert_Click);
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.BackColor = System.Drawing.Color.White;
            this.btn_Fresh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btn_ChangeNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ChangeNumber.Location = new System.Drawing.Point(111, 52);
            this.btn_ChangeNumber.Name = "btn_ChangeNumber";
            this.btn_ChangeNumber.Size = new System.Drawing.Size(99, 49);
            this.btn_ChangeNumber.TabIndex = 3;
            this.btn_ChangeNumber.Text = "换号";
            this.btn_ChangeNumber.UseVisualStyleBackColor = false;
            this.btn_ChangeNumber.Click += new System.EventHandler(this.btn_ChangeNumber_Click);
            // 
            // btn_Admission
            // 
            this.btn_Admission.BackColor = System.Drawing.Color.White;
            this.btn_Admission.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btn_CancelAppointment.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btn_AdmissionNotice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btn_EndOfVisit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btn_Appointment.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btn_Exit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.Location = new System.Drawing.Point(705, 52);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 49);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // btn_tab1_Clear
            // 
            this.btn_tab1_Clear.BackColor = System.Drawing.Color.White;
            this.btn_tab1_Clear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tab1_Clear.Location = new System.Drawing.Point(981, 215);
            this.btn_tab1_Clear.Name = "btn_tab1_Clear";
            this.btn_tab1_Clear.Size = new System.Drawing.Size(99, 49);
            this.btn_tab1_Clear.TabIndex = 13;
            this.btn_tab1_Clear.TabStop = false;
            this.btn_tab1_Clear.Text = "清空";
            this.btn_tab1_Clear.UseVisualStyleBackColor = false;
            this.btn_tab1_Clear.Click += new System.EventHandler(this.btn_tab1_Clear_Click);
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
            this.tabP_Diagnosis.ResumeLayout(false);
            this.gpb_Information.ResumeLayout(false);
            this.gpb_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diagnosis)).EndInit();
            this.gpb_DiagnosticDictionary.ResumeLayout(false);
            this.gpb_DiagnosticDictionary.PerformLayout();
            this.tabP_DoctorsOrder.ResumeLayout(false);
            this.tabP_DoctorsOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoctorOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicines)).EndInit();
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
        private System.Windows.Forms.GroupBox gpb_DiagnosticDictionary;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.TreeView tvw_Diseases;
        private System.Windows.Forms.DataGridView dgv_Diagnosis;
        private System.Windows.Forms.GroupBox gpb_Information;
        private System.Windows.Forms.TextBox txb_tab1_Name;
        private System.Windows.Forms.Label lbl_tab1_Name;
        private System.Windows.Forms.TextBox txb_tab1_Age;
        private System.Windows.Forms.Label lbl_tab1_Age;
        private System.Windows.Forms.TextBox txb_tab1_Gender;
        private System.Windows.Forms.Label lbl_tab1_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Disease;
        private System.Windows.Forms.Button btn_tab1_Delete;
        private System.Windows.Forms.Button btn_tab1_Insert;
        private System.Windows.Forms.Button btn_tab1_Save;
        private System.Windows.Forms.DataGridView dgv_Medicines;
        private System.Windows.Forms.TextBox txb_Pinyin;
        private System.Windows.Forms.Label lbl_Pinyin;
        private System.Windows.Forms.Label lbl_DoctorOrder;
        private System.Windows.Forms.DataGridView dgv_DoctorOrder;
        private System.Windows.Forms.Button btn_tab2_Save;
        private System.Windows.Forms.Button btn_tab2_Insert;
        private System.Windows.Forms.Button btn_tab2_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MedicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DrugDosage;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_Pack;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FrequencyDAY;
        private System.Windows.Forms.Button btn_tab1_Clear;
    }
}