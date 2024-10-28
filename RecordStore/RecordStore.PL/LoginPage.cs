using RecordStore.BLL.Managers.Concrete;
using RecordStore.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using RecordStore.BLL.Models.Concrete;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecordStore.PL
{
    public partial class LoginPage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.ShowDialog();
        }

        public string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(a => a.ToString("x2")));
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtPassword.Text;
            string hassedPassword = sha256_hash(userPassword);
            bool correct = false;

            using (UserManager userManager = new UserManager(_unitOfWork))
            {
                var userModels = userManager.GetAll().ToList();

                foreach (var userModel in userModels)
                {
                    if (hassedPassword == userModel.Password && userName == userModel.UserName)
                    {
                        correct = true;
                        AlbumPage albumPage = new AlbumPage();
                        albumPage.ShowDialog();
                        return;
                    }

                }

                if (correct == false)
                {
                    MessageBox.Show("Hatalı giriş");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
