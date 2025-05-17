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

namespace RecruitmentApplication.Views
{
    public partial class ListOfApplicantsForm : Form
    {
        public ListOfApplicantsForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // query to get application data with applicant name and job post date
                    string query = @"SELECT 
                                ja.app_id,
                                u.name AS ApplicantName, 
                                ja.app_date AS ApplicationDate, 
                                ja.status AS Status,
                                v.post_date AS PostDate
                            FROM 
                                JobApplication ja
                                INNER JOIN JobSeeker js ON ja.jobseeker_id = js.user_id
                                INNER JOIN [User] u ON js.user_id = u.user_id
                                INNER JOIN Vacancy v ON ja.vacancy_id = v.vacancy_id
                            WHERE 
                                ja.employer_id = @employerId
                            ORDER BY 
                                ja.app_date DESC";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // add the current employer's ID as a parameter
                        cmd.Parameters.AddWithValue("@employerId", Session.CurrentUserId);

                        // clear data grid rows
                        dataGridJobApplicants.Rows.Clear();

                        // execute the reader
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // check if we have any rows
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // get data from the reader
                                    int appId = reader.GetInt32(reader.GetOrdinal("app_id"));
                                    string applicantName = reader.GetString(reader.GetOrdinal("ApplicantName"));
                                    DateTime appDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                                    string status = reader.GetString(reader.GetOrdinal("Status"));
                                    DateTime postDate = reader.GetDateTime(reader.GetOrdinal("PostDate"));

                                    // add a new row
                                    int rowIndex = dataGridJobApplicants.Rows.Add();
                                    DataGridViewRow row = dataGridJobApplicants.Rows[rowIndex];

                                    // set values to each cell
                                    row.Cells[colApplicantName.Index].Value = applicantName;
                                    row.Cells[colAppDate.Index].Value = appDate;
                                    row.Cells[colStatus.Index].Value = status;
                                    row.Cells[colPostDate.Index].Value = postDate;

                                    row.Tag = appId;
                                }
                            }
                        }

                        dataGridJobApplicants.AutoResizeColumns();
                    }

                    btnSaveChanges.Enabled = dataGridJobApplicants.Rows.Count > 0;
                    btnCancel.Enabled = dataGridJobApplicants.Rows.Count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading application data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;";
            int updatedCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // loop on each row
                            foreach (DataGridViewRow row in dataGridJobApplicants.Rows)
                            {
                                // skip rows without tag (app_id)
                                if (row.Tag == null)
                                    continue;

                                // get the current status value from the combo box cell
                                string status = row.Cells[colStatus.Index].Value?.ToString();

                                if (string.IsNullOrEmpty(status))
                                    continue;

                                // get app id from the tag
                                int appId = Convert.ToInt32(row.Tag);

                                // update query
                                string updateQuery = "UPDATE JobApplication SET status = @status WHERE app_id = @appId";

                                using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                                {
                                    // set parameter values for this row
                                    cmd.Parameters.AddWithValue("@status", status);
                                    cmd.Parameters.AddWithValue("@appId", appId);

                                    // execute update and count affected rows
                                    int rowsAffected = cmd.ExecuteNonQuery();
                                    updatedCount += rowsAffected;
                                }
                            }

                            // commit the transaction
                            transaction.Commit();

                            if (updatedCount > 0)
                            {
                                MessageBox.Show($"Successfully updated {updatedCount} application statuses.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // refresh the grid
                                btnRefresh_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("No changes were made.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            // roll back the transaction if something went wrong
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating application statuses: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
