namespace GUI_Quanly
{
    partial class BuyOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMoneyBuy = new System.Windows.Forms.Label();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.dataGridBuyOrders = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMoneyBuy);
            this.panel1.Controls.Add(this.lbOrderTotal);
            this.panel1.Controls.Add(this.BtnCheckOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 60);
            this.panel1.TabIndex = 0;
            // 
            // lbMoneyBuy
            // 
            this.lbMoneyBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMoneyBuy.AutoSize = true;
            this.lbMoneyBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMoneyBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyBuy.Location = new System.Drawing.Point(476, 16);
            this.lbMoneyBuy.Name = "lbMoneyBuy";
            this.lbMoneyBuy.Size = new System.Drawing.Size(106, 25);
            this.lbMoneyBuy.TabIndex = 3;
            this.lbMoneyBuy.Text = "MoneyBuy";
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderTotal.Location = new System.Drawing.Point(353, 16);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(117, 25);
            this.lbOrderTotal.TabIndex = 2;
            this.lbOrderTotal.Text = "Order Total:";
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.BtnCheckOut.FlatAppearance.BorderSize = 0;
            this.BtnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckOut.ForeColor = System.Drawing.Color.White;
            this.BtnCheckOut.Location = new System.Drawing.Point(682, 8);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(136, 40);
            this.BtnCheckOut.TabIndex = 1;
            this.BtnCheckOut.Text = "Check Out";
            this.BtnCheckOut.UseVisualStyleBackColor = false;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // dataGridBuyOrders
            // 
            this.dataGridBuyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuyOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBuyOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridBuyOrders.Name = "dataGridBuyOrders";
            this.dataGridBuyOrders.RowHeadersWidth = 51;
            this.dataGridBuyOrders.RowTemplate.Height = 24;
            this.dataGridBuyOrders.Size = new System.Drawing.Size(864, 709);
            this.dataGridBuyOrders.TabIndex = 1;
            // 
            // BuyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 769);
            this.Controls.Add(this.dataGridBuyOrders);
            this.Controls.Add(this.panel1);
            this.Name = "BuyOrders";
            this.Text = "BuyOrders";
            this.Load += new System.EventHandler(this.BuyOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridBuyOrders;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Label lbMoneyBuy;
        private System.Windows.Forms.Label lbOrderTotal;
    }
}