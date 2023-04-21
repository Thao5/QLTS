namespace GUI_Quanly
{
    partial class AdminCards
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
            this.btnAddCards = new System.Windows.Forms.Button();
            this.btnDeleteCards = new System.Windows.Forms.Button();
            this.btnEditCards = new System.Windows.Forms.Button();
            this.dataGridAdminCards = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminCards)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnAddCards);
            this.panel2.Controls.Add(this.btnDeleteCards);
            this.panel2.Controls.Add(this.btnEditCards);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 60);
            this.panel2.TabIndex = 9;
            // 
            // btnAddCards
            // 
            this.btnAddCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnAddCards.FlatAppearance.BorderSize = 0;
            this.btnAddCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCards.ForeColor = System.Drawing.Color.White;
            this.btnAddCards.Location = new System.Drawing.Point(600, 10);
            this.btnAddCards.Name = "btnAddCards";
            this.btnAddCards.Size = new System.Drawing.Size(106, 40);
            this.btnAddCards.TabIndex = 2;
            this.btnAddCards.Text = "Add";
            this.btnAddCards.UseVisualStyleBackColor = false;
            this.btnAddCards.Click += new System.EventHandler(this.btnAddCards_Click);
            // 
            // btnDeleteCards
            // 
            this.btnDeleteCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnDeleteCards.FlatAppearance.BorderSize = 0;
            this.btnDeleteCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCards.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCards.Location = new System.Drawing.Point(852, 10);
            this.btnDeleteCards.Name = "btnDeleteCards";
            this.btnDeleteCards.Size = new System.Drawing.Size(106, 40);
            this.btnDeleteCards.TabIndex = 1;
            this.btnDeleteCards.Text = "Delete";
            this.btnDeleteCards.UseVisualStyleBackColor = false;
            this.btnDeleteCards.Click += new System.EventHandler(this.btnDeleteCards_Click);
            // 
            // btnEditCards
            // 
            this.btnEditCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnEditCards.FlatAppearance.BorderSize = 0;
            this.btnEditCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCards.ForeColor = System.Drawing.Color.White;
            this.btnEditCards.Location = new System.Drawing.Point(724, 10);
            this.btnEditCards.Name = "btnEditCards";
            this.btnEditCards.Size = new System.Drawing.Size(106, 40);
            this.btnEditCards.TabIndex = 0;
            this.btnEditCards.Text = "Edit";
            this.btnEditCards.UseVisualStyleBackColor = false;
            // 
            // dataGridAdminCards
            // 
            this.dataGridAdminCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAdminCards.Location = new System.Drawing.Point(0, 0);
            this.dataGridAdminCards.Name = "dataGridAdminCards";
            this.dataGridAdminCards.RowHeadersWidth = 51;
            this.dataGridAdminCards.RowTemplate.Height = 24;
            this.dataGridAdminCards.Size = new System.Drawing.Size(1042, 675);
            this.dataGridAdminCards.TabIndex = 10;
            // 
            // AdminCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 735);
            this.Controls.Add(this.dataGridAdminCards);
            this.Controls.Add(this.panel2);
            this.Name = "AdminCards";
            this.Text = "AdminCards";
            this.Load += new System.EventHandler(this.AdminCards_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCards;
        private System.Windows.Forms.Button btnDeleteCards;
        private System.Windows.Forms.Button btnEditCards;
        private System.Windows.Forms.DataGridView dataGridAdminCards;
    }
}