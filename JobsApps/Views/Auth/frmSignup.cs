using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
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

            // Password match check
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtPassword.Focus();
                return;
            }

            string userType = radioBtnEmployer.Checked ? "Employer" : "JobSeeker";

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-7RP4DTQ6;Initial Catalog=Recruitment;Integrated Security=True;Trust Server Certificate=True"))
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [User] (name, email, password, phone, birth_date,user_type) VALUES (@fullName, @email, @password, @phoneNumber, @birthDate,@userType)", conn))
                {
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@birthDate", birthDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@userType", userType);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Signup failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnJobseeker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnEmployer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gboxUserType_Enter(object sender, EventArgs e)
        {

        }
    }
}