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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumPage));
            dgvAlbums = new DataGridView();
            lblUserName = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbums
            // 
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.Location = new Point(289, 228);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.Size = new Size(499, 168);
            dgvAlbums.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = Color.FromArgb(64, 0, 0);
            lblUserName.Location = new Point(289, 42);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(209, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Album Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(289, 71);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(209, 23);
            txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(289, 108);
            label1.Name = "label1";
            label1.Size = new Size(209, 23);
            label1.TabIndex = 4;
            label1.Text = "Artist";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(545, 42);
            label2.Name = "label2";
            label2.Size = new Size(209, 23);
            label2.TabIndex = 5;
            label2.Text = "Publised Date";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(545, 108);
            label3.Name = "label3";
            label3.Size = new Size(209, 23);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(545, 173);
            label4.Name = "label4";
            label4.Size = new Size(209, 23);
            label4.TabIndex = 7;
            label4.Text = "Discount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(545, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(545, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(545, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 23);
            textBox4.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(298, 412);
            button1.Name = "button1";
            button1.Size = new Size(106, 35);
            button1.TabIndex = 12;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(410, 412);
            button2.Name = "button2";
            button2.Size = new Size(106, 35);
            button2.TabIndex = 13;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(522, 412);
            button3.Name = "button3";
            button3.Size = new Size(106, 35);
            button3.TabIndex = 14;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(682, 412);
            button4.Name = "button4";
            button4.Size = new Size(106, 35);
            button4.TabIndex = 15;
            button4.Text = "REPORTS";
            button4.UseVisualStyleBackColor = true;
            // 
            // AlbumPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(dgvAlbums);
            Name = "AlbumPage";
            Text = "AlbumPage";
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlbums;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}