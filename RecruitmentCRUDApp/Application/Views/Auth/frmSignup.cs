using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using RecruitmentApplication.Views;

namespace RecruitmentApplication.Views.Auth
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new frmLogin();
            loginForm.Show();
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

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string isEmailDuplicateQuery = "SELECT * FROM [User] WHERE email = @email";
                SqlCommand isEmailDuplicateCmd = new SqlCommand(isEmailDuplicateQuery, connection);
                isEmailDuplicateCmd.Parameters.Add(new SqlParameter("@email", email));

                using (SqlDataReader reader = isEmailDuplicateCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("An account already exists with this email.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                bool passwordsMatch = password == confirmPassword;
                if (!passwordsMatch)
                {
                    MessageBox.Show("Passwords do not match.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string signupQuery = 
                    "INSERT INTO [User] " +
                    "(name, email, password, phone, birth_date, user_type) " +
                    "VALUES (@name, @email, @password, @phone, @birthDate, @userType)";
                SqlCommand signupCmd = new SqlCommand(signupQuery, connection);
                signupCmd.Parameters.AddWithValue("@name", fullName);
                signupCmd.Parameters.AddWithValue("@email", email);
                signupCmd.Parameters.AddWithValue("@password", password);
                signupCmd.Parameters.AddWithValue("@phone", phoneNumber);
                signupCmd.Parameters.AddWithValue("@birthDate", birthDate ?? (object) DBNull.Value);
                signupCmd.Parameters.AddWithValue("@userType", userType); 
                var result = signupCmd.ExecuteNonQuery();
                
                if (result > 0)
                {
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var loginForm = new frmLogin();
                    loginForm.Show();
                    this.Hide();

                } 
                else
                {
                    MessageBox.Show("Account creation failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}