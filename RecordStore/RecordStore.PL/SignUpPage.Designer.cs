namespace RecordStore.PL
{
    partial class SignUpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPage));
            lblUserName = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = Color.FromArgb(64, 0, 0);
            lblUserName.Location = new Point(330, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(209, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(330, 41);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(209, 23);
            txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(330, 135);
            label1.Name = "label1";
            label1.Size = new Size(209, 23);
            label1.TabIndex = 4;
            label1.Text = "Password Again";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(330, 77);
            label2.Name = "label2";
            label2.Size = new Size(209, 23);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 7;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Gainsboro;
            btnSignUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSignUp.ForeColor = Color.FromArgb(64, 0, 0);
            btnSignUp.Location = new Point(587, 171);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(187, 39);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "SIGN UP 🎸";
            btnSignUp.TextAlign = ContentAlignment.TopCenter;
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignUp);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpPage";
            Text = "SignUpPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSignUp;
    }
}