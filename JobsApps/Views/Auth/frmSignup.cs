using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecruitmentApplication.Views;
using static RecruitmentApplication.Views.frmLogin;

namespace RecruitmentApplication.Views.Auth
{
    public partial class frmSignup : Form
    {
        private static frmLogin loginForm;
        public class SignUpEventArgs
        {
            public string FullName { get; }
            public string Email { get; }
            public string Password { get; }
            public string ConfirmPassword { get; }
            public string PhoneNumber { get; }
            public DateTime? BirthDate { get; }
            public string UserType { get; }

            public SignUpEventArgs(string fullName, string email, string password,
                string confirmPassword, string phoneNumber, DateTime? birthDate, string userType)
            {
                FullName = fullName;
                Email = email;
                Password = password;
                ConfirmPassword = confirmPassword;
                PhoneNumber = phoneNumber;
                BirthDate = birthDate;
                UserType = userType;
            }
        }

        public event EventHandler<SignUpEventArgs> OnSignUp;

        public frmSignup()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // create the login form if it doesnt exist yet
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new frmLogin();
            }

            // show the login form
            loginForm.Show();

            // hide this form
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime? birthDate = this.birthDate.Value;
            
            string userType;
            if (radioBtnEmployer.Checked)
            {
                userType = "Employer";
            } else
            {
                userType = "JobSeeker";
            }
            
            OnSignUp?.Invoke(this, new SignUpEventArgs(fullName, email, password, confirmPassword, phoneNumber, birthDate, userType));   

        }
    }
}