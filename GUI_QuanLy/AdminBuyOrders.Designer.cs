namespace GUI_Quanly
{
    partial class AdminBuyOrders
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddBuyOrders = new System.Windows.Forms.Button();
            this.btnDeleteBuyOrders = new System.Windows.Forms.Button();
            this.btnEditBuyOrders = new System.Windows.Forms.Button();
            this.dataGridAdminBuy = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnAddBuyOrders);
            this.panel2.Controls.Add(this.btnDeleteBuyOrders);
            this.panel2.Controls.Add(this.btnEditBuyOrders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 60);
            this.panel2.TabIndex = 5;
            // 
            // btnAddBuyOrders
            // 
            this.btnAddBuyOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBuyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnAddBuyOrders.FlatAppearance.BorderSize = 0;
            this.btnAddBuyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBuyOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBuyOrders.ForeColor = System.Drawing.Color.White;
            this.btnAddBuyOrders.Location = new System.Drawing.Point(581, 10);
            this.btnAddBuyOrders.Name = "btnAddBuyOrders";
            this.btnAddBuyOrders.Size = new System.Drawing.Size(106, 40);
            this.btnAddBuyOrders.TabIndex = 2;
            this.btnAddBuyOrders.Text = "Add";
            this.btnAddBuyOrders.UseVisualStyleBackColor = false;
            this.btnAddBuyOrders.Click += new System.EventHandler(this.btnAddBuyOrders_Click);
            // 
            // btnDeleteBuyOrders
            // 
            this.btnDeleteBuyOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteBuyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnDeleteBuyOrders.FlatAppearance.BorderSize = 0;
            this.btnDeleteBuyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBuyOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBuyOrders.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBuyOrders.Location = new System.Drawing.Point(833, 10);
            this.btnDeleteBuyOrders.Name = "btnDeleteBuyOrders";
            this.btnDeleteBuyOrders.Size = new System.Drawing.Size(106, 40);
            this.btnDeleteBuyOrders.TabIndex = 1;
            this.btnDeleteBuyOrders.Text = "Delete";
            this.btnDeleteBuyOrders.UseVisualStyleBackColor = false;
            this.btnDeleteBuyOrders.Click += new System.EventHandler(this.btnDeleteBuyOrders_Click);
            // 
            // btnEditBuyOrders
            // 
            this.btnEditBuyOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditBuyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnEditBuyOrders.FlatAppearance.BorderSize = 0;
            this.btnEditBuyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBuyOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBuyOrders.ForeColor = System.Drawing.Color.White;
            this.btnEditBuyOrders.Location = new System.Drawing.Point(705, 10);
            this.btnEditBuyOrders.Name = "btnEditBuyOrders";
            this.btnEditBuyOrders.Size = new System.Drawing.Size(106, 40);
            this.btnEditBuyOrders.TabIndex = 0;
            this.btnEditBuyOrders.Text = "Edit";
            this.btnEditBuyOrders.UseVisualStyleBackColor = false;
            // 
            // dataGridAdminBuy
            // 
            this.dataGridAdminBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAdminBuy.Location = new System.Drawing.Point(0, 0);
            this.dataGridAdminBuy.Name = "dataGridAdminBuy";
            this.dataGridAdminBuy.RowHeadersWidth = 51;
            this.dataGridAdminBuy.RowTemplate.Height = 24;
            this.dataGridAdminBuy.Size = new System.Drawing.Size(1004, 653);
            this.dataGridAdminBuy.TabIndex = 6;
            // 
            // AdminBuyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 713);
            this.Controls.Add(this.dataGridAdminBuy);
            this.Controls.Add(this.panel2);
            this.Name = "AdminBuyOrders";
            this.Text = "AdminBuyOrders";
            this.Load += new System.EventHandler(this.AdminBuyOrders_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminBuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteBuyOrders;
        private System.Windows.Forms.Button btnEditBuyOrders;
        private System.Windows.Forms.DataGridView dataGridAdminBuy;
        private System.Windows.Forms.Button btnAddBuyOrders;
    }
}