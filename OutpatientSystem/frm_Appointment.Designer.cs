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
            this.SuspendLayout();
            // 
            // lbl_DepartmentSelection
            // 
            this.lbl_DepartmentSelection.AutoSize = true;
            this.lbl_DepartmentSelection.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DepartmentSelection.Location = new System.Drawing.Point(128, 86);
            this.lbl_DepartmentSelection.Name = "lbl_DepartmentSelection";
            this.lbl_DepartmentSelection.Size = new System.Drawing.Size(137, 25);
            this.lbl_DepartmentSelection.TabIndex = 0;
            this.lbl_DepartmentSelection.Text = "选择科室：";
            // 
            // lbl_DoctorSelection
            // 
            this.lbl_DoctorSelection.AutoSize = true;
            this.lbl_DoctorSelection.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DoctorSelection.Location = new System.Drawing.Point(128, 143);
            this.lbl_DoctorSelection.Name = "lbl_DoctorSelection";
            this.lbl_DoctorSelection.Size = new System.Drawing.Size(137, 25);
            this.lbl_DoctorSelection.TabIndex = 1;
            this.lbl_DoctorSelection.Text = "选择医生：";
            // 
            // lbl_AppointmentTime
            // 
            this.lbl_AppointmentTime.AutoSize = true;
            this.lbl_AppointmentTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_AppointmentTime.Location = new System.Drawing.Point(128, 203);
            this.lbl_AppointmentTime.Name = "lbl_AppointmentTime";
            this.lbl_AppointmentTime.Size = new System.Drawing.Size(137, 25);
            this.lbl_AppointmentTime.TabIndex = 2;
            this.lbl_AppointmentTime.Text = "预约时间：";
            // 
            // cmb_DepartmentSelection
            // 
            this.cmb_DepartmentSelection.Font = new System.Drawing.Font("宋体", 15F);
            this.cmb_DepartmentSelection.FormattingEnabled = true;
            this.cmb_DepartmentSelection.Location = new System.Drawing.Point(291, 83);
            this.cmb_DepartmentSelection.Name = "cmb_DepartmentSelection";
            this.cmb_DepartmentSelection.Size = new System.Drawing.Size(207, 33);
            this.cmb_DepartmentSelection.TabIndex = 5;
            this.cmb_DepartmentSelection.SelectedIndexChanged += new System.EventHandler(this.cmb_DepartmentSelection_SelectedIndexChanged);
            // 
            // cmb_DoctorSelection
            // 
            this.cmb_DoctorSelection.Font = new System.Drawing.Font("宋体", 15F);
            this.cmb_DoctorSelection.FormattingEnabled = true;
            this.cmb_DoctorSelection.Location = new System.Drawing.Point(291, 143);
            this.cmb_DoctorSelection.Name = "cmb_DoctorSelection";
            this.cmb_DoctorSelection.Size = new System.Drawing.Size(207, 33);
            this.cmb_DoctorSelection.TabIndex = 6;
            // 
            // dtp_AppointmentTime
            // 
            this.dtp_AppointmentTime.CalendarFont = new System.Drawing.Font("宋体", 15F);
            this.dtp_AppointmentTime.Font = new System.Drawing.Font("宋体", 15F);
            this.dtp_AppointmentTime.Location = new System.Drawing.Point(291, 202);
            this.dtp_AppointmentTime.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtp_AppointmentTime.Name = "dtp_AppointmentTime";
            this.dtp_AppointmentTime.Size = new System.Drawing.Size(207, 36);
            this.dtp_AppointmentTime.TabIndex = 7;
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Appointment.Location = new System.Drawing.Point(265, 295);
            this.btn_Appointment.Name = "btn_Appointment";
            this.btn_Appointment.Size = new System.Drawing.Size(116, 44);
            this.btn_Appointment.TabIndex = 8;
            this.btn_Appointment.Text = "预约";
            this.btn_Appointment.UseVisualStyleBackColor = true;
            this.btn_Appointment.Click += new System.EventHandler(this.btn_Appointment_Click);
            // 
            // frm_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 439);
            this.Controls.Add(this.btn_Appointment);
            this.Controls.Add(this.dtp_AppointmentTime);
            this.Controls.Add(this.cmb_DoctorSelection);
            this.Controls.Add(this.cmb_DepartmentSelection);
            this.Controls.Add(this.lbl_AppointmentTime);
            this.Controls.Add(this.lbl_DoctorSelection);
            this.Controls.Add(this.lbl_DepartmentSelection);
            this.Name = "frm_Appointment";
            this.Text = "预约";
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
    }
}