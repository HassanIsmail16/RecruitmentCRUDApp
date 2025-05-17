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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void JobSeekerProfileControl_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserId.HasValue)
            {
                int id = Session.CurrentUserId.Value;
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT name, email, phone, birth_date, signup_date FROM [User] WHERE user_id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["name"]?.ToString() ?? "";
                            txtEmail.Text = reader["email"]?.ToString() ?? "";
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
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            birthDatePicker.Value = DateTime.Now;
            textBox4.Text = "";
        }
    }
}
