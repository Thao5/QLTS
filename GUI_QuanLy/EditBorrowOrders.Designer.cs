namespace GUI_Quanly
{
    partial class EditBorrowOrders
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNguoiThue = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTenSachBorrow = new System.Windows.Forms.ComboBox();
            this.btnCancelBorrow = new System.Windows.Forms.Button();
            this.btnSaveBorrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(250, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(354, 34);
            this.txtID.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = "ID Thuê:";
            // 
            // cbNguoiThue
            // 
            this.cbNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNguoiThue.FormattingEnabled = true;
            this.cbNguoiThue.Location = new System.Drawing.Point(250, 254);
            this.cbNguoiThue.Name = "cbNguoiThue";
            this.cbNguoiThue.Size = new System.Drawing.Size(354, 37);
            this.cbNguoiThue.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Người Thuê:";
            // 
            // cbTenSachBorrow
            // 
            this.cbTenSachBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSachBorrow.FormattingEnabled = true;
            this.cbTenSachBorrow.Location = new System.Drawing.Point(250, 180);
            this.cbTenSachBorrow.Name = "cbTenSachBorrow";
            this.cbTenSachBorrow.Size = new System.Drawing.Size(354, 37);
            this.cbTenSachBorrow.TabIndex = 53;
            // 
            // btnCancelBorrow
            // 
            this.btnCancelBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnCancelBorrow.FlatAppearance.BorderSize = 0;
            this.btnCancelBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBorrow.ForeColor = System.Drawing.Color.White;
            this.btnCancelBorrow.Location = new System.Drawing.Point(421, 366);
            this.btnCancelBorrow.Name = "btnCancelBorrow";
            this.btnCancelBorrow.Size = new System.Drawing.Size(106, 40);
            this.btnCancelBorrow.TabIndex = 52;
            this.btnCancelBorrow.Text = "Cancel";
            this.btnCancelBorrow.UseVisualStyleBackColor = false;
            this.btnCancelBorrow.Click += new System.EventHandler(this.btnCancelBorrow_Click);
            // 
            // btnSaveBorrow
            // 
            this.btnSaveBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnSaveBorrow.FlatAppearance.BorderSize = 0;
            this.btnSaveBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBorrow.ForeColor = System.Drawing.Color.White;
            this.btnSaveBorrow.Location = new System.Drawing.Point(230, 366);
            this.btnSaveBorrow.Name = "btnSaveBorrow";
            this.btnSaveBorrow.Size = new System.Drawing.Size(106, 40);
            this.btnSaveBorrow.TabIndex = 51;
            this.btnSaveBorrow.Text = "Save";
            this.btnSaveBorrow.UseVisualStyleBackColor = false;
            this.btnSaveBorrow.Click += new System.EventHandler(this.btnSaveBorrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên Sách:";
            // 
            // EditBorrowOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 700);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbNguoiThue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTenSachBorrow);
            this.Controls.Add(this.btnCancelBorrow);
            this.Controls.Add(this.btnSaveBorrow);
            this.Controls.Add(this.label1);
            this.Name = "EditBorrowOrders";
            this.Text = "EditBorrowOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNguoiThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTenSachBorrow;
        private System.Windows.Forms.Button btnCancelBorrow;
        private System.Windows.Forms.Button btnSaveBorrow;
        private System.Windows.Forms.Label label1;
    }
}