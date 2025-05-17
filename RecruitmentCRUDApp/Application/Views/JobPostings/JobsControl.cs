﻿using Microsoft.Data.SqlClient;
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
        private DataTable dataSource;
        private string currentSortColumn = "";
        private System.Windows.Forms.SortOrder currentSortOrder = System.Windows.Forms.SortOrder.None;
        public JobsControl()
        {
            InitializeComponent();
            InitializeGrid();

            tboxSearchInput.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char) Keys.Enter)
                {
                    e.Handled = true;
                    Search();
                }
            };
        }

        private void InitializeGrid()
        {
            dataGridPostings.Columns.Clear();

            dataGridPostings.Columns.Add("title", "Title");
            dataGridPostings.Columns.Add("experience_level", "Experience Level");
            dataGridPostings.Columns.Add("job_type", "Job Type");
            dataGridPostings.Columns.Add("work_mode", "Work Mode");
            dataGridPostings.Columns.Add("deadline", "Deadline");
            dataGridPostings.Columns.Add("company_name", "Company");
            dataGridPostings.Columns.Add("employer_name", "Employer");

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

            dataGridPostings.AllowUserToAddRows = false;
            dataGridPostings.AutoGenerateColumns = false;
            dataGridPostings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn column in dataGridPostings.Columns)
            {
                if (!(column is DataGridViewButtonColumn))
                {
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
                column.ReadOnly = true;
            }

            dataGridPostings.ColumnHeaderMouseClick += (sender, e) =>
            {
                if (e.ColumnIndex < 0 || dataGridPostings.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    return;

                string columnName = dataGridPostings.Columns[e.ColumnIndex].Name;

                if (columnName == currentSortColumn)
                {
                    currentSortOrder = currentSortOrder == System.Windows.Forms.SortOrder.Ascending ?
                        System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;
                }
                else
                {
                    currentSortColumn = columnName;
                    currentSortOrder = System.Windows.Forms.SortOrder.Ascending;
                }

                SortData(columnName, currentSortOrder);

                foreach (DataGridViewColumn col in dataGridPostings.Columns)
                {
                    col.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                }
                dataGridPostings.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = currentSortOrder;
            };
        }

        private void SortData(string columnName, System.Windows.Forms.SortOrder sortOrder)
        {
            if (dataSource == null) return;

            DataView dv = dataSource.DefaultView;

            if (columnName == "deadline")
            {
                if (!dataSource.Columns.Contains("_sort_deadline"))
                {
                    dataSource.Columns.Add("_sort_deadline", typeof(DateTime));
                }

                foreach (DataRow row in dataSource.Rows)
                {
                    row["_sort_deadline"] = row["deadline"] == DBNull.Value
                        ? DateTime.MaxValue
                        : DateTime.Parse(row["deadline"].ToString());
                }
                dv.Sort = $"_sort_deadline {(sortOrder == System.Windows.Forms.SortOrder.Ascending ? "ASC" : "DESC")}";
            }
            else
            {
                dv.Sort = $"{columnName} {(sortOrder == System.Windows.Forms.SortOrder.Ascending ? "ASC" : "DESC")}";
            }

            dataSource = dv.ToTable();

            if (dataSource.Columns.Contains("_sort_deadline"))
            {
                dataSource.Columns.Remove("_sort_deadline");
            }

            PopulateDataGridView();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void JobsControl_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView(string whereClause = "", string searchTerm = "")
        {
            if (string.IsNullOrEmpty(whereClause))
            {
                if (string.IsNullOrEmpty(searchTerm))
                {
                    tboxSearchInput.Text = "";
                }
                ClearFilters();
            }

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getJobDataQuery = @"
            SELECT 
                v.vacancy_id,
                v.title,
                v.experience_level,
                v.job_type,
                v.work_mode,
                CASE 
                    WHEN v.deadline IS NULL THEN NULL 
                    ELSE FORMAT(v.deadline, 'dd MMM yyyy') 
                END AS deadline,
                c.name AS company_name,
                u.name AS employer_name,
                v.employer_id
            FROM [Vacancy] v
            INNER JOIN Company c ON v.company_id = c.company_id
            INNER JOIN Employer e ON v.employer_id = e.user_id
            INNER JOIN [User] u ON e.user_id = u.user_id";

                if (!string.IsNullOrWhiteSpace(whereClause))
                    getJobDataQuery += " WHERE " + whereClause;

                SqlCommand getJobDataCmd = new SqlCommand(getJobDataQuery, connection);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    getJobDataCmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(getJobDataCmd);
                dataSource = new DataTable();

                adapter.Fill(dataSource);

                if (!string.IsNullOrEmpty(currentSortColumn))
                {
                    SortData(currentSortColumn, currentSortOrder);
                }
                else
                {
                    PopulateDataGridView();
                }
            }
        }

        private void PopulateDataGridView()
        {
            dataGridPostings.Rows.Clear();

            foreach (DataRow row in dataSource.Rows)
            {
                int rowIndex = dataGridPostings.Rows.Add(
                    row["title"],
                    row["experience_level"],
                    row["job_type"],
                    row["work_mode"],
                    row["deadline"] == DBNull.Value ? "No deadline" : row["deadline"],
                    row["company_name"],
                    row["employer_name"]
                );

                var rowData = new Dictionary<string, object>
                {
                    { "vacancy_id", row["vacancy_id"] },
                    { "employer_id", row["employer_id"] }
                };
                dataGridPostings.Rows[rowIndex].Tag = rowData;
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var row = dataGridPostings.Rows[e.RowIndex];
            var rowData = row.Tag as Dictionary<string, object>;

            if (rowData == null || !rowData.ContainsKey("vacancy_id") || !rowData.ContainsKey("employer_id"))
                return;

            int jobId = Convert.ToInt32(rowData["vacancy_id"]);
            int empId = Convert.ToInt32(rowData["employer_id"]);

            if (dataGridPostings.Columns[e.ColumnIndex].Name == "Details")
            {
                var detailsForm = new JobDetailsForm(jobId);
                detailsForm.ShowDialog();
            }
            else if (dataGridPostings.Columns[e.ColumnIndex].Name == "Save")
            {
                SaveJob(jobId);
            }
            else if (dataGridPostings.Columns[e.ColumnIndex].Name == "Apply")
            {
                string jobTitle = row.Cells["title"].Value?.ToString() ?? "this job";

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

            List<string> jobTypeFilters = new List<string>();
            if (cbxJobTypeFullTime.Checked)
                jobTypeFilters.Add("v.job_type = 'Full-Time'");
            if (cbxJobTypePartTime.Checked)
                jobTypeFilters.Add("v.job_type = 'Part-Time'");
            if (cbxJobTypeContract.Checked)
                jobTypeFilters.Add("v.job_type = 'Contract'");
            if (jobTypeFilters.Count > 0)
                filters.Add("(" + string.Join(" OR ", jobTypeFilters) + ")");

            List<string> workModeFilters = new List<string>();
            if (cboxWorkModeOnSite.Checked)
                workModeFilters.Add("v.work_mode = 'On-Site'");
            if (cboxWorkModeRemote.Checked)
                workModeFilters.Add("v.work_mode = 'Remote'");
            if (cboxWorkModeHybrid.Checked)
                workModeFilters.Add("v.work_mode = 'Hybrid'");
            if (workModeFilters.Count > 0)
                filters.Add("(" + string.Join(" OR ", workModeFilters) + ")");

            List<string> experienceLevelFilters = new List<string>();
            if (cboxExperienceLevelSenior.Checked)
                experienceLevelFilters.Add("v.experience_level = 'Senior'");
            if (cboxExperienceLevelMidLevel.Checked)
                experienceLevelFilters.Add("v.experience_level = 'Mid-Level'");
            if (cboxExperienceLevelJunior.Checked)
                experienceLevelFilters.Add("v.experience_level = 'Junior'");
            if (cboxExperienceLevelFreshGrad.Checked)
                experienceLevelFilters.Add("v.experience_level = 'Fresh Graduate'");
            if (cboxExperienceLevelStudent.Checked)
                experienceLevelFilters.Add("v.experience_level = 'Student'");
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

            List<string> allConditions = new List<string> { "v.status = 'Open'" };

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string searchCondition = $@"
            (v.title LIKE @searchTerm OR 
             v.description LIKE @searchTerm OR 
             v.skills LIKE @searchTerm OR
             v.job_type LIKE @searchTerm OR
             v.work_mode LIKE @searchTerm OR
             v.experience_level LIKE @searchTerm OR
             c.name LIKE @searchTerm OR
             u.name LIKE @searchTerm)";

                allConditions.Add(searchCondition);
            }

            string filterCondition = GetFilterCondition();
            if (!string.IsNullOrWhiteSpace(filterCondition))
            {
                allConditions.Add(filterCondition);
            }

            string finalWhereClause = allConditions.Count > 0
                ? string.Join(" AND ", allConditions)
                : "";

            RefreshDataGridView(finalWhereClause, searchTerm);
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
    }
}