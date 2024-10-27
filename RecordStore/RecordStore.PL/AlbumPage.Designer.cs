namespace RecordStore.PL
{
    partial class AlbumPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumPage));
            dgvAlbums = new DataGridView();
            albumModelBindingSource = new BindingSource(components);
            lblUserName = new Label();
            txtAlbumName = new TextBox();
            lblArtist = new Label();
            lblPublishedDate = new Label();
            lblPrice = new Label();
            lblDiscount = new Label();
            txtArtist = new TextBox();
            txtPrice = new TextBox();
            txtDiscount = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnReports = new Button();
            dtpPublishedDate = new DateTimePicker();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            singersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            publishedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deletedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbums
            // 
            dgvAlbums.AllowUserToAddRows = false;
            dgvAlbums.AllowUserToDeleteRows = false;
            dgvAlbums.AutoGenerateColumns = false;
            dgvAlbums.BackgroundColor = Color.BlanchedAlmond;
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, singersDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, ısActiveDataGridViewCheckBoxColumn, publishedDateDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, updatedDateDataGridViewTextBoxColumn, deletedDateDataGridViewTextBoxColumn });
            dgvAlbums.DataSource = albumModelBindingSource;
            dgvAlbums.GridColor = Color.Peru;
            dgvAlbums.Location = new Point(334, 241);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.ReadOnly = true;
            dgvAlbums.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbums.Size = new Size(599, 265);
            dgvAlbums.TabIndex = 0;
            dgvAlbums.CellClick += dgvAlbums_CellClick;
            // 
            // albumModelBindingSource
            // 
            albumModelBindingSource.DataSource = typeof(BLL.Models.Concrete.AlbumModel);
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = Color.FromArgb(64, 0, 0);
            lblUserName.Location = new Point(410, 42);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(209, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Album Name";
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(410, 71);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(209, 23);
            txtAlbumName.TabIndex = 3;
            // 
            // lblArtist
            // 
            lblArtist.BackColor = Color.Transparent;
            lblArtist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblArtist.ForeColor = Color.FromArgb(64, 0, 0);
            lblArtist.Location = new Point(410, 108);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(209, 23);
            lblArtist.TabIndex = 4;
            lblArtist.Text = "Artist";
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.BackColor = Color.Transparent;
            lblPublishedDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPublishedDate.ForeColor = Color.FromArgb(64, 0, 0);
            lblPublishedDate.Location = new Point(667, 42);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(209, 23);
            lblPublishedDate.TabIndex = 5;
            lblPublishedDate.Text = "Publised Date";
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPrice.ForeColor = Color.FromArgb(64, 0, 0);
            lblPrice.Location = new Point(667, 108);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(209, 23);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = Color.Transparent;
            lblDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDiscount.ForeColor = Color.FromArgb(64, 0, 0);
            lblDiscount.Location = new Point(667, 173);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(209, 23);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = "Discount";
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(410, 134);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(209, 23);
            txtArtist.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(667, 134);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(667, 199);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(209, 23);
            txtDiscount.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(443, 526);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 35);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(555, 526);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 35);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(667, 526);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 35);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(827, 526);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(106, 35);
            btnReports.TabIndex = 15;
            btnReports.Text = "REPORTS";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // dtpPublishedDate
            // 
            dtpPublishedDate.Format = DateTimePickerFormat.Short;
            dtpPublishedDate.Location = new Point(667, 71);
            dtpPublishedDate.Name = "dtpPublishedDate";
            dtpPublishedDate.Size = new Size(200, 23);
            dtpPublishedDate.TabIndex = 16;
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
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Albüm Adı";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 5;
            // 
            // singersDataGridViewTextBoxColumn
            // 
            singersDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            singersDataGridViewTextBoxColumn.DataPropertyName = "Singers";
            singersDataGridViewTextBoxColumn.HeaderText = "Şarkıcı Adı";
            singersDataGridViewTextBoxColumn.Name = "singersDataGridViewTextBoxColumn";
            singersDataGridViewTextBoxColumn.ReadOnly = true;
            singersDataGridViewTextBoxColumn.Width = 5;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 57;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "İndirim";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            discountDataGridViewTextBoxColumn.Width = 70;
            // 
            // ısActiveDataGridViewCheckBoxColumn
            // 
            ısActiveDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ısActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            ısActiveDataGridViewCheckBoxColumn.HeaderText = "Durumu";
            ısActiveDataGridViewCheckBoxColumn.Name = "ısActiveDataGridViewCheckBoxColumn";
            ısActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            ısActiveDataGridViewCheckBoxColumn.Width = 57;
            // 
            // publishedDateDataGridViewTextBoxColumn
            // 
            publishedDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            publishedDateDataGridViewTextBoxColumn.DataPropertyName = "PublishedDate";
            publishedDateDataGridViewTextBoxColumn.HeaderText = "Yayınlanma Tarihi";
            publishedDateDataGridViewTextBoxColumn.Name = "publishedDateDataGridViewTextBoxColumn";
            publishedDateDataGridViewTextBoxColumn.ReadOnly = true;
            publishedDateDataGridViewTextBoxColumn.Width = 5;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "Oluşturulma Tarihi";
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            createdDateDataGridViewTextBoxColumn.Width = 5;
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            updatedDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            updatedDateDataGridViewTextBoxColumn.HeaderText = "Güncellenme Tarihi";
            updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            updatedDateDataGridViewTextBoxColumn.ReadOnly = true;
            updatedDateDataGridViewTextBoxColumn.Width = 5;
            // 
            // deletedDateDataGridViewTextBoxColumn
            // 
            deletedDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            deletedDateDataGridViewTextBoxColumn.DataPropertyName = "DeletedDate";
            deletedDateDataGridViewTextBoxColumn.HeaderText = "Silinme Tarihi";
            deletedDateDataGridViewTextBoxColumn.Name = "deletedDateDataGridViewTextBoxColumn";
            deletedDateDataGridViewTextBoxColumn.ReadOnly = true;
            deletedDateDataGridViewTextBoxColumn.Width = 5;
            // 
            // AlbumPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(945, 573);
            Controls.Add(dtpPublishedDate);
            Controls.Add(btnReports);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtDiscount);
            Controls.Add(txtPrice);
            Controls.Add(txtArtist);
            Controls.Add(lblDiscount);
            Controls.Add(lblPrice);
            Controls.Add(lblPublishedDate);
            Controls.Add(lblArtist);
            Controls.Add(txtAlbumName);
            Controls.Add(lblUserName);
            Controls.Add(dgvAlbums);
            Name = "AlbumPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlbumPage";
            Load += AlbumPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlbums;
        private Label lblUserName;
        private TextBox txtAlbumName;
        private Label lblArtist;
        private Label lblPublishedDate;
        private Label lblPrice;
        private Label lblDiscount;
        private TextBox txtArtist;
        private TextBox txtPrice;
        private TextBox txtDiscount;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnReports;
        private DateTimePicker dtpPublishedDate;
        private BindingSource albumModelBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn singersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ısActiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn publishedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deletedDateDataGridViewTextBoxColumn;
    }
}