﻿namespace GUI_Quanly
{
    partial class EditBuyOrders
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
            this.cbNguoiMua = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTenSachBuy = new System.Windows.Forms.ComboBox();
            this.btnCancelBuy = new System.Windows.Forms.Button();
            this.btnSaveBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(234, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(354, 34);
            this.txtID.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(146, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "ID Mua:";
            // 
            // cbNguoiMua
            // 
            this.cbNguoiMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNguoiMua.FormattingEnabled = true;
            this.cbNguoiMua.Location = new System.Drawing.Point(234, 253);
            this.cbNguoiMua.Name = "cbNguoiMua";
            this.cbNguoiMua.Size = new System.Drawing.Size(354, 37);
            this.cbNguoiMua.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Người Mua:";
            // 
            // cbTenSachBuy
            // 
            this.cbTenSachBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSachBuy.FormattingEnabled = true;
            this.cbTenSachBuy.Location = new System.Drawing.Point(234, 179);
            this.cbTenSachBuy.Name = "cbTenSachBuy";
            this.cbTenSachBuy.Size = new System.Drawing.Size(354, 37);
            this.cbTenSachBuy.TabIndex = 55;
            // 
            // btnCancelBuy
            // 
            this.btnCancelBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnCancelBuy.FlatAppearance.BorderSize = 0;
            this.btnCancelBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBuy.ForeColor = System.Drawing.Color.White;
            this.btnCancelBuy.Location = new System.Drawing.Point(399, 387);
            this.btnCancelBuy.Name = "btnCancelBuy";
            this.btnCancelBuy.Size = new System.Drawing.Size(106, 40);
            this.btnCancelBuy.TabIndex = 54;
            this.btnCancelBuy.Text = "Cancel";
            this.btnCancelBuy.UseVisualStyleBackColor = false;
            this.btnCancelBuy.Click += new System.EventHandler(this.btnCancelBuy_Click);
            // 
            // btnSaveBuy
            // 
            this.btnSaveBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnSaveBuy.FlatAppearance.BorderSize = 0;
            this.btnSaveBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBuy.ForeColor = System.Drawing.Color.White;
            this.btnSaveBuy.Location = new System.Drawing.Point(208, 387);
            this.btnSaveBuy.Name = "btnSaveBuy";
            this.btnSaveBuy.Size = new System.Drawing.Size(106, 40);
            this.btnSaveBuy.TabIndex = 53;
            this.btnSaveBuy.Text = "Save";
            this.btnSaveBuy.UseVisualStyleBackColor = false;
            this.btnSaveBuy.Click += new System.EventHandler(this.btnSaveBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tên Sách:";
            // 
            // EditBuyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 708);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbNguoiMua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTenSachBuy);
            this.Controls.Add(this.btnCancelBuy);
            this.Controls.Add(this.btnSaveBuy);
            this.Controls.Add(this.label1);
            this.Name = "EditBuyOrders";
            this.Text = "EditBuyOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNguoiMua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTenSachBuy;
        private System.Windows.Forms.Button btnCancelBuy;
        private System.Windows.Forms.Button btnSaveBuy;
        private System.Windows.Forms.Label label1;
    }
}