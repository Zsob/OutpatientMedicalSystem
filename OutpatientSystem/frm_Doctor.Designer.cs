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
            this.grb_Docter = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grb_Docter
            // 
            this.grb_Docter.Location = new System.Drawing.Point(274, 43);
            this.grb_Docter.Name = "grb_Docter";
            this.grb_Docter.Size = new System.Drawing.Size(694, 605);
            this.grb_Docter.TabIndex = 2;
            this.grb_Docter.TabStop = false;
            this.grb_Docter.Text = "医师";
            // 
            // frm_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 689);
            this.Controls.Add(this.grb_Docter);
            this.Name = "frm_Doctor";
            this.Text = "医生系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Docter;
    }
}