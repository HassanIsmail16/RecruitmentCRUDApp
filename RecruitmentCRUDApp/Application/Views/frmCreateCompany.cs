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
    public partial class frmCreateCompany : Form
    {
        public frmCreateCompany()
        {
            InitializeComponent();
        }

        private void brnCreate_Click(object sender, EventArgs e)
        {
            // get values from form fields
            string companyName = txtCompanyName.Text;
            string email = textEmail.Text;
            string phone = textPhone.Text;
            string description = textDescription.Text;

            // validate inputs
            if (string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Company name and email are required fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // sql command for inserting company
                    string insertCompanyQuery =
                        "INSERT INTO [Company] " +
                        "(name, email, phone, description, manager_id) " +
                        "VALUES (@name, @email, @phone, @description, @managerId);";

                    SqlCommand insertCompanyCmd = new SqlCommand(insertCompanyQuery, connection);
                    insertCompanyCmd.Parameters.AddWithValue("@name", companyName);
                    insertCompanyCmd.Parameters.AddWithValue("@email", email);
                    insertCompanyCmd.Parameters.AddWithValue("@phone", phone ?? (object)DBNull.Value);
                    insertCompanyCmd.Parameters.AddWithValue("@description", description ?? (object)DBNull.Value);
                    insertCompanyCmd.Parameters.AddWithValue("@managerId", Session.CurrentUserId);

                    var result = insertCompanyCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show($"Company '{companyName}' created successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create company.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
