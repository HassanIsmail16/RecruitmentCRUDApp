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

namespace RecruitmentApplication.Views.Auth
{
    public partial class frmSignup : Form
    {
        private static frmLogin loginForm;

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
    }
}