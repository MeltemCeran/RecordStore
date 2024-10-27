namespace RecordStore.PL
{
    partial class ReportPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPages));
            dgvQuery1 = new DataGridView();
            dgvQuery2 = new DataGridView();
            dgvQuery4 = new DataGridView();
            dgvQuery3 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQuery1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery3).BeginInit();
            SuspendLayout();
            // 
            // dgvQuery1
            // 
            dgvQuery1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery1.Location = new Point(28, 155);
            dgvQuery1.Name = "dgvQuery1";
            dgvQuery1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery1.Size = new Size(428, 152);
            dgvQuery1.TabIndex = 0;
            // 
            // dgvQuery2
            // 
            dgvQuery2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery2.Location = new Point(490, 155);
            dgvQuery2.Name = "dgvQuery2";
            dgvQuery2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery2.Size = new Size(428, 152);
            dgvQuery2.TabIndex = 1;
            // 
            // dgvQuery4
            // 
            dgvQuery4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery4.Location = new Point(490, 385);
            dgvQuery4.Name = "dgvQuery4";
            dgvQuery4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery4.Size = new Size(428, 152);
            dgvQuery4.TabIndex = 3;
            // 
            // dgvQuery3
            // 
            dgvQuery3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery3.Location = new Point(28, 385);
            dgvQuery3.Name = "dgvQuery3";
            dgvQuery3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery3.Size = new Size(428, 152);
            dgvQuery3.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(28, 112);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 4;
            label1.Text = "Satışta Olanlar";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(490, 112);
            label2.Name = "label2";
            label2.Size = new Size(198, 31);
            label2.TabIndex = 5;
            label2.Text = "Satışı Bitenler";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(28, 341);
            label3.Name = "label3";
            label3.Size = new Size(198, 31);
            label3.TabIndex = 6;
            label3.Text = "İndirimde Olanlar";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(490, 341);
            label4.Name = "label4";
            label4.Size = new Size(266, 31);
            label4.TabIndex = 7;
            label4.Text = "Eklenen Son 10 Albüm";
            // 
            // ReportPages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(945, 573);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvQuery4);
            Controls.Add(dgvQuery3);
            Controls.Add(dgvQuery2);
            Controls.Add(dgvQuery1);
            DoubleBuffered = true;
            Name = "ReportPages";
            Text = "ReportPages";
            Load += ReportPages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuery1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvQuery1;
        private DataGridView dgvQuery2;
        private DataGridView dgvQuery4;
        private DataGridView dgvQuery3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}