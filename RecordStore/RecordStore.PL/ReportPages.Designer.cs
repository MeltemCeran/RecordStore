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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPages));
            dgvQuery1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            singersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsActiveStr = new DataGridViewTextBoxColumn();
            ısActiveAlbumReportBindingSource = new BindingSource(components);
            dgvQuery2 = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            singersDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ısActiveStrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısActiveAlbumReportBindingSource1 = new BindingSource(components);
            dgvQuery4 = new DataGridView();
            ıdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            singersDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            reportAlbumResultBindingSource = new BindingSource(components);
            dgvQuery3 = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            singersDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            discountedAlbumReportBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ısActiveAlbumReportBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvQuery1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ısActiveAlbumReportBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ısActiveAlbumReportBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportAlbumResultBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountedAlbumReportBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ısActiveAlbumReportBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dgvQuery1
            // 
            dgvQuery1.AllowUserToAddRows = false;
            dgvQuery1.AllowUserToDeleteRows = false;
            dgvQuery1.AutoGenerateColumns = false;
            dgvQuery1.BackgroundColor = Color.SeaShell;
            dgvQuery1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, singersDataGridViewTextBoxColumn, IsActiveStr });
            dgvQuery1.DataSource = ısActiveAlbumReportBindingSource;
            dgvQuery1.Location = new Point(28, 155);
            dgvQuery1.Name = "dgvQuery1";
            dgvQuery1.ReadOnly = true;
            dgvQuery1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery1.Size = new Size(428, 152);
            dgvQuery1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Albüm Adı";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // singersDataGridViewTextBoxColumn
            // 
            singersDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            singersDataGridViewTextBoxColumn.DataPropertyName = "Singers";
            singersDataGridViewTextBoxColumn.HeaderText = "Şarkıcı Adı";
            singersDataGridViewTextBoxColumn.Name = "singersDataGridViewTextBoxColumn";
            singersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsActiveStr
            // 
            IsActiveStr.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            IsActiveStr.DataPropertyName = "IsActiveStr";
            IsActiveStr.HeaderText = "Durumu";
            IsActiveStr.Name = "IsActiveStr";
            IsActiveStr.ReadOnly = true;
            IsActiveStr.Width = 76;
            // 
            // ısActiveAlbumReportBindingSource
            // 
            ısActiveAlbumReportBindingSource.DataSource = typeof(BLL.Models.Concrete.IsActiveAlbumReport);
            // 
            // dgvQuery2
            // 
            dgvQuery2.AllowUserToAddRows = false;
            dgvQuery2.AllowUserToDeleteRows = false;
            dgvQuery2.AutoGenerateColumns = false;
            dgvQuery2.BackgroundColor = Color.SeaShell;
            dgvQuery2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery2.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, singersDataGridViewTextBoxColumn1, ısActiveStrDataGridViewTextBoxColumn });
            dgvQuery2.DataSource = ısActiveAlbumReportBindingSource1;
            dgvQuery2.Location = new Point(490, 155);
            dgvQuery2.Name = "dgvQuery2";
            dgvQuery2.ReadOnly = true;
            dgvQuery2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery2.Size = new Size(428, 152);
            dgvQuery2.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Albüm Adı";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // singersDataGridViewTextBoxColumn1
            // 
            singersDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            singersDataGridViewTextBoxColumn1.DataPropertyName = "Singers";
            singersDataGridViewTextBoxColumn1.HeaderText = "Şarkıcı Adı";
            singersDataGridViewTextBoxColumn1.Name = "singersDataGridViewTextBoxColumn1";
            singersDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ısActiveStrDataGridViewTextBoxColumn
            // 
            ısActiveStrDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ısActiveStrDataGridViewTextBoxColumn.DataPropertyName = "IsActiveStr";
            ısActiveStrDataGridViewTextBoxColumn.HeaderText = "Durumu";
            ısActiveStrDataGridViewTextBoxColumn.Name = "ısActiveStrDataGridViewTextBoxColumn";
            ısActiveStrDataGridViewTextBoxColumn.ReadOnly = true;
            ısActiveStrDataGridViewTextBoxColumn.Width = 76;
            // 
            // ısActiveAlbumReportBindingSource1
            // 
            ısActiveAlbumReportBindingSource1.DataSource = typeof(BLL.Models.Concrete.IsActiveAlbumReport);
            // 
            // dgvQuery4
            // 
            dgvQuery4.AllowUserToAddRows = false;
            dgvQuery4.AllowUserToDeleteRows = false;
            dgvQuery4.AutoGenerateColumns = false;
            dgvQuery4.BackgroundColor = Color.SeaShell;
            dgvQuery4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery4.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn3, singersDataGridViewTextBoxColumn3 });
            dgvQuery4.DataSource = reportAlbumResultBindingSource;
            dgvQuery4.Location = new Point(490, 385);
            dgvQuery4.Name = "dgvQuery4";
            dgvQuery4.ReadOnly = true;
            dgvQuery4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery4.Size = new Size(428, 152);
            dgvQuery4.TabIndex = 3;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            ıdDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            ıdDataGridViewTextBoxColumn1.Width = 42;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            nameDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn3.HeaderText = "Albüm Adı";
            nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // singersDataGridViewTextBoxColumn3
            // 
            singersDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            singersDataGridViewTextBoxColumn3.DataPropertyName = "Singers";
            singersDataGridViewTextBoxColumn3.HeaderText = "Şarkıcı Adı";
            singersDataGridViewTextBoxColumn3.Name = "singersDataGridViewTextBoxColumn3";
            singersDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // reportAlbumResultBindingSource
            // 
            reportAlbumResultBindingSource.DataSource = typeof(BLL.Models.Concrete.ReportAlbumResult);
            // 
            // dgvQuery3
            // 
            dgvQuery3.AllowUserToAddRows = false;
            dgvQuery3.AllowUserToDeleteRows = false;
            dgvQuery3.AutoGenerateColumns = false;
            dgvQuery3.BackgroundColor = Color.SeaShell;
            dgvQuery3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery3.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn2, singersDataGridViewTextBoxColumn2 });
            dgvQuery3.DataSource = discountedAlbumReportBindingSource;
            dgvQuery3.Location = new Point(28, 385);
            dgvQuery3.Name = "dgvQuery3";
            dgvQuery3.ReadOnly = true;
            dgvQuery3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuery3.Size = new Size(428, 152);
            dgvQuery3.TabIndex = 2;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.ReadOnly = true;
            ıdDataGridViewTextBoxColumn.Width = 42;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Albüm Adı";
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // singersDataGridViewTextBoxColumn2
            // 
            singersDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            singersDataGridViewTextBoxColumn2.DataPropertyName = "Singers";
            singersDataGridViewTextBoxColumn2.HeaderText = "Şarkıcı Adı";
            singersDataGridViewTextBoxColumn2.Name = "singersDataGridViewTextBoxColumn2";
            singersDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // discountedAlbumReportBindingSource
            // 
            discountedAlbumReportBindingSource.DataSource = typeof(BLL.Models.Concrete.DiscountedAlbumReport);
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
            // ısActiveAlbumReportBindingSource2
            // 
            ısActiveAlbumReportBindingSource2.DataSource = typeof(BLL.Models.Concrete.IsActiveAlbumReport);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportPages";
            Load += ReportPages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuery1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ısActiveAlbumReportBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ısActiveAlbumReportBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery4).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportAlbumResultBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuery3).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountedAlbumReportBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ısActiveAlbumReportBindingSource2).EndInit();
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
        private BindingSource ısActiveAlbumReportBindingSource;
        private BindingSource ısActiveAlbumReportBindingSource1;
        private BindingSource reportAlbumResultBindingSource;
        private BindingSource discountedAlbumReportBindingSource;
        private BindingSource ısActiveAlbumReportBindingSource2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn singersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IsActiveStr;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn singersDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ısActiveStrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn singersDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn singersDataGridViewTextBoxColumn2;
    }
}