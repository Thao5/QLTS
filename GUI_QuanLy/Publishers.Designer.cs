namespace GUI_Quanly
{
    partial class Publishers
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
            this.dataGridPublishers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPublishers
            // 
            this.dataGridPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPublishers.Location = new System.Drawing.Point(0, 0);
            this.dataGridPublishers.Name = "dataGridPublishers";
            this.dataGridPublishers.RowHeadersWidth = 51;
            this.dataGridPublishers.RowTemplate.Height = 24;
            this.dataGridPublishers.Size = new System.Drawing.Size(919, 729);
            this.dataGridPublishers.TabIndex = 2;
            // 
            // Publishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 729);
            this.Controls.Add(this.dataGridPublishers);
            this.Name = "Publishers";
            this.Text = "Publishers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPublishers;
    }
}