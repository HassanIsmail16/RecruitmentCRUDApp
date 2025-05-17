using Microsoft.Data.SqlClient;
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

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [User] WHERE email = @email AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mainform = new MainForm();
                            mainform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
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