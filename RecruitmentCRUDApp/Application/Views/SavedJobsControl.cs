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
    public partial class SavedJobsControl : UserControl
    {
        public SavedJobsControl()
        {
            InitializeComponent();
            LoadSavedJobs();
        }

        private void LoadSavedJobs()
        {
            if (Session.CurrentUserId.HasValue)
            {
                int userId = Session.CurrentUserId.Value;

                using (var conn = new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
                using (var cmd = new System.Data.SqlClient.SqlCommand(
                    @"SELECT  
                        s.saved_job_id, 
                        c.name,
                        v.title, 
                        v.deadline, 
                        s.save_date
                      FROM SavedJob s
                      JOIN Vacancy v ON s.vacancy_id = v.vacancy_id
                      JOIN Company c ON v.company_id = c.company_id
                      WHERE s.jobseeker_id = @userId", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    conn.Open();

                    DataTable dt = new DataTable();
                    using (var adapter = new System.Data.SqlClient.SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridSavedJobs.DataSource = dt;
                }
            }
        }

        private void dataGridSavedJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
