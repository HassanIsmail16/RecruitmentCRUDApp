using Microsoft.VisualBasic.ApplicationServices;
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

        private void btnSaveChangesSkills_Click(object sender, EventArgs e)
        {
            string skills = textBoxSkills.Text;
            string interests = textBoxInterests.Text;

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string saveUserChangesQuery =
                    "UPDATE [User] " +
                    "SET skills = @skills, interests = @interests" +
                    "WHERE user_id = @userId;";
                SqlCommand saveUserChangesCmd = new SqlCommand(saveUserChangesQuery, connection);
                saveUserChangesCmd.Parameters.AddWithValue("@skills", skills);
                saveUserChangesCmd.Parameters.AddWithValue("@interests", interests);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string removeResumeQuery =
                    "UPDATE[JobSeeker]" +
                    "SET resume = NULL" +
                    "WHERE user_id = @userId";
                SqlCommand removeResumeCmd = new SqlCommand(removeResumeQuery, connection);

                var result = removeResumeCmd.ExecuteNonQuery();
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            byte[] resume = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        resume = File.ReadAllBytes(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }
                else
                {
                    return; 
                }
            }

            if (resume == null)
            {
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string uploadResumeQuery =
                        "UPDATE [JobSeeker] " +
                        "SET resume = @resume " + 
                        "WHERE user_id = @userId;";

                    SqlCommand uploadResumeCmd = new SqlCommand(uploadResumeQuery, connection);

                    uploadResumeCmd.Parameters.AddWithValue("@resume", resume);
                    uploadResumeCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

                    var result = uploadResumeCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Saved changes successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to save changes. User not found or no resume to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
