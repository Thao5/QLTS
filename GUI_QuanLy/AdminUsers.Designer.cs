namespace GUI_Quanly
{
    partial class AdminUsers
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
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.dataGridAdminUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnUpdateUser);
            this.panel2.Controls.Add(this.btnAddUsers);
            this.panel2.Controls.Add(this.btnDeleteUsers);
            this.panel2.Controls.Add(this.btnEditUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 60);
            this.panel2.TabIndex = 8;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnAddUsers.FlatAppearance.BorderSize = 0;
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.ForeColor = System.Drawing.Color.White;
            this.btnAddUsers.Location = new System.Drawing.Point(600, 10);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(106, 40);
            this.btnAddUsers.TabIndex = 2;
            this.btnAddUsers.Text = "Add";
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnDeleteUsers.FlatAppearance.BorderSize = 0;
            this.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUsers.Location = new System.Drawing.Point(852, 10);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(106, 40);
            this.btnDeleteUsers.TabIndex = 1;
            this.btnDeleteUsers.Text = "Delete";
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnEditUsers.FlatAppearance.BorderSize = 0;
            this.btnEditUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUsers.ForeColor = System.Drawing.Color.White;
            this.btnEditUsers.Location = new System.Drawing.Point(724, 10);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(106, 40);
            this.btnEditUsers.TabIndex = 0;
            this.btnEditUsers.Text = "Edit";
            this.btnEditUsers.UseVisualStyleBackColor = false;
            // 
            // dataGridAdminUsers
            // 
            this.dataGridAdminUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAdminUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridAdminUsers.Name = "dataGridAdminUsers";
            this.dataGridAdminUsers.RowHeadersWidth = 51;
            this.dataGridAdminUsers.RowTemplate.Height = 24;
            this.dataGridAdminUsers.Size = new System.Drawing.Size(1042, 669);
            this.dataGridAdminUsers.TabIndex = 9;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(468, 10);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(106, 40);
            this.btnUpdateUser.TabIndex = 32;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 729);
            this.Controls.Add(this.dataGridAdminUsers);
            this.Controls.Add(this.panel2);
            this.Name = "AdminUsers";
            this.Text = "AdminUsers";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.DataGridView dataGridAdminUsers;
        private System.Windows.Forms.Button btnUpdateUser;
    }
}