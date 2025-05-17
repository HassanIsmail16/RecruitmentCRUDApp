using RecruitmentApplication.Views.Auth;
using System;
using System.Windows.Forms;

namespace RecruitmentApplication.Views
{
    public partial class frmLogin : Form
    {
        public class LoginEventArgs : EventArgs
        {
            public string Email { get; }
            public string Password { get; }

            public LoginEventArgs(string email, string password)
            {
                Email = email;
                Password = password;
            }
        }

        private static frmSignup signupForm;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelSignupMsg_Click(object sender, EventArgs e)
        {
        }
    }
}