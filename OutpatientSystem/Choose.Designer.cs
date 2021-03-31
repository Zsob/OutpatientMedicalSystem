namespace OutpatientSystem
{
    partial class Choose
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
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Docter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_User
            // 
            this.btn_User.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_User.Location = new System.Drawing.Point(118, 67);
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
            this.btn_Docter.Location = new System.Drawing.Point(118, 148);
            this.btn_Docter.Name = "btn_Docter";
            this.btn_Docter.Size = new System.Drawing.Size(126, 43);
            this.btn_Docter.TabIndex = 1;
            this.btn_Docter.Text = "医生登录";
            this.btn_Docter.UseVisualStyleBackColor = true;
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 289);
            this.Controls.Add(this.btn_Docter);
            this.Controls.Add(this.btn_User);
            this.Name = "Choose";
            this.Text = "选择登陆入口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Docter;
    }
}