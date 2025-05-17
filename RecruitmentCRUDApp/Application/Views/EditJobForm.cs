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

namespace RecruitmentApplication.Views
{
    public partial class EditJobForm : Form
    {
        private int jobId;
        public EditJobForm(int jobId )
        {
            InitializeComponent();
            this.jobId = jobId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;";

            // validate fields
            if (string.IsNullOrWhiteSpace(tboxTitle.Text))
            {
                MessageBox.Show("Please enter a job title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tboxTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tboxDescription.Text))
            {
                MessageBox.Show("Please enter a job description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tboxDescription.Focus();
                return;
            }

            if (cmboxExpLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an experience level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmboxExpLevel.Focus();
                return;
            }

            if (cmboxWorkMode.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a work mode.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmboxWorkMode.Focus();
                return;
            }

            if (cmboxJobType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a job type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmboxJobType.Focus();
                return;
            }

            if (cmboxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmboxStatus.Focus();
                return;
            }

            if (jobId <= 0)
            {
                MessageBox.Show("Invalid job ID. Cannot update job vacancy!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string updateQuery = @"UPDATE Vacancy 
                                        SET title = @Title, 
                                            description = @Description, 
                                            skills = @Skills, 
                                            status = @Status, 
                                            experience_level = @ExpLevel, 
                                            work_mode = @WorkMode, 
                                            job_type = @JobType, 
                                            deadline = @Deadline
                                        WHERE vacancy_id = @VacancyId";

                            using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Title", tboxTitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@Description", tboxDescription.Text.Trim());
                                cmd.Parameters.AddWithValue("@Skills", tboxSkills.Text.Trim());
                                cmd.Parameters.AddWithValue("@Status", cmboxStatus.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@ExpLevel", cmboxExpLevel.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@WorkMode", cmboxWorkMode.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@JobType", cmboxJobType.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@Deadline", dateDeadline.Value);
                                cmd.Parameters.AddWithValue("@VacancyId", jobId);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Job vacancy updated successfully!", "Success",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // EZ PEASY 
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Failed to update job vacancy. The job may no longer exist.",
                                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating job vacancy: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditJobForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string getJobDataQuery = "SELECT * FROM [Vacancy] WHERE vacancy_id = @jobId";
                SqlCommand cmd = new SqlCommand(getJobDataQuery, connection);
                cmd.Parameters.AddWithValue("@jobId", jobId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tboxTitle.Text = reader["title"].ToString();
                    cmboxStatus.Text = reader["status"].ToString();
                    cmboxExpLevel.Text = reader["experience_level"].ToString();
                    cmboxWorkMode.Text = reader["work_mode"].ToString();
                    cmboxJobType.Text = reader["job_type"].ToString();
                    if (reader["deadline"] != DBNull.Value)
                        dateDeadline.Value = Convert.ToDateTime(reader["deadline"]);
                    else
                        dateDeadline.Value = DateTime.Now;
                    tboxSkills.Text = reader["skills"].ToString();
                    tboxDescription.Text = reader["description"].ToString();
                } 
                else
                {
                    MessageBox.Show("Failed to fetch job data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
