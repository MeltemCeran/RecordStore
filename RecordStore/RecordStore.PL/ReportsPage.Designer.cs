namespace RecordStore.PL
{
    partial class ReportsPage
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
            dgvQuery1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvQuery1).BeginInit();
            SuspendLayout();
            // 
            // dgvQuery1
            // 
            dgvQuery1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery1.Location = new Point(152, 49);
            dgvQuery1.Name = "dgvQuery1";
            dgvQuery1.Size = new Size(240, 150);
            dgvQuery1.TabIndex = 0;
            // 
            // ReportsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvQuery1);
            Name = "ReportsPage";
            Text = "ReportsPage";
            Load += ReportsPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuery1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvQuery1;
    }
}