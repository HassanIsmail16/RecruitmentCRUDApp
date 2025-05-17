using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecruitmentApplication.Views.Auth;

namespace JobsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var signupForm = new frmSignup();
            signupForm.Show();
            this.Hide(); // Optional: hides Form1 if you want only the signup form visible
        }
    }
}
