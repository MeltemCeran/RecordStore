namespace RecordStore.PL
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = Color.FromArgb(64, 0, 0);
            lblUserName.Location = new Point(82, 193);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(209, 23);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(82, 219);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(209, 23);
            txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassword.ForeColor = Color.FromArgb(64, 0, 0);
            lblPassword.Location = new Point(82, 259);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(209, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(209, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Tag = "*";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Gainsboro;
            btnSignUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSignUp.ForeColor = Color.FromArgb(64, 0, 0);
            btnSignUp.Location = new Point(471, 325);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(187, 39);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "SIGN UP!";
            btnSignUp.TextAlign = ContentAlignment.TopCenter;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gainsboro;
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = Color.FromArgb(64, 0, 0);
            btnLogin.Location = new Point(93, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN!";
            btnLogin.TextAlign = ContentAlignment.TopCenter;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "*";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Button btnLogin;
    }
}