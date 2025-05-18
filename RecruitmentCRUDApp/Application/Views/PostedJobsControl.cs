using Microsoft.Data.SqlClient;
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
    public partial class PostedJobsControl : UserControl
    {
        public PostedJobsControl()
        {
            InitializeComponent();
            InitializeControlButtons();
            dataGridPostedJobs.CellClick += DataGridPostedJobs_CellClick;
            btnRefresh_Click(this, EventArgs.Empty);
        }

        private void InitializeControlButtons()
        {
            if (dataGridPostedJobs.Columns.Contains("colControl"))
            {
                dataGridPostedJobs.Columns.Remove("colControl");
            }

            var viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "colApplicants";
            viewButtonColumn.HeaderText = "Applicants";
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostedJobs.Columns.Add(viewButtonColumn);

            var editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "colEdit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostedJobs.Columns.Add(editButtonColumn);

            var deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "colDelete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridPostedJobs.Columns.Add(deleteButtonColumn);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // query to get vacancy data with company name
                    string query = @"SELECT 
                        v.vacancy_id, 
                        c.name AS CompanyName, 
                        v.title AS JobTitle, 
                        v.status AS Status,
                        v.work_mode AS WorkMode,
                        v.job_type AS JobType,
                        v.post_date AS PostDate,
                        v.deadline AS Deadline
                    FROM 
                        Vacancy v
                        INNER JOIN Company c ON v.company_id = c.company_id
                    WHERE 
                        v.employer_id = @employerId
                    ORDER BY 
                        v.post_date DESC";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employerId", Session.CurrentUserId);

                        dataGridPostedJobs.Rows.Clear();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int vacancyId = reader.GetInt32(reader.GetOrdinal("vacancy_id"));
                                    string companyName = reader.GetString(reader.GetOrdinal("CompanyName"));
                                    string jobTitle = reader.GetString(reader.GetOrdinal("JobTitle"));
                                    string status = reader.GetString(reader.GetOrdinal("Status"));
                                    string workMode = reader.GetString(reader.GetOrdinal("WorkMode"));
                                    string jobType = reader.GetString(reader.GetOrdinal("JobType"));
                                    DateTime postDate = reader.GetDateTime(reader.GetOrdinal("PostDate"));

                                    DateTime? deadline = null;
                                    if (!reader.IsDBNull(reader.GetOrdinal("Deadline")))
                                    {
                                        deadline = reader.GetDateTime(reader.GetOrdinal("Deadline"));
                                    }

                                    // add a new row
                                    int rowIndex = dataGridPostedJobs.Rows.Add();
                                    DataGridViewRow row = dataGridPostedJobs.Rows[rowIndex];

                                    // set values to each cell
                                    row.Cells[colCompanyName.Index].Value = companyName;
                                    row.Cells[colJobTitle.Index].Value = jobTitle;
                                    row.Cells[colStatus.Index].Value = status;
                                    row.Cells[colWorkMode.Index].Value = workMode;
                                    row.Cells[colJobType.Index].Value = jobType;
                                    row.Cells[colPostDate.Index].Value = postDate;
                                    row.Cells[colDeadline.Index].Value = deadline;

                                    row.Tag = vacancyId;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vacancy data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridPostedJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridPostedJobs.Columns[e.ColumnIndex].Name == "colApplicants")
            {
                int vacancyId = Convert.ToInt32(dataGridPostedJobs.Rows[e.RowIndex].Tag);
                var applicantsForm = new ListOfApplicantsForm(vacancyId);
                applicantsForm.ShowDialog();
            }
        }
    }
}
