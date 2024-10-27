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
            
            using(UserManager userManager = new UserManager(_unitOfWork))
            {
                string validateGuidRegex = @"^(?=(?:[^A-Z]*[A-Z]){2})(?=(?:[^a-z]*[a-z]){3})(?=(?:[^!+:*]*[!+:*]){2})[A-Za-z0-9!+:*]{8,}$";

                UserModel model = new UserModel();

                string passwordCheck = txtPassword.Text;
                
                if(Regex.IsMatch(passwordCheck, validateGuidRegex))
                {
                    txtUserName.Text = model.UserName;
                    passwordCheck = model.Password;
                }
                else
                {
                    MessageBox.Show("");
                }
            }
        }
    }
}
