using RecordStore.BLL.Managers.Concrete;
using RecordStore.BLL.Models.Concrete;
using RecordStore.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecordStore.PL
{
    public partial class SignUpPage : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Şifre için geçerlilik deseni
            string passwordPattern = @"^(?=(?:[^A-Z]*[A-Z]){2})(?=(?:[^a-z]*[a-z]){3})(?=(?:[^!+:*]*[!+:*]){2})[A-Za-z0-9!+:*]{8,}$";

            // Kullanıcıdan alınan girişler
            string enteredPassword = txtPassword.Text;
            string enteredUserName = txtUserName.Text;
            string repeatedPassword = txtPasswordAgaın.Text;

            // UserManager içinde işlem yapmaya başlıyoruz
            using (UserManager userManager = new UserManager(_unitOfWork))
            {
                // Kullanıcı adı benzersizliği kontrolü
                bool isUserNameTaken = userManager.GetAll().Any(user => user.UserName == enteredUserName);
                if (isUserNameTaken)
                {
                    MessageBox.Show("Bu kullanıcı adına sahip bir kullanıcı bulunmaktadır. Lütfen kullanıcı adınızı değiştirin.");
                    return;
                }

                // Şifre kriterlerini kontrol et
                if (!Regex.IsMatch(enteredPassword, passwordPattern))
                {
                    MessageBox.Show("Lütfen kriterlere uygun bir şifre girin.");
                    return;
                }

                // Şifrelerin eşleşme kontrolü
                if (enteredPassword != repeatedPassword)
                {
                    MessageBox.Show("Şifreler uyuşmamaktadır. Lütfen tekrar deneyin.");
                    return;
                }

                // Şifre ve kullanıcı adı kriterleri karşılandığında kullanıcı modeli oluşturma
                UserModel newUser = new UserModel
                {
                    UserName = enteredUserName,
                    Password = enteredPassword
                };

                // Yeni kullanıcıyı ekleme işlemi
                userManager.Add(newUser);

                // Başarılı olduğunda giriş sayfasını göster
                LoginPage loginPage = new LoginPage();
                loginPage.ShowDialog();
            }

        }
    }
}
