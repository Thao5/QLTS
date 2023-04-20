namespace GUI_Quanly
{
    partial class AddBorrowOrders
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
            this.cbNguoiThue = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTenSachBorrow = new System.Windows.Forms.ComboBox();
            this.btnCancelBorrow = new System.Windows.Forms.Button();
            this.btnSaveBorrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNguoiThue
            // 
            this.cbNguoiThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNguoiThue.FormattingEnabled = true;
            this.cbNguoiThue.Location = new System.Drawing.Point(232, 177);
            this.cbNguoiThue.Name = "cbNguoiThue";
            this.cbNguoiThue.Size = new System.Drawing.Size(354, 37);
            this.cbNguoiThue.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Người Thuê:";
            // 
            // cbTenSachBorrow
            // 
            this.cbTenSachBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSachBorrow.FormattingEnabled = true;
            this.cbTenSachBorrow.Location = new System.Drawing.Point(232, 103);
            this.cbTenSachBorrow.Name = "cbTenSachBorrow";
            this.cbTenSachBorrow.Size = new System.Drawing.Size(354, 37);
            this.cbTenSachBorrow.TabIndex = 45;
            // 
            // btnCancelBorrow
            // 
            this.btnCancelBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnCancelBorrow.FlatAppearance.BorderSize = 0;
            this.btnCancelBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBorrow.ForeColor = System.Drawing.Color.White;
            this.btnCancelBorrow.Location = new System.Drawing.Point(407, 348);
            this.btnCancelBorrow.Name = "btnCancelBorrow";
            this.btnCancelBorrow.Size = new System.Drawing.Size(106, 40);
            this.btnCancelBorrow.TabIndex = 44;
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
            this.btnSaveBorrow.Location = new System.Drawing.Point(216, 348);
            this.btnSaveBorrow.Name = "btnSaveBorrow";
            this.btnSaveBorrow.Size = new System.Drawing.Size(106, 40);
            this.btnSaveBorrow.TabIndex = 43;
            this.btnSaveBorrow.Text = "Save";
            this.btnSaveBorrow.UseVisualStyleBackColor = false;
            this.btnSaveBorrow.Click += new System.EventHandler(this.btnSaveBorrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên Sách:";
            // 
            // dateNgayThue
            // 
            this.dateNgayThue.CustomFormat = "dd/MM/yyyy";
            this.dateNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayThue.Location = new System.Drawing.Point(232, 230);
            this.dateNgayThue.Name = "dateNgayThue";
            this.dateNgayThue.Size = new System.Drawing.Size(354, 34);
            this.dateNgayThue.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày Thuê:";
            // 
            // AddBorrowOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 682);
            this.Controls.Add(this.dateNgayThue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNguoiThue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTenSachBorrow);
            this.Controls.Add(this.btnCancelBorrow);
            this.Controls.Add(this.btnSaveBorrow);
            this.Controls.Add(this.label1);
            this.Name = "AddBorrowOrders";
            this.Text = "AddBorrowOrders";
            this.Load += new System.EventHandler(this.AddBorrowOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNguoiThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTenSachBorrow;
        private System.Windows.Forms.Button btnCancelBorrow;
        private System.Windows.Forms.Button btnSaveBorrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNgayThue;
        private System.Windows.Forms.Label label3;
    }
}