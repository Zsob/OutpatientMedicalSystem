namespace OutpatientSystem
{
    partial class frm_Appointment
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
            this.lbl_DepartmentSelection = new System.Windows.Forms.Label();
            this.lbl_DoctorSelection = new System.Windows.Forms.Label();
            this.lbl_AppointmentTime = new System.Windows.Forms.Label();
            this.cmb_DepartmentSelection = new System.Windows.Forms.ComboBox();
            this.cmb_DoctorSelection = new System.Windows.Forms.ComboBox();
            this.dtp_AppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.btn_Appointment = new System.Windows.Forms.Button();
            this.dgv_Appointment = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmb_Noon = new System.Windows.Forms.ComboBox();
            this.lbl_Noon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DepartmentSelection
            // 
            this.lbl_DepartmentSelection.AutoSize = true;
            this.lbl_DepartmentSelection.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DepartmentSelection.Location = new System.Drawing.Point(190, 31);
            this.lbl_DepartmentSelection.Name = "lbl_DepartmentSelection";
            this.lbl_DepartmentSelection.Size = new System.Drawing.Size(137, 25);
            this.lbl_DepartmentSelection.TabIndex = 0;
            this.lbl_DepartmentSelection.Text = "选择科室：";
            // 
            // lbl_DoctorSelection
            // 
            this.lbl_DoctorSelection.AutoSize = true;
            this.lbl_DoctorSelection.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DoctorSelection.Location = new System.Drawing.Point(190, 88);
            this.lbl_DoctorSelection.Name = "lbl_DoctorSelection";
            this.lbl_DoctorSelection.Size = new System.Drawing.Size(137, 25);
            this.lbl_DoctorSelection.TabIndex = 1;
            this.lbl_DoctorSelection.Text = "选择医生：";
            // 
            // lbl_AppointmentTime
            // 
            this.lbl_AppointmentTime.AutoSize = true;
            this.lbl_AppointmentTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_AppointmentTime.Location = new System.Drawing.Point(190, 148);
            this.lbl_AppointmentTime.Name = "lbl_AppointmentTime";
            this.lbl_AppointmentTime.Size = new System.Drawing.Size(137, 25);
            this.lbl_AppointmentTime.TabIndex = 2;
            this.lbl_AppointmentTime.Text = "预约时间：";
            // 
            // cmb_DepartmentSelection
            // 
            this.cmb_DepartmentSelection.Font = new System.Drawing.Font("宋体", 15F);
            this.cmb_DepartmentSelection.FormattingEnabled = true;
            this.cmb_DepartmentSelection.Location = new System.Drawing.Point(353, 28);
            this.cmb_DepartmentSelection.Name = "cmb_DepartmentSelection";
            this.cmb_DepartmentSelection.Size = new System.Drawing.Size(215, 33);
            this.cmb_DepartmentSelection.TabIndex = 5;
            this.cmb_DepartmentSelection.SelectedIndexChanged += new System.EventHandler(this.cmb_DepartmentSelection_SelectedIndexChanged);
            // 
            // cmb_DoctorSelection
            // 
            this.cmb_DoctorSelection.Font = new System.Drawing.Font("宋体", 15F);
            this.cmb_DoctorSelection.FormattingEnabled = true;
            this.cmb_DoctorSelection.Location = new System.Drawing.Point(353, 88);
            this.cmb_DoctorSelection.Name = "cmb_DoctorSelection";
            this.cmb_DoctorSelection.Size = new System.Drawing.Size(215, 33);
            this.cmb_DoctorSelection.TabIndex = 6;
            // 
            // dtp_AppointmentTime
            // 
            this.dtp_AppointmentTime.CalendarFont = new System.Drawing.Font("宋体", 15F);
            this.dtp_AppointmentTime.Font = new System.Drawing.Font("宋体", 15F);
            this.dtp_AppointmentTime.Location = new System.Drawing.Point(353, 147);
            this.dtp_AppointmentTime.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtp_AppointmentTime.Name = "dtp_AppointmentTime";
            this.dtp_AppointmentTime.Size = new System.Drawing.Size(215, 36);
            this.dtp_AppointmentTime.TabIndex = 7;
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Appointment.Location = new System.Drawing.Point(195, 281);
            this.btn_Appointment.Name = "btn_Appointment";
            this.btn_Appointment.Size = new System.Drawing.Size(137, 44);
            this.btn_Appointment.TabIndex = 8;
            this.btn_Appointment.Text = "预约挂号";
            this.btn_Appointment.UseVisualStyleBackColor = true;
            this.btn_Appointment.Click += new System.EventHandler(this.btn_Appointment_Click);
            // 
            // dgv_Appointment
            // 
            this.dgv_Appointment.AllowUserToAddRows = false;
            this.dgv_Appointment.AllowUserToDeleteRows = false;
            this.dgv_Appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointment.Location = new System.Drawing.Point(0, 345);
            this.dgv_Appointment.Name = "dgv_Appointment";
            this.dgv_Appointment.ReadOnly = true;
            this.dgv_Appointment.RowTemplate.Height = 27;
            this.dgv_Appointment.Size = new System.Drawing.Size(756, 267);
            this.dgv_Appointment.TabIndex = 9;
            this.dgv_Appointment.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(436, 281);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(137, 44);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "取消预约";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmb_Noon
            // 
            this.cmb_Noon.Font = new System.Drawing.Font("宋体", 15F);
            this.cmb_Noon.FormattingEnabled = true;
            this.cmb_Noon.Items.AddRange(new object[] {
            "上午",
            "下午"});
            this.cmb_Noon.Location = new System.Drawing.Point(353, 205);
            this.cmb_Noon.Name = "cmb_Noon";
            this.cmb_Noon.Size = new System.Drawing.Size(215, 33);
            this.cmb_Noon.TabIndex = 12;
            // 
            // lbl_Noon
            // 
            this.lbl_Noon.AutoSize = true;
            this.lbl_Noon.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Noon.Location = new System.Drawing.Point(240, 205);
            this.lbl_Noon.Name = "lbl_Noon";
            this.lbl_Noon.Size = new System.Drawing.Size(87, 25);
            this.lbl_Noon.TabIndex = 11;
            this.lbl_Noon.Text = "午别：";
            // 
            // frm_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 612);
            this.Controls.Add(this.cmb_Noon);
            this.Controls.Add(this.lbl_Noon);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.dgv_Appointment);
            this.Controls.Add(this.btn_Appointment);
            this.Controls.Add(this.dtp_AppointmentTime);
            this.Controls.Add(this.cmb_DoctorSelection);
            this.Controls.Add(this.cmb_DepartmentSelection);
            this.Controls.Add(this.lbl_AppointmentTime);
            this.Controls.Add(this.lbl_DoctorSelection);
            this.Controls.Add(this.lbl_DepartmentSelection);
            this.Name = "frm_Appointment";
            this.Text = "预约";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DepartmentSelection;
        private System.Windows.Forms.Label lbl_DoctorSelection;
        private System.Windows.Forms.Label lbl_AppointmentTime;
        private System.Windows.Forms.ComboBox cmb_DepartmentSelection;
        private System.Windows.Forms.ComboBox cmb_DoctorSelection;
        private System.Windows.Forms.DateTimePicker dtp_AppointmentTime;
        private System.Windows.Forms.Button btn_Appointment;
        private System.Windows.Forms.DataGridView dgv_Appointment;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cmb_Noon;
        private System.Windows.Forms.Label lbl_Noon;
    }
}