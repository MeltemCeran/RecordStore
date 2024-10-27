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
            lblPasswordAgaın = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtPasswordAgaın = new TextBox();
            btnSignUp = new Button();
            label1 = new Label();
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
            // lblPasswordAgaın
            // 
            lblPasswordAgaın.BackColor = Color.Transparent;
            lblPasswordAgaın.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPasswordAgaın.ForeColor = Color.FromArgb(64, 0, 0);
            lblPasswordAgaın.Location = new Point(330, 135);
            lblPasswordAgaın.Name = "lblPasswordAgaın";
            lblPasswordAgaın.Size = new Size(209, 23);
            lblPasswordAgaın.TabIndex = 4;
            lblPasswordAgaın.Text = "Password Again";
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassword.ForeColor = Color.FromArgb(64, 0, 0);
            lblPassword.Location = new Point(330, 77);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(209, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(330, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(209, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtPasswordAgaın
            // 
            txtPasswordAgaın.Location = new Point(330, 161);
            txtPasswordAgaın.Name = "txtPasswordAgaın";
            txtPasswordAgaın.Size = new Size(209, 23);
            txtPasswordAgaın.TabIndex = 7;
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
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(579, 25);
            label1.Name = "label1";
            label1.Size = new Size(209, 133);
            label1.TabIndex = 10;
            label1.Text = resources.GetString("label1.Text");
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(txtPasswordAgaın);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblPasswordAgaın);
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
        private Label lblPasswordAgaın;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtPasswordAgaın;
        private Button btnSignUp;
        private Label label1;
    }
}