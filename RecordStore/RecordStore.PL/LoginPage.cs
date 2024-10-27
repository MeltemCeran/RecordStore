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

        private bool ValidateUser(string userName, string userPassword)
        {
            userName = txtUserName.Text;
            userPassword = txtPassword.Text;

            using (UserManager userManager = new UserManager(_unitOfWork))
            {
                var userModels = userManager.GetAll().ToList();

                foreach (var userModel in userModels)
                {
                    if (userModel.UserName == userName && userModel.Password == userPassword)
                    {
                        AlbumPage albumPage = new AlbumPage();
                        return true;
                        
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;

                string hashedInputPassword;
            }
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(a => a.ToString("X2")));
            }
        }





        private void btnLogin_Click(object sender, EventArgs e)
            {
                string userName = txtUserName.Text;
                string userPassword = txtPassword.Text;

                using (UserManager userManager = new UserManager(_unitOfWork))
            {
                var userModels = userManager.GetAll().ToList();

                foreach (var userModel in userModels)
                {
                    if (userModel.UserName == userName )
                    {
                        AlbumPage albumPage = new AlbumPage();
                        albumPage.ShowDialog();
                    }

                    if(userModel.Password == userPassword)
                    {
                        
                    }
                    
                }
                MessageBox.Show("Şifre Yanlış!");
            }
        }

    }
}
