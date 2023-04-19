namespace GUI_Quanly
{
    partial class Authors
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
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.RowHeadersWidth = 51;
            this.dataGridAuthors.RowTemplate.Height = 24;
            this.dataGridAuthors.Size = new System.Drawing.Size(922, 739);
            this.dataGridAuthors.TabIndex = 2;
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 739);
            this.Controls.Add(this.dataGridAuthors);
            this.Name = "Authors";
            this.Text = "Authors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAuthors;
    }
}