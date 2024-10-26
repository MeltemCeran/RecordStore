namespace RecordStore.PL
{
    partial class WelcomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            btnNext = new Button();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(235, 227, 222);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNext.ForeColor = Color.FromArgb(64, 0, 0);
            btnNext.Location = new Point(658, 379);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(111, 41);
            btnNext.TabIndex = 0;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BamsRecord!";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNext;
    }
}
