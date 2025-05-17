using RecruitmentApplication.Views.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public event EventHandler<LoginEventArgs> OnLogin;

        private static frmSignup signupForm;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // create the signup form if it doesnt exist yet
            if (signupForm == null || signupForm.IsDisposed)
            {
                signupForm = new frmSignup();
            }

            // show the signup form
            signupForm.Show();

            // hide this form
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            OnLogin?.Invoke(this, new LoginEventArgs(email, password));
        }
    }
}