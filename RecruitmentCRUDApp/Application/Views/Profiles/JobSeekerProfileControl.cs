using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views.Profiles
{
    public partial class JobSeekerProfileControl : UserControl
    {
        public JobSeekerProfileControl()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime? birthDate = birthDatePicker.Value;

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string saveUserChangesQuery =
                    "UPDATE [User] " +
                    "SET name = @name, email = @email, password = @password, phone = @phoneNumber, birth_date = @birthDate " +
                    "WHERE user_id = @userId;";
                SqlCommand saveUserChangesCmd = new SqlCommand(saveUserChangesQuery, connection);
                saveUserChangesCmd.Parameters.AddWithValue("@name", fullname);
                saveUserChangesCmd.Parameters.AddWithValue("@email", email);
                saveUserChangesCmd.Parameters.AddWithValue("@password", password);
                saveUserChangesCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                saveUserChangesCmd.Parameters.AddWithValue("@birthDate", birthDate);
                saveUserChangesCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                var result = saveUserChangesCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Saved changes successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void JobSeekerProfileControl_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserId.HasValue)
            {
                int id = Session.CurrentUserId.Value;
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT name, email, phone, password, birth_date, signup_date FROM [User] WHERE user_id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelUserName.Text = reader["name"]?.ToString() ?? "";
                            txtFullName.Text = reader["name"]?.ToString() ?? "";
                            txtEmail.Text = reader["email"]?.ToString() ?? "";
                            txtPassword.Text = reader["password"]?.ToString() ?? "";
                            txtPhoneNumber.Text = reader["phone"]?.ToString() ?? "";
                            if (reader["birth_date"] != DBNull.Value)
                                birthDatePicker.Value = Convert.ToDateTime(reader["birth_date"]);
                            else
                                birthDatePicker.Value = DateTime.Now;
                            textBox4.Text = reader["signup_date"]?.ToString() ?? "";
                        }
                        else
                        {
                            ClearAllFields();
                        }
                    }
                }
            }
            else
            {
                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            labelUserName.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            birthDatePicker.Value = DateTime.Now;
            textBox4.Text = "";
        }
    }
}
