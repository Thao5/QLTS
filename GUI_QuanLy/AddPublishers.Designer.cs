namespace GUI_Quanly
{
    partial class AddPublishers
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
            this.btnCancelPublisher = new System.Windows.Forms.Button();
            this.btnSavePublisher = new System.Windows.Forms.Button();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelPublisher
            // 
            this.btnCancelPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnCancelPublisher.FlatAppearance.BorderSize = 0;
            this.btnCancelPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPublisher.ForeColor = System.Drawing.Color.White;
            this.btnCancelPublisher.Location = new System.Drawing.Point(382, 320);
            this.btnCancelPublisher.Name = "btnCancelPublisher";
            this.btnCancelPublisher.Size = new System.Drawing.Size(106, 40);
            this.btnCancelPublisher.TabIndex = 31;
            this.btnCancelPublisher.Text = "Cancel";
            this.btnCancelPublisher.UseVisualStyleBackColor = false;
            this.btnCancelPublisher.Click += new System.EventHandler(this.btnCancelPublisher_Click);
            // 
            // btnSavePublisher
            // 
            this.btnSavePublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavePublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnSavePublisher.FlatAppearance.BorderSize = 0;
            this.btnSavePublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePublisher.ForeColor = System.Drawing.Color.White;
            this.btnSavePublisher.Location = new System.Drawing.Point(191, 320);
            this.btnSavePublisher.Name = "btnSavePublisher";
            this.btnSavePublisher.Size = new System.Drawing.Size(106, 40);
            this.btnSavePublisher.TabIndex = 30;
            this.btnSavePublisher.Text = "Save";
            this.btnSavePublisher.UseVisualStyleBackColor = false;
            this.btnSavePublisher.Click += new System.EventHandler(this.btnSavePublisher_Click);
            // 
            // txtNXB
            // 
            this.txtNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(310, 214);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(354, 34);
            this.txtNXB.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên Nhà Xuất Bản:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Nhà Xuất Bản:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(310, 165);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(354, 34);
            this.txtID.TabIndex = 17;
            // 
            // AddPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 579);
            this.Controls.Add(this.btnCancelPublisher);
            this.Controls.Add(this.btnSavePublisher);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPublishers";
            this.Text = "AddPublishers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPublisher;
        private System.Windows.Forms.Button btnSavePublisher;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
    }
}