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
    public partial class PostJobForm : Form
    {
        public PostJobForm()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string title = tboxTitle.Text;
            string status = cmboxStatus.Text;
            string expLevel = cmboxExpLevel.Text;
            string workMode = cmboxWorkMode.Text;
            string jobType = cmboxJobType.Text;
            DateTime? deadline = dateDeadline.Value;
            string skills = tboxSkills.Text;
            string description = tboxDescription.Text;

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getCompanyIdQuery = "SELECT company_id FROM [Employer] WHERE user_id = @user_id";
                SqlCommand getCompanyIdCmd = new SqlCommand(getCompanyIdQuery, connection);
                SqlDataReader reader = getCompanyIdCmd.ExecuteReader();
                int companyId;
                if (reader.Read())
                {
                    companyId = reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show($"Failed to post job {title}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string insertVacancyQuery =
                    "INSERT INTO [Vacancy] " +
                    "(title, description, skills, status, experience_level, work_mode, job_type, deadline, company_id, employer_id) " +
                    "VALUES (@title, @description, @skills, @status, @expLevel, @workMode, @jobType, @deadline, @companyId, @employerId);";
                SqlCommand insertVacancyCmd = new SqlCommand(insertVacancyQuery, connection);
                insertVacancyCmd.Parameters.AddWithValue("@title", title);
                insertVacancyCmd.Parameters.AddWithValue("@description", description);
                insertVacancyCmd.Parameters.AddWithValue("@skills", skills);
                insertVacancyCmd.Parameters.AddWithValue("@status", status);
                insertVacancyCmd.Parameters.AddWithValue("@expLevel", expLevel);
                insertVacancyCmd.Parameters.AddWithValue("@workMode", workMode);
                insertVacancyCmd.Parameters.AddWithValue("@jobType", jobType);
                insertVacancyCmd.Parameters.AddWithValue("@deadline", deadline);
                insertVacancyCmd.Parameters.AddWithValue("@companyId", companyId);
                insertVacancyCmd.Parameters.AddWithValue("@employerId", Session.CurrentUserId);

                var result = insertVacancyCmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show($"Vacancy {title} posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Failed to post job {title}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostJobForm_Load(object sender, EventArgs e)
        {
            cmboxStatus.Items.Add("Open");
            cmboxStatus.Items.Add("Closed");
            cmboxStatus.Items.Add("Hidden");
            cmboxStatus.SelectedIndex = 0;
            cmboxStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            cmboxExpLevel.Items.Add("Student");
            cmboxExpLevel.Items.Add("Fresh Graduate");
            cmboxExpLevel.Items.Add("Junior");
            cmboxExpLevel.Items.Add("Mid-Leve");
            cmboxExpLevel.Items.Add("Senior");
            cmboxExpLevel.SelectedIndex = 0;
            cmboxExpLevel.DropDownStyle = ComboBoxStyle.DropDownList;

            cmboxWorkMode.Items.Add("On-Site");
            cmboxWorkMode.Items.Add("Remote");
            cmboxWorkMode.Items.Add("Hybrid");
            cmboxWorkMode.SelectedIndex = 0;
            cmboxWorkMode.DropDownStyle = ComboBoxStyle.DropDownList;

            cmboxJobType.Items.Add("Full-Time");
            cmboxJobType.Items.Add("Part-Time");
            cmboxJobType.Items.Add("Internship");
            cmboxJobType.SelectedIndex = 0;
            cmboxJobType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
