namespace GUI_Quanly
{
    partial class EditCards
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
            this.cbUserCard = new System.Windows.Forms.ComboBox();
            this.dateNgayNap = new System.Windows.Forms.DateTimePicker();
            this.cbTrangThaiCard = new System.Windows.Forms.ComboBox();
            this.btnCancelCards = new System.Windows.Forms.Button();
            this.btnSaveCards = new System.Windows.Forms.Button();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbUserCard
            // 
            this.cbUserCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserCard.FormattingEnabled = true;
            this.cbUserCard.Location = new System.Drawing.Point(266, 237);
            this.cbUserCard.Name = "cbUserCard";
            this.cbUserCard.Size = new System.Drawing.Size(354, 37);
            this.cbUserCard.TabIndex = 62;
            // 
            // dateNgayNap
            // 
            this.dateNgayNap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayNap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayNap.Location = new System.Drawing.Point(266, 180);
            this.dateNgayNap.Name = "dateNgayNap";
            this.dateNgayNap.Size = new System.Drawing.Size(184, 34);
            this.dateNgayNap.TabIndex = 61;
            // 
            // cbTrangThaiCard
            // 
            this.cbTrangThaiCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThaiCard.FormattingEnabled = true;
            this.cbTrangThaiCard.Location = new System.Drawing.Point(266, 122);
            this.cbTrangThaiCard.Name = "cbTrangThaiCard";
            this.cbTrangThaiCard.Size = new System.Drawing.Size(354, 37);
            this.cbTrangThaiCard.TabIndex = 60;
            // 
            // btnCancelCards
            // 
            this.btnCancelCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnCancelCards.FlatAppearance.BorderSize = 0;
            this.btnCancelCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCards.ForeColor = System.Drawing.Color.White;
            this.btnCancelCards.Location = new System.Drawing.Point(405, 405);
            this.btnCancelCards.Name = "btnCancelCards";
            this.btnCancelCards.Size = new System.Drawing.Size(106, 40);
            this.btnCancelCards.TabIndex = 59;
            this.btnCancelCards.Text = "Cancel";
            this.btnCancelCards.UseVisualStyleBackColor = false;
            this.btnCancelCards.Click += new System.EventHandler(this.btnCancelCards_Click);
            // 
            // btnSaveCards
            // 
            this.btnSaveCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnSaveCards.FlatAppearance.BorderSize = 0;
            this.btnSaveCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCards.ForeColor = System.Drawing.Color.White;
            this.btnSaveCards.Location = new System.Drawing.Point(212, 405);
            this.btnSaveCards.Name = "btnSaveCards";
            this.btnSaveCards.Size = new System.Drawing.Size(106, 40);
            this.btnSaveCards.TabIndex = 58;
            this.btnSaveCards.Text = "Save";
            this.btnSaveCards.UseVisualStyleBackColor = false;
            this.btnSaveCards.Click += new System.EventHandler(this.btnSaveCards_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(266, 296);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(354, 34);
            this.txtGiaTien.TabIndex = 57;
            this.txtGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Giá Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "User Card:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Ngày Nạp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Trạng Thái:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCard.Location = new System.Drawing.Point(266, 72);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(354, 34);
            this.txtIDCard.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID:";
            // 
            // EditCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 665);
            this.Controls.Add(this.cbUserCard);
            this.Controls.Add(this.dateNgayNap);
            this.Controls.Add(this.cbTrangThaiCard);
            this.Controls.Add(this.btnCancelCards);
            this.Controls.Add(this.btnSaveCards);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.label1);
            this.Name = "EditCards";
            this.Text = "EditCards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUserCard;
        private System.Windows.Forms.DateTimePicker dateNgayNap;
        private System.Windows.Forms.ComboBox cbTrangThaiCard;
        private System.Windows.Forms.Button btnCancelCards;
        private System.Windows.Forms.Button btnSaveCards;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label1;
    }
}