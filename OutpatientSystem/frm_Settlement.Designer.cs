namespace OutpatientSystem
{
    partial class frm_Settlement
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
            this.dgv_AmountPayable = new System.Windows.Forms.DataGridView();
            this.lbl_AmountPayable = new System.Windows.Forms.Label();
            this.lbl_CurrentAmount = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.充值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Settlement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AmountPayable)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_AmountPayable
            // 
            this.dgv_AmountPayable.AllowUserToAddRows = false;
            this.dgv_AmountPayable.AllowUserToDeleteRows = false;
            this.dgv_AmountPayable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AmountPayable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AmountPayable.Location = new System.Drawing.Point(0, 31);
            this.dgv_AmountPayable.Name = "dgv_AmountPayable";
            this.dgv_AmountPayable.ReadOnly = true;
            this.dgv_AmountPayable.RowTemplate.Height = 27;
            this.dgv_AmountPayable.Size = new System.Drawing.Size(837, 338);
            this.dgv_AmountPayable.TabIndex = 0;
            // 
            // lbl_AmountPayable
            // 
            this.lbl_AmountPayable.AutoSize = true;
            this.lbl_AmountPayable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_AmountPayable.Location = new System.Drawing.Point(257, 397);
            this.lbl_AmountPayable.Name = "lbl_AmountPayable";
            this.lbl_AmountPayable.Size = new System.Drawing.Size(59, 20);
            this.lbl_AmountPayable.TabIndex = 1;
            this.lbl_AmountPayable.Text = "label";
            // 
            // lbl_CurrentAmount
            // 
            this.lbl_CurrentAmount.AutoSize = true;
            this.lbl_CurrentAmount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CurrentAmount.Location = new System.Drawing.Point(12, 397);
            this.lbl_CurrentAmount.Name = "lbl_CurrentAmount";
            this.lbl_CurrentAmount.Size = new System.Drawing.Size(59, 20);
            this.lbl_CurrentAmount.TabIndex = 2;
            this.lbl_CurrentAmount.Text = "label";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.充值ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(838, 35);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // 充值ToolStripMenuItem
            // 
            this.充值ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.充值ToolStripMenuItem.Name = "充值ToolStripMenuItem";
            this.充值ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.充值ToolStripMenuItem.Text = "充值";
            this.充值ToolStripMenuItem.Click += new System.EventHandler(this.充值ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // btn_Settlement
            // 
            this.btn_Settlement.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Settlement.Location = new System.Drawing.Point(673, 386);
            this.btn_Settlement.Name = "btn_Settlement";
            this.btn_Settlement.Size = new System.Drawing.Size(137, 42);
            this.btn_Settlement.TabIndex = 4;
            this.btn_Settlement.Text = "全部结算";
            this.btn_Settlement.UseVisualStyleBackColor = true;
            this.btn_Settlement.Click += new System.EventHandler(this.btn_Settlement_Click);
            // 
            // frm_Settlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 447);
            this.Controls.Add(this.btn_Settlement);
            this.Controls.Add(this.lbl_CurrentAmount);
            this.Controls.Add(this.lbl_AmountPayable);
            this.Controls.Add(this.dgv_AmountPayable);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_Settlement";
            this.Text = "结算";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AmountPayable)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AmountPayable;
        private System.Windows.Forms.Label lbl_AmountPayable;
        private System.Windows.Forms.Label lbl_CurrentAmount;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 充值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button btn_Settlement;
    }
}