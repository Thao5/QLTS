namespace GUI_Quanly
{
    partial class AdminPublishers
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
            this.btnAddPublishers = new System.Windows.Forms.Button();
            this.btnDeletePublishers = new System.Windows.Forms.Button();
            this.btnEditPublishers = new System.Windows.Forms.Button();
            this.dataGridAdminPublishers = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnAddPublishers);
            this.panel2.Controls.Add(this.btnDeletePublishers);
            this.panel2.Controls.Add(this.btnEditPublishers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 60);
            this.panel2.TabIndex = 7;
            // 
            // btnAddPublishers
            // 
            this.btnAddPublishers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPublishers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnAddPublishers.FlatAppearance.BorderSize = 0;
            this.btnAddPublishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublishers.ForeColor = System.Drawing.Color.White;
            this.btnAddPublishers.Location = new System.Drawing.Point(592, 10);
            this.btnAddPublishers.Name = "btnAddPublishers";
            this.btnAddPublishers.Size = new System.Drawing.Size(106, 40);
            this.btnAddPublishers.TabIndex = 2;
            this.btnAddPublishers.Text = "Add";
            this.btnAddPublishers.UseVisualStyleBackColor = false;
            this.btnAddPublishers.Click += new System.EventHandler(this.btnAddPublishers_Click);
            // 
            // btnDeletePublishers
            // 
            this.btnDeletePublishers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletePublishers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnDeletePublishers.FlatAppearance.BorderSize = 0;
            this.btnDeletePublishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePublishers.ForeColor = System.Drawing.Color.White;
            this.btnDeletePublishers.Location = new System.Drawing.Point(844, 10);
            this.btnDeletePublishers.Name = "btnDeletePublishers";
            this.btnDeletePublishers.Size = new System.Drawing.Size(106, 40);
            this.btnDeletePublishers.TabIndex = 1;
            this.btnDeletePublishers.Text = "Delete";
            this.btnDeletePublishers.UseVisualStyleBackColor = false;
            this.btnDeletePublishers.Click += new System.EventHandler(this.btnDeletePublishers_Click);
            // 
            // btnEditPublishers
            // 
            this.btnEditPublishers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditPublishers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnEditPublishers.FlatAppearance.BorderSize = 0;
            this.btnEditPublishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPublishers.ForeColor = System.Drawing.Color.White;
            this.btnEditPublishers.Location = new System.Drawing.Point(716, 10);
            this.btnEditPublishers.Name = "btnEditPublishers";
            this.btnEditPublishers.Size = new System.Drawing.Size(106, 40);
            this.btnEditPublishers.TabIndex = 0;
            this.btnEditPublishers.Text = "Edit";
            this.btnEditPublishers.UseVisualStyleBackColor = false;
            // 
            // dataGridAdminPublishers
            // 
            this.dataGridAdminPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAdminPublishers.Location = new System.Drawing.Point(0, 0);
            this.dataGridAdminPublishers.Name = "dataGridAdminPublishers";
            this.dataGridAdminPublishers.RowHeadersWidth = 51;
            this.dataGridAdminPublishers.RowTemplate.Height = 24;
            this.dataGridAdminPublishers.Size = new System.Drawing.Size(1027, 677);
            this.dataGridAdminPublishers.TabIndex = 8;
            // 
            // AdminPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 737);
            this.Controls.Add(this.dataGridAdminPublishers);
            this.Controls.Add(this.panel2);
            this.Name = "AdminPublishers";
            this.Text = "AdminPublishers";
            this.Load += new System.EventHandler(this.AdminPublishers_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddPublishers;
        private System.Windows.Forms.Button btnDeletePublishers;
        private System.Windows.Forms.Button btnEditPublishers;
        private System.Windows.Forms.DataGridView dataGridAdminPublishers;
    }
}