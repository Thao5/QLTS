﻿namespace GUI_Quanly
{
    partial class AddCards
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
            this.cbTrangThaiCard = new System.Windows.Forms.ComboBox();
            this.btnCancelCards = new System.Windows.Forms.Button();
            this.btnSaveCards = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTrangThaiCard
            // 
            this.cbTrangThaiCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThaiCard.FormattingEnabled = true;
            this.cbTrangThaiCard.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbTrangThaiCard.Location = new System.Drawing.Point(285, 98);
            this.cbTrangThaiCard.Name = "cbTrangThaiCard";
            this.cbTrangThaiCard.Size = new System.Drawing.Size(354, 37);
            this.cbTrangThaiCard.TabIndex = 48;
            this.cbTrangThaiCard.SelectedIndexChanged += new System.EventHandler(this.cbLoaiNguoiDung_SelectedIndexChanged);
            // 
            // btnCancelCards
            // 
            this.btnCancelCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnCancelCards.FlatAppearance.BorderSize = 0;
            this.btnCancelCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCards.ForeColor = System.Drawing.Color.White;
            this.btnCancelCards.Location = new System.Drawing.Point(405, 255);
            this.btnCancelCards.Name = "btnCancelCards";
            this.btnCancelCards.Size = new System.Drawing.Size(106, 40);
            this.btnCancelCards.TabIndex = 47;
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
            this.btnSaveCards.Location = new System.Drawing.Point(231, 255);
            this.btnSaveCards.Name = "btnSaveCards";
            this.btnSaveCards.Size = new System.Drawing.Size(106, 40);
            this.btnSaveCards.TabIndex = 46;
            this.btnSaveCards.Text = "Save";
            this.btnSaveCards.UseVisualStyleBackColor = false;
            this.btnSaveCards.Click += new System.EventHandler(this.btnSaveCards_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Trạng Thái:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCard.Location = new System.Drawing.Point(285, 48);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(354, 34);
            this.txtIDCard.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID:";
            // 
            // AddCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 609);
            this.Controls.Add(this.cbTrangThaiCard);
            this.Controls.Add(this.btnCancelCards);
            this.Controls.Add(this.btnSaveCards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.label1);
            this.Name = "AddCards";
            this.Text = "AddCards";
            this.Load += new System.EventHandler(this.AddCards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTrangThaiCard;
        private System.Windows.Forms.Button btnCancelCards;
        private System.Windows.Forms.Button btnSaveCards;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label1;
    }
}