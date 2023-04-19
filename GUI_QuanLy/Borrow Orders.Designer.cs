namespace GUI_Quanly
{
    partial class Borrow_Orders
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
            this.lbMoneyBorrow = new System.Windows.Forms.Label();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.dataGridBorrowOrders = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrowOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMoneyBorrow);
            this.panel1.Controls.Add(this.lbOrderTotal);
            this.panel1.Controls.Add(this.BtnCheckOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 688);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 60);
            this.panel1.TabIndex = 1;
            // 
            // lbMoneyBorrow
            // 
            this.lbMoneyBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMoneyBorrow.AutoSize = true;
            this.lbMoneyBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMoneyBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyBorrow.Location = new System.Drawing.Point(517, 16);
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
            this.lbOrderTotal.Location = new System.Drawing.Point(394, 16);
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
            this.BtnCheckOut.Location = new System.Drawing.Point(723, 8);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(136, 40);
            this.BtnCheckOut.TabIndex = 1;
            this.BtnCheckOut.Text = "Check Out";
            this.BtnCheckOut.UseVisualStyleBackColor = false;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // dataGridBorrowOrders
            // 
            this.dataGridBorrowOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBorrowOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBorrowOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridBorrowOrders.Name = "dataGridBorrowOrders";
            this.dataGridBorrowOrders.RowHeadersWidth = 51;
            this.dataGridBorrowOrders.RowTemplate.Height = 24;
            this.dataGridBorrowOrders.Size = new System.Drawing.Size(946, 688);
            this.dataGridBorrowOrders.TabIndex = 2;
            // 
            // Borrow_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 748);
            this.Controls.Add(this.dataGridBorrowOrders);
            this.Controls.Add(this.panel1);
            this.Name = "Borrow_Orders";
            this.Text = "Borrow_Orders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrowOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMoneyBorrow;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.DataGridView dataGridBorrowOrders;
    }
}