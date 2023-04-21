namespace GUI_Quanly
{
    partial class ThongKe
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhaXB = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridThongKeMuon = new System.Windows.Forms.DataGridView();
            this.dataGridThongKeBan = new System.Windows.Forms.DataGridView();
            this.lbTotalSachMuon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalSachBan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongKeMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongKeBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "NXB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thống kê theo:";
            // 
            // cbNhaXB
            // 
            this.cbNhaXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaXB.FormattingEnabled = true;
            this.cbNhaXB.Location = new System.Drawing.Point(296, 28);
            this.cbNhaXB.Name = "cbNhaXB";
            this.cbNhaXB.Size = new System.Drawing.Size(442, 37);
            this.cbNhaXB.TabIndex = 29;
            // 
            // cbTime
            // 
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "Tất cả",
            "Năm",
            "Tháng"});
            this.cbTime.Location = new System.Drawing.Point(296, 98);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(442, 37);
            this.cbTime.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian:";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(296, 180);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(442, 34);
            this.txtTime.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thống kê sách mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thống kê sách bán";
            // 
            // dataGridThongKeMuon
            // 
            this.dataGridThongKeMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThongKeMuon.Location = new System.Drawing.Point(19, 327);
            this.dataGridThongKeMuon.Name = "dataGridThongKeMuon";
            this.dataGridThongKeMuon.RowHeadersWidth = 51;
            this.dataGridThongKeMuon.RowTemplate.Height = 24;
            this.dataGridThongKeMuon.Size = new System.Drawing.Size(401, 150);
            this.dataGridThongKeMuon.TabIndex = 31;
            // 
            // dataGridThongKeBan
            // 
            this.dataGridThongKeBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThongKeBan.Location = new System.Drawing.Point(472, 327);
            this.dataGridThongKeBan.Name = "dataGridThongKeBan";
            this.dataGridThongKeBan.RowHeadersWidth = 51;
            this.dataGridThongKeBan.RowTemplate.Height = 24;
            this.dataGridThongKeBan.Size = new System.Drawing.Size(400, 150);
            this.dataGridThongKeBan.TabIndex = 32;
            // 
            // lbTotalSachMuon
            // 
            this.lbTotalSachMuon.AutoSize = true;
            this.lbTotalSachMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSachMuon.Location = new System.Drawing.Point(140, 491);
            this.lbTotalSachMuon.Name = "lbTotalSachMuon";
            this.lbTotalSachMuon.Size = new System.Drawing.Size(83, 38);
            this.lbTotalSachMuon.TabIndex = 5;
            this.lbTotalSachMuon.Text = "total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total:";
            // 
            // lbTotalSachBan
            // 
            this.lbTotalSachBan.AutoSize = true;
            this.lbTotalSachBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSachBan.Location = new System.Drawing.Point(588, 491);
            this.lbTotalSachBan.Name = "lbTotalSachBan";
            this.lbTotalSachBan.Size = new System.Drawing.Size(83, 38);
            this.lbTotalSachBan.TabIndex = 5;
            this.lbTotalSachBan.Text = "total";
            this.lbTotalSachBan.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 38);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tổng doanh thu:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(451, 572);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(83, 38);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "total";
            this.lbTotal.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(773, 98);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(157, 39);
            this.btnThongKe.TabIndex = 33;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(773, 163);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(157, 39);
            this.btnAll.TabIndex = 33;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 643);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dataGridThongKeBan);
            this.Controls.Add(this.dataGridThongKeMuon);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbNhaXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTotalSachBan);
            this.Controls.Add(this.lbTotalSachMuon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongKeMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongKeBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhaXB;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridThongKeMuon;
        private System.Windows.Forms.DataGridView dataGridThongKeBan;
        private System.Windows.Forms.Label lbTotalSachMuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalSachBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnAll;
    }
}