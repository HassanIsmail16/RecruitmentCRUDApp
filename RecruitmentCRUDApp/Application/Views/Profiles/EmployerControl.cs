using Microsoft.VisualBasic.ApplicationServices;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RecruitmentApplication.Views.Profiles
{
    public partial class EmployerControl : UserControl
    {
        public EmployerControl()
        {
            InitializeComponent();
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int userChanges = SaveUserChanges(connection);
                    int companyChanges = SaveCompanySelection(connection);

                    if (userChanges > 0 && companyChanges > 0)
                    {
                        MessageBox.Show("Saved changes successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (companyChanges <= 0)
                    {
                        MessageBox.Show("Couldn't save company selection changes.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (userChanges <= 0)
                    {
                        MessageBox.Show("Couldn't save user information changes.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int SaveUserChanges(SqlConnection connection)
        {
            string fullname = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime? birthDate = birthDatePicker.Value;

            string saveUserChangesQuery =
                "UPDATE [User] " +
                "SET name = @name, email = @email, password = @password, phone = @phoneNumber, birth_date = @birthDate " +
                "WHERE user_id = @userId;";

            SqlCommand saveUserChangesCmd = new SqlCommand(saveUserChangesQuery, connection);
            saveUserChangesCmd.Parameters.AddWithValue("@name", fullname);
            saveUserChangesCmd.Parameters.AddWithValue("@email", email);
            saveUserChangesCmd.Parameters.AddWithValue("@password", password);
            saveUserChangesCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            saveUserChangesCmd.Parameters.AddWithValue("@birthDate", birthDate);
            saveUserChangesCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

            return saveUserChangesCmd.ExecuteNonQuery();
        }

        private int SaveCompanySelection(SqlConnection connection)
        {
            // Get the selected company from combo box
            if (comboBoxCompany.SelectedItem == null)
            {
                MessageBox.Show("Please select a company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            string selectedCompany = comboBoxCompany.SelectedItem.ToString();

            int companyId = 0;
            string getCompanyIdQuery = "SELECT company_id FROM Company WHERE company_name = @companyName";
            using (SqlCommand companyIdCmd = new SqlCommand(getCompanyIdQuery, connection))
            {
                companyIdCmd.Parameters.AddWithValue("@companyName", selectedCompany);
                var result = companyIdCmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    companyId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Selected company not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }

            string saveCompanyQuery =
                "UPDATE [User] " +
                "SET company_id = @companyId " +
                "WHERE user_id = @userId;";

            SqlCommand saveCompanyCmd = new SqlCommand(saveCompanyQuery, connection);
            saveCompanyCmd.Parameters.AddWithValue("@companyId", companyId);
            saveCompanyCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

            return saveCompanyCmd.ExecuteNonQuery();
        }

        private void EmployerProfileControl_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserId.HasValue)
            {
                int id = Session.CurrentUserId.Value;
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT name, email, phone, password, birth_date, signup_date FROM [User] WHERE user_id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelUserName.Text = reader["name"]?.ToString() ?? "";
                            txtFullName.Text = reader["name"]?.ToString() ?? "";
                            txtEmail.Text = reader["email"]?.ToString() ?? "";
                            txtPassword.Text = reader["password"]?.ToString() ?? "";
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
            labelUserName.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            birthDatePicker.Value = DateTime.Now;
            textBox4.Text = "";
        }


        private void EmployerControl_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCompany_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name FROM Company";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Loop through the results
                        while (reader.Read())
                        {
                            comboBoxCompany.Items.Add(reader["name"].ToString());
                        }
                    }
                }

                if (comboBoxCompany.Items.Count > 0)
                {
                    comboBoxCompany.SelectedIndex = 0;
                }

                comboBoxCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateCompany_Click(object sender, EventArgs e)
        {
            Form createCompanyForm = new frmCreateCompany();


            createCompanyForm.ShowDialog();
        }

        private void btnSaveChangesCompany_Click(object sender, EventArgs e)
        {

        }
    }
}