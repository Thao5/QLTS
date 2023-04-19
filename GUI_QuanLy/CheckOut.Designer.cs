namespace GUI_Quanly
{
    partial class CheckOut
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
            this.panelCheckOut = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMoneyBorrow = new System.Windows.Forms.Label();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMoneyBuy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnPurchase = new System.Windows.Forms.Button();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.lbMoneyWallet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMoneyTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCheckOut.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCheckOut
            // 
            this.panelCheckOut.AutoScroll = true;
            this.panelCheckOut.Controls.Add(this.panel3);
            this.panelCheckOut.Controls.Add(this.dataGridView2);
            this.panelCheckOut.Controls.Add(this.panel2);
            this.panelCheckOut.Controls.Add(this.panel1);
            this.panelCheckOut.Controls.Add(this.dataGridView1);
            this.panelCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCheckOut.Location = new System.Drawing.Point(0, 0);
            this.panelCheckOut.Name = "panelCheckOut";
            this.panelCheckOut.Size = new System.Drawing.Size(1320, 790);
            this.panelCheckOut.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMoneyBorrow);
            this.panel1.Controls.Add(this.lbOrderTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 40);
            this.panel1.TabIndex = 4;
            // 
            // lbMoneyBorrow
            // 
            this.lbMoneyBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMoneyBorrow.AutoSize = true;
            this.lbMoneyBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMoneyBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyBorrow.Location = new System.Drawing.Point(918, 6);
            this.lbMoneyBorrow.Name = "lbMoneyBorrow";
            this.lbMoneyBorrow.Size = new System.Drawing.Size(133, 25);
            this.lbMoneyBorrow.TabIndex = 3;
            this.lbMoneyBorrow.Text = "MoneyBorrow";
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderTotal.Location = new System.Drawing.Point(786, 6);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(117, 25);
            this.lbOrderTotal.TabIndex = 2;
            this.lbOrderTotal.Text = "Order Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(0, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbMoneyTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbMoneyWallet);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnTopUp);
            this.panel2.Controls.Add(this.BtnPurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 680);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 250);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbMoneyBuy);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 40);
            this.panel3.TabIndex = 7;
            // 
            // lbMoneyBuy
            // 
            this.lbMoneyBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMoneyBuy.AutoSize = true;
            this.lbMoneyBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMoneyBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMoneyBuy.Location = new System.Drawing.Point(918, 6);
            this.lbMoneyBuy.Name = "lbMoneyBuy";
            this.lbMoneyBuy.Size = new System.Drawing.Size(106, 25);
            this.lbMoneyBuy.TabIndex = 3;
            this.lbMoneyBuy.Text = "MoneyBuy";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Total:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1299, 400);
            this.dataGridView2.TabIndex = 6;
            // 
            // BtnPurchase
            // 
            this.BtnPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.BtnPurchase.FlatAppearance.BorderSize = 0;
            this.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPurchase.ForeColor = System.Drawing.Color.White;
            this.BtnPurchase.Location = new System.Drawing.Point(1078, 182);
            this.BtnPurchase.Name = "BtnPurchase";
            this.BtnPurchase.Size = new System.Drawing.Size(194, 40);
            this.BtnPurchase.TabIndex = 2;
            this.BtnPurchase.Text = "Purchase";
            this.BtnPurchase.UseVisualStyleBackColor = false;
            // 
            // btnTopUp
            // 
            this.btnTopUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnTopUp.FlatAppearance.BorderSize = 0;
            this.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopUp.ForeColor = System.Drawing.Color.White;
            this.btnTopUp.Location = new System.Drawing.Point(896, 182);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(155, 40);
            this.btnTopUp.TabIndex = 3;
            this.btnTopUp.Text = "Top Up";
            this.btnTopUp.UseVisualStyleBackColor = false;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // lbMoneyWallet
            // 
            this.lbMoneyWallet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMoneyWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMoneyWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyWallet.Location = new System.Drawing.Point(990, 69);
            this.lbMoneyWallet.Name = "lbMoneyWallet";
            this.lbMoneyWallet.Size = new System.Drawing.Size(261, 25);
            this.lbMoneyWallet.TabIndex = 5;
            this.lbMoneyWallet.Text = "MoneyWallet";
            this.lbMoneyWallet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMoneyWallet.Click += new System.EventHandler(this.lbMoneyWallet_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Money:";
            // 
            // lbMoneyTotal
            // 
            this.lbMoneyTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMoneyTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lbMoneyTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMoneyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.lbMoneyTotal.Location = new System.Drawing.Point(990, 117);
            this.lbMoneyTotal.Name = "lbMoneyTotal";
            this.lbMoneyTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbMoneyTotal.Size = new System.Drawing.Size(268, 39);
            this.lbMoneyTotal.TabIndex = 7;
            this.lbMoneyTotal.Text = "MoneyTotal";
            this.lbMoneyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMoneyTotal.Click += new System.EventHandler(this.lbMoneyTotal_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(840, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Payment:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1308, 1);
            this.label1.TabIndex = 8;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 790);
            this.Controls.Add(this.panelCheckOut);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.panelCheckOut.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCheckOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbMoneyBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMoneyBorrow;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMoneyTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMoneyWallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.Label label1;
    }
}