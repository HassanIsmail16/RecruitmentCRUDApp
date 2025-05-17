using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Models;
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
    public partial class JobsControl : UserControl
    {
        public JobsControl()
        {
            InitializeComponent();
            InitializeGrid();

            tboxSearchInput.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char) Keys.Enter)
                    Search();
            };
        }

        private void InitializeGrid()
        {
            var applyButtonColumn = new DataGridViewButtonColumn();
            applyButtonColumn.Name = "Apply";
            applyButtonColumn.HeaderText = "Apply";
            applyButtonColumn.Text = "Apply";
            applyButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostings.Columns.Add(applyButtonColumn);

            var detailsButtonColumn = new DataGridViewButtonColumn();
            detailsButtonColumn.Name = "Details";
            detailsButtonColumn.HeaderText = "Details";
            detailsButtonColumn.Text = "Details";
            detailsButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostings.Columns.Add(detailsButtonColumn);

            var saveButtonColumn = new DataGridViewButtonColumn();
            saveButtonColumn.Name = "Save";
            saveButtonColumn.HeaderText = "Save";
            saveButtonColumn.Text = "Save";
            saveButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostings.Columns.Add(saveButtonColumn);
            // TODO: make columns read only
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void JobsControl_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }

        private void RefreshDataGridView(string whereClause = "")
        {
            if (string.IsNullOrEmpty(whereClause))
            {
                tboxSearchInput.Text = "";
                ClearFilters();
            }

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getJobDataQuery = "SELECT * FROM [Vacancy]";
                if (!string.IsNullOrWhiteSpace(whereClause))
                    getJobDataQuery += " WHERE " + whereClause;

                SqlCommand getJobDataCmd = new SqlCommand(getJobDataQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(getJobDataCmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridPostings.DataSource = table;
            }
        }

        private void ClearFilters()
        {
            cbxJobTypeFullTime.Checked = false;
            cbxJobTypePartTime.Checked = false;
            cbxJobTypeContract.Checked = false;

            cboxWorkModeOnSite.Checked = false;
            cboxWorkModeRemote.Checked = false;
            cboxWorkModeHybrid.Checked = false;

            cboxExperienceLevelSenior.Checked = false;
            cboxExperienceLevelMidLevel.Checked = false;
            cboxExperienceLevelJunior.Checked = false;
            cboxExperienceLevelFreshGrad.Checked = false;
            cboxExperienceLevelStudent.Checked = false;
        }

        private void dataGridPostings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridPostings.Columns[e.ColumnIndex].Name == "Details")
            {
                var jobIdObj = dataGridPostings.Rows[e.RowIndex].Cells["vacancy_id"].Value;
                if (jobIdObj != null && int.TryParse(jobIdObj.ToString(), out int jobId))
                {
                    var detailsForm = new JobDetailsForm(jobId);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to show job details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (dataGridPostings.Columns[e.ColumnIndex].Name == "Save")
            {
                var jobIdObj = dataGridPostings.Rows[e.RowIndex].Cells["vacancy_id"].Value;
                if (jobIdObj != null && int.TryParse(jobIdObj.ToString(), out int jobId))
                {
                    SaveJob(jobId);
                }
                else
                {
                    MessageBox.Show("Failed to show job details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (dataGridPostings.Columns[e.ColumnIndex].Name == "Apply")
            {
                var jobIdObj = dataGridPostings.Rows[e.RowIndex].Cells["vacancy_id"].Value;
                var emplIdObj = dataGridPostings.Rows[e.RowIndex].Cells["employer_id"].Value;
                var jobTitleObj = dataGridPostings.Rows[e.RowIndex].Cells["title"].Value;

                if ((jobIdObj != null && int.TryParse(jobIdObj.ToString(), out int jobId))
                    && (emplIdObj != null && int.TryParse(emplIdObj.ToString(), out int empId)))
                {
                    string jobTitle = jobTitleObj?.ToString() ?? "this job";

                    if (HasUserAlreadAppliedToJob(jobId))
                    {
                        MessageBox.Show("You have already applied to this job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to apply to \"{jobTitle}\"?",
                        "Confirm Application",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        ApplyToJob(jobId, empId);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to apply to the job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void SaveJob(int jobId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (IsJobAlreadySaved(jobId, connection))
                {
                    MessageBox.Show("Job is already saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string saveJobQuery =
                    "INSERT INTO [SavedJob] " +
                    "(jobseeker_id, vacancy_id) " +
                    "VALUES (@userId, @jobId);";
                SqlCommand saveJobCmd = new SqlCommand(saveJobQuery, connection);
                saveJobCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                saveJobCmd.Parameters.AddWithValue("@jobId", jobId);

                var result = saveJobCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Job has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to save job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApplyToJob(int jobId, int employerId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string applyToJobQuery =
                    @"INSERT INTO [JobApplication]
                      (jobseeker_id, vacancy_id, employer_id)
                      VALUES (@userId, @jobId, @empId);";
                SqlCommand applyToJobCommand = new SqlCommand(applyToJobQuery, connection);
                applyToJobCommand.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                applyToJobCommand.Parameters.AddWithValue("@jobId", jobId);
                applyToJobCommand.Parameters.AddWithValue("@empId", employerId);

                var result = applyToJobCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully applied to job.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to apply to the job.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool HasUserAlreadAppliedToJob(int jobId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string hasUserAppliedQuery = "SELECT * FROM [JobApplication] WHERE vacancy_id = @jobId AND jobseeker_id = @userId";
                SqlCommand hasUserAppliedCmd = new SqlCommand(hasUserAppliedQuery, connection);
                hasUserAppliedCmd.Parameters.AddWithValue("@jobId", jobId);
                hasUserAppliedCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                SqlDataReader reader = hasUserAppliedCmd.ExecuteReader();
                bool applied = reader.HasRows;
                reader.Close();
                return applied;
            }
        }

        private bool IsJobAlreadySaved(int jobId, SqlConnection connection)
        {
            string isJobSavedQuery = "SELECT * FROM [SavedJob] WHERE vacancy_id = @jobId AND jobseeker_id = @userId";
            SqlCommand isJobSavedCmd = new SqlCommand(isJobSavedQuery, connection);
            isJobSavedCmd.Parameters.AddWithValue("@jobId", jobId);
            isJobSavedCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
            SqlDataReader reader = isJobSavedCmd.ExecuteReader();
            bool saved = reader.HasRows;
            reader.Close();
            return saved;
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string filters = GetFilterCondition();
            RefreshDataGridView(filters);
        }

        private string GetFilterCondition()
        {
            List<string> filters = new List<string>();

            // Job Type
            List<string> jobTypeFilters = new List<string>();
            if (cbxJobTypeFullTime.Checked)
                jobTypeFilters.Add("job_type = 'Full-Time'");
            if (cbxJobTypePartTime.Checked)
                jobTypeFilters.Add("job_type = 'Part-Time'");
            if (cbxJobTypeContract.Checked)
                jobTypeFilters.Add("job_type = 'Contract'");
            if (jobTypeFilters.Count > 0)
                filters.Add("(" + string.Join(" OR ", jobTypeFilters) + ")");

            // Work Mode
            List<string> workModeFilters = new List<string>();
            if (cboxWorkModeOnSite.Checked)
                workModeFilters.Add("work_mode = 'On-Site'");
            if (cboxWorkModeRemote.Checked)
                workModeFilters.Add("work_mode = 'Remote'");
            if (cboxWorkModeHybrid.Checked)
                workModeFilters.Add("work_mode = 'Hybrid'");
            if (workModeFilters.Count > 0)
                filters.Add("(" + string.Join(" OR ", workModeFilters) + ")");

            // Experience Level
            List<string> experienceLevelFilters = new List<string>();
            if (cboxExperienceLevelSenior.Checked)
                experienceLevelFilters.Add("experience_level = 'Senior'");
            if (cboxExperienceLevelMidLevel.Checked)
                experienceLevelFilters.Add("experience_level = 'Mid-Level'");
            if (cboxExperienceLevelJunior.Checked)
                experienceLevelFilters.Add("experience_level = 'Junior'");
            if (cboxExperienceLevelFreshGrad.Checked)
                experienceLevelFilters.Add("experience_level = 'Fresh Graduate'");
            if (cboxExperienceLevelStudent.Checked)
                experienceLevelFilters.Add("experience_level = 'Student'");
            if (experienceLevelFilters.Count > 0)
                filters.Add("(" + string.Join(" OR ", experienceLevelFilters) + ")");

            return string.Join(" AND ", filters);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string searchTerm = tboxSearchInput.Text.Trim();

            string searchCondition =
                "(title LIKE '%" + searchTerm + "%' OR " +
                "description LIKE '%" + searchTerm + "%' OR " +
                "skills LIKE '%" + searchTerm + "%')";

            string filterCondition = GetFilterCondition();
            List<string> allConditions = new List<string> { "status = 'Open'" };

            if (!string.IsNullOrWhiteSpace(filterCondition))
                allConditions.Add(filterCondition);

            allConditions.Add(searchCondition);

            string finalWhereClause = string.Join(" AND ", allConditions);

            RefreshDataGridView(finalWhereClause);
        }
    }
}
