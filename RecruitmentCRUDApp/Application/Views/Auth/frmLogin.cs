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
    }
}