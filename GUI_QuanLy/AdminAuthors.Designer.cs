namespace GUI_Quanly
{
    partial class AdminAuthors
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
            this.btnAddAuthors = new System.Windows.Forms.Button();
            this.btnDeleteAuthors = new System.Windows.Forms.Button();
            this.btnEditAuthors = new System.Windows.Forms.Button();
            this.dataGridAdminAuthors = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnAddAuthors);
            this.panel2.Controls.Add(this.btnDeleteAuthors);
            this.panel2.Controls.Add(this.btnEditAuthors);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 60);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddAuthors
            // 
            this.btnAddAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnAddAuthors.FlatAppearance.BorderSize = 0;
            this.btnAddAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthors.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthors.Location = new System.Drawing.Point(501, 8);
            this.btnAddAuthors.Name = "btnAddAuthors";
            this.btnAddAuthors.Size = new System.Drawing.Size(106, 40);
            this.btnAddAuthors.TabIndex = 31;
            this.btnAddAuthors.Text = "Add";
            this.btnAddAuthors.UseVisualStyleBackColor = false;
            this.btnAddAuthors.Click += new System.EventHandler(this.btnAddAuthors_Click);
            // 
            // btnDeleteAuthors
            // 
            this.btnDeleteAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnDeleteAuthors.FlatAppearance.BorderSize = 0;
            this.btnDeleteAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthors.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAuthors.Location = new System.Drawing.Point(751, 8);
            this.btnDeleteAuthors.Name = "btnDeleteAuthors";
            this.btnDeleteAuthors.Size = new System.Drawing.Size(106, 40);
            this.btnDeleteAuthors.TabIndex = 1;
            this.btnDeleteAuthors.Text = "Delete";
            this.btnDeleteAuthors.UseVisualStyleBackColor = false;
            this.btnDeleteAuthors.Click += new System.EventHandler(this.btnDeleteAuthors_Click);
            // 
            // btnEditAuthors
            // 
            this.btnEditAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnEditAuthors.FlatAppearance.BorderSize = 0;
            this.btnEditAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAuthors.ForeColor = System.Drawing.Color.White;
            this.btnEditAuthors.Location = new System.Drawing.Point(623, 8);
            this.btnEditAuthors.Name = "btnEditAuthors";
            this.btnEditAuthors.Size = new System.Drawing.Size(106, 40);
            this.btnEditAuthors.TabIndex = 0;
            this.btnEditAuthors.Text = "Edit";
            this.btnEditAuthors.UseVisualStyleBackColor = false;
            // 
            // dataGridAdminAuthors
            // 
            this.dataGridAdminAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAdminAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridAdminAuthors.Name = "dataGridAdminAuthors";
            this.dataGridAdminAuthors.RowHeadersWidth = 51;
            this.dataGridAdminAuthors.RowTemplate.Height = 24;
            this.dataGridAdminAuthors.Size = new System.Drawing.Size(1049, 681);
            this.dataGridAdminAuthors.TabIndex = 7;
            // 
            // AdminAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 741);
            this.Controls.Add(this.dataGridAdminAuthors);
            this.Controls.Add(this.panel2);
            this.Name = "AdminAuthors";
            this.Text = "AdminAuthors";
            this.Load += new System.EventHandler(this.AdminAuthors_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteAuthors;
        private System.Windows.Forms.Button btnEditAuthors;
        private System.Windows.Forms.DataGridView dataGridAdminAuthors;
        private System.Windows.Forms.Button btnAddAuthors;
    }
}