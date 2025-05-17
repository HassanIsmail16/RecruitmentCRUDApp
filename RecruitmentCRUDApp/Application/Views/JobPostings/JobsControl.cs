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
    public partial class JobsControl : UserControl
    {
        public JobsControl()
        {
            InitializeComponent();
            InitializeGrid();
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

        private void RefreshDataGridView()
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getJobDataQuery = "SELECT * FROM [Vacancy]";
                SqlCommand getJobDataCmd = new SqlCommand(getJobDataQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(getJobDataCmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridPostings.DataSource = table;
            }
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
        }

        private void SaveJob(int jobId)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
    }
}
