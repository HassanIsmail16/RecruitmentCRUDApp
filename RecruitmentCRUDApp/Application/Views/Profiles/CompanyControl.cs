using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecruitmentApplication.Views.Profiles
{
    public partial class CompanyControl : UserControl
    {
        public CompanyControl()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int userChanges = SaveUserChanges(connection);
                if (userChanges > 0)
                {
                    MessageBox.Show("Saved changes successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (userChanges <= 0)
                {
                    MessageBox.Show("Couldn't user information skills changes.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int SaveUserChanges(SqlConnection connection)
        {
            string fullname = txtName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string descryption = textBoxDescryption.Text;

            string saveUserChangesQuery =
                "UPDATE [User] " +
                "SET name = @name, email = @email,phone = @phoneNumber, descryption = @descryption " +
                "WHERE user_id = @userId;";
            SqlCommand saveUserChangesCmd = new SqlCommand(saveUserChangesQuery, connection);
            saveUserChangesCmd.Parameters.AddWithValue("@name", fullname);
            saveUserChangesCmd.Parameters.AddWithValue("@email", email);
            saveUserChangesCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            saveUserChangesCmd.Parameters.AddWithValue("@descryption", descryption);
            saveUserChangesCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

            return saveUserChangesCmd.ExecuteNonQuery();
        }

        private void CompanyControl_Load(object sender, EventArgs e)
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
                            txtName.Text = reader["name"]?.ToString() ?? "";
                            txtEmail.Text = reader["email"]?.ToString() ?? "";
                            txtPhoneNumber.Text = reader["phone"]?.ToString() ?? "";
                            textBoxDescryption.Text = reader["description"]?.ToString() ?? "";
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
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            textBoxDescryption.Text = "";
        }
        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
