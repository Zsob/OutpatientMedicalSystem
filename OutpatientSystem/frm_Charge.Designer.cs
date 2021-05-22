namespace OutpatientSystem
{
    partial class frm_Charge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Charge));
            this.lbl_Money = new System.Windows.Forms.Label();
            this.btn_OneHundred = new System.Windows.Forms.Button();
            this.btn_TwoHundred = new System.Windows.Forms.Button();
            this.btn_FiveHundred = new System.Windows.Forms.Button();
            this.txb_Money = new System.Windows.Forms.TextBox();
            this.lbl_Pay = new System.Windows.Forms.Label();
            this.pbx_WeChat = new System.Windows.Forms.PictureBox();
            this.pbx_Alipay = new System.Windows.Forms.PictureBox();
            this.lbl_WeChat = new System.Windows.Forms.Label();
            this.lbl_Alipay = new System.Windows.Forms.Label();
            this.lbl_BankCard = new System.Windows.Forms.Label();
            this.pbx_BankCard = new System.Windows.Forms.PictureBox();
            this.rdb_WeChat = new System.Windows.Forms.RadioButton();
            this.rdb_Alipay = new System.Windows.Forms.RadioButton();
            this.rdb_BankCard = new System.Windows.Forms.RadioButton();
            this.btn_Recharge = new System.Windows.Forms.Button();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_CurrentBalance = new System.Windows.Forms.Label();
            this.tbr_Money = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_WeChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Alipay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BankCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Money)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Money.Location = new System.Drawing.Point(25, 87);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(106, 24);
            this.lbl_Money.TabIndex = 0;
            this.lbl_Money.Text = "充值金额";
            // 
            // btn_OneHundred
            // 
            this.btn_OneHundred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OneHundred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneHundred.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OneHundred.Location = new System.Drawing.Point(29, 140);
            this.btn_OneHundred.Name = "btn_OneHundred";
            this.btn_OneHundred.Size = new System.Drawing.Size(102, 40);
            this.btn_OneHundred.TabIndex = 1;
            this.btn_OneHundred.TabStop = false;
            this.btn_OneHundred.Text = "100";
            this.btn_OneHundred.UseVisualStyleBackColor = true;
            this.btn_OneHundred.Click += new System.EventHandler(this.btn_OneHundred_Click);
            // 
            // btn_TwoHundred
            // 
            this.btn_TwoHundred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TwoHundred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TwoHundred.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TwoHundred.Location = new System.Drawing.Point(137, 140);
            this.btn_TwoHundred.Name = "btn_TwoHundred";
            this.btn_TwoHundred.Size = new System.Drawing.Size(102, 40);
            this.btn_TwoHundred.TabIndex = 2;
            this.btn_TwoHundred.TabStop = false;
            this.btn_TwoHundred.Text = "200";
            this.btn_TwoHundred.UseVisualStyleBackColor = true;
            this.btn_TwoHundred.Click += new System.EventHandler(this.btn_TwoHundred_Click);
            // 
            // btn_FiveHundred
            // 
            this.btn_FiveHundred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FiveHundred.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_FiveHundred.Location = new System.Drawing.Point(245, 140);
            this.btn_FiveHundred.Name = "btn_FiveHundred";
            this.btn_FiveHundred.Size = new System.Drawing.Size(102, 40);
            this.btn_FiveHundred.TabIndex = 3;
            this.btn_FiveHundred.TabStop = false;
            this.btn_FiveHundred.Text = "500";
            this.btn_FiveHundred.UseVisualStyleBackColor = true;
            this.btn_FiveHundred.Click += new System.EventHandler(this.btn_FiveHundred_Click);
            // 
            // txb_Money
            // 
            this.txb_Money.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Money.Location = new System.Drawing.Point(29, 199);
            this.txb_Money.Name = "txb_Money";
            this.txb_Money.Size = new System.Drawing.Size(318, 34);
            this.txb_Money.TabIndex = 4;
            this.txb_Money.Text = "0";
            this.txb_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Money.TextChanged += new System.EventHandler(this.txb_Money_TextChanged);
            this.txb_Money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Money_KeyPress);
            // 
            // lbl_Pay
            // 
            this.lbl_Pay.AutoSize = true;
            this.lbl_Pay.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Pay.Location = new System.Drawing.Point(25, 312);
            this.lbl_Pay.Name = "lbl_Pay";
            this.lbl_Pay.Size = new System.Drawing.Size(106, 24);
            this.lbl_Pay.TabIndex = 5;
            this.lbl_Pay.Text = "支付方式";
            // 
            // pbx_WeChat
            // 
            this.pbx_WeChat.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbx_WeChat.ErrorImage")));
            this.pbx_WeChat.Image = ((System.Drawing.Image)(resources.GetObject("pbx_WeChat.Image")));
            this.pbx_WeChat.Location = new System.Drawing.Point(29, 353);
            this.pbx_WeChat.Name = "pbx_WeChat";
            this.pbx_WeChat.Size = new System.Drawing.Size(81, 70);
            this.pbx_WeChat.TabIndex = 6;
            this.pbx_WeChat.TabStop = false;
            // 
            // pbx_Alipay
            // 
            this.pbx_Alipay.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Alipay.Image")));
            this.pbx_Alipay.Location = new System.Drawing.Point(29, 429);
            this.pbx_Alipay.Name = "pbx_Alipay";
            this.pbx_Alipay.Size = new System.Drawing.Size(81, 70);
            this.pbx_Alipay.TabIndex = 7;
            this.pbx_Alipay.TabStop = false;
            // 
            // lbl_WeChat
            // 
            this.lbl_WeChat.AutoSize = true;
            this.lbl_WeChat.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_WeChat.Location = new System.Drawing.Point(116, 376);
            this.lbl_WeChat.Name = "lbl_WeChat";
            this.lbl_WeChat.Size = new System.Drawing.Size(58, 24);
            this.lbl_WeChat.TabIndex = 8;
            this.lbl_WeChat.Text = "微信";
            // 
            // lbl_Alipay
            // 
            this.lbl_Alipay.AutoSize = true;
            this.lbl_Alipay.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Alipay.Location = new System.Drawing.Point(116, 450);
            this.lbl_Alipay.Name = "lbl_Alipay";
            this.lbl_Alipay.Size = new System.Drawing.Size(82, 24);
            this.lbl_Alipay.TabIndex = 9;
            this.lbl_Alipay.Text = "支付宝";
            // 
            // lbl_BankCard
            // 
            this.lbl_BankCard.AutoSize = true;
            this.lbl_BankCard.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_BankCard.Location = new System.Drawing.Point(116, 526);
            this.lbl_BankCard.Name = "lbl_BankCard";
            this.lbl_BankCard.Size = new System.Drawing.Size(82, 24);
            this.lbl_BankCard.TabIndex = 11;
            this.lbl_BankCard.Text = "银行卡";
            // 
            // pbx_BankCard
            // 
            this.pbx_BankCard.Image = ((System.Drawing.Image)(resources.GetObject("pbx_BankCard.Image")));
            this.pbx_BankCard.Location = new System.Drawing.Point(29, 505);
            this.pbx_BankCard.Name = "pbx_BankCard";
            this.pbx_BankCard.Size = new System.Drawing.Size(81, 70);
            this.pbx_BankCard.TabIndex = 10;
            this.pbx_BankCard.TabStop = false;
            // 
            // rdb_WeChat
            // 
            this.rdb_WeChat.AutoSize = true;
            this.rdb_WeChat.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_WeChat.Location = new System.Drawing.Point(299, 379);
            this.rdb_WeChat.Name = "rdb_WeChat";
            this.rdb_WeChat.Size = new System.Drawing.Size(17, 16);
            this.rdb_WeChat.TabIndex = 12;
            this.rdb_WeChat.TabStop = true;
            this.rdb_WeChat.UseVisualStyleBackColor = true;
            // 
            // rdb_Alipay
            // 
            this.rdb_Alipay.AutoSize = true;
            this.rdb_Alipay.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Alipay.Location = new System.Drawing.Point(299, 458);
            this.rdb_Alipay.Name = "rdb_Alipay";
            this.rdb_Alipay.Size = new System.Drawing.Size(17, 16);
            this.rdb_Alipay.TabIndex = 13;
            this.rdb_Alipay.TabStop = true;
            this.rdb_Alipay.UseVisualStyleBackColor = true;
            // 
            // rdb_BankCard
            // 
            this.rdb_BankCard.AutoSize = true;
            this.rdb_BankCard.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_BankCard.Location = new System.Drawing.Point(299, 529);
            this.rdb_BankCard.Name = "rdb_BankCard";
            this.rdb_BankCard.Size = new System.Drawing.Size(17, 16);
            this.rdb_BankCard.TabIndex = 14;
            this.rdb_BankCard.TabStop = true;
            this.rdb_BankCard.UseVisualStyleBackColor = true;
            // 
            // btn_Recharge
            // 
            this.btn_Recharge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Recharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recharge.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Recharge.Location = new System.Drawing.Point(137, 589);
            this.btn_Recharge.Name = "btn_Recharge";
            this.btn_Recharge.Size = new System.Drawing.Size(102, 40);
            this.btn_Recharge.TabIndex = 15;
            this.btn_Recharge.TabStop = false;
            this.btn_Recharge.Text = "充值";
            this.btn_Recharge.UseVisualStyleBackColor = true;
            this.btn_Recharge.Click += new System.EventHandler(this.btn_Recharge_Click);
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Balance.Location = new System.Drawing.Point(25, 38);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(130, 24);
            this.lbl_Balance.TabIndex = 16;
            this.lbl_Balance.Text = "当前余额：";
            // 
            // lbl_CurrentBalance
            // 
            this.lbl_CurrentBalance.AutoSize = true;
            this.lbl_CurrentBalance.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CurrentBalance.Location = new System.Drawing.Point(161, 38);
            this.lbl_CurrentBalance.Name = "lbl_CurrentBalance";
            this.lbl_CurrentBalance.Size = new System.Drawing.Size(0, 24);
            this.lbl_CurrentBalance.TabIndex = 17;
            // 
            // tbr_Money
            // 
            this.tbr_Money.Location = new System.Drawing.Point(61, 253);
            this.tbr_Money.Maximum = 1000;
            this.tbr_Money.Name = "tbr_Money";
            this.tbr_Money.Size = new System.Drawing.Size(255, 56);
            this.tbr_Money.SmallChange = 100;
            this.tbr_Money.TabIndex = 18;
            this.tbr_Money.TickFrequency = 100;
            this.tbr_Money.Scroll += new System.EventHandler(this.tbr_Money_Scroll);
            // 
            // frm_Charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 646);
            this.Controls.Add(this.tbr_Money);
            this.Controls.Add(this.lbl_CurrentBalance);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.btn_Recharge);
            this.Controls.Add(this.rdb_BankCard);
            this.Controls.Add(this.rdb_Alipay);
            this.Controls.Add(this.rdb_WeChat);
            this.Controls.Add(this.lbl_BankCard);
            this.Controls.Add(this.pbx_BankCard);
            this.Controls.Add(this.lbl_Alipay);
            this.Controls.Add(this.lbl_WeChat);
            this.Controls.Add(this.pbx_Alipay);
            this.Controls.Add(this.pbx_WeChat);
            this.Controls.Add(this.lbl_Pay);
            this.Controls.Add(this.txb_Money);
            this.Controls.Add(this.btn_FiveHundred);
            this.Controls.Add(this.btn_TwoHundred);
            this.Controls.Add(this.btn_OneHundred);
            this.Controls.Add(this.lbl_Money);
            this.Name = "frm_Charge";
            this.Text = "在线充值";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_WeChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Alipay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BankCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Button btn_OneHundred;
        private System.Windows.Forms.Button btn_TwoHundred;
        private System.Windows.Forms.Button btn_FiveHundred;
        private System.Windows.Forms.TextBox txb_Money;
        private System.Windows.Forms.Label lbl_Pay;
        private System.Windows.Forms.PictureBox pbx_WeChat;
        private System.Windows.Forms.PictureBox pbx_Alipay;
        private System.Windows.Forms.Label lbl_WeChat;
        private System.Windows.Forms.Label lbl_Alipay;
        private System.Windows.Forms.Label lbl_BankCard;
        private System.Windows.Forms.PictureBox pbx_BankCard;
        private System.Windows.Forms.RadioButton rdb_WeChat;
        private System.Windows.Forms.RadioButton rdb_Alipay;
        private System.Windows.Forms.RadioButton rdb_BankCard;
        private System.Windows.Forms.Button btn_Recharge;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_CurrentBalance;
        private System.Windows.Forms.TrackBar tbr_Money;
    }
}