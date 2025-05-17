using Microsoft.Data.SqlClient;
using Models;
using RecruitmentApplication.Views.Auth;
using RecruitmentApplication.Views.Profiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.FormClosing += MainForm_FormClosing;

            ConfigureNavigation();
        }

        private void ConfigureNavigation()
        {
            // First configure the ToolStrip itself
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.AutoSize = false; // This is crucial!
            toolStrip1.Size = new Size(175, 400); // Set fixed size for the entire ToolStrip

            // Set image and text appearance
            toolStrip1.ImageScalingSize = new Size(32, 32); // Standard icon size
            toolStrip1.ShowItemToolTips = false; // Optional: disable tooltips

            // Create buttons with consistent sizing
            //var profileButton = CreateNavButton("Profile", null,
            //    () => ShowControl(Session.UserType == "JobSeeker" ?
            //        new JobSeekerProfileControl() :
            //        new EmployerProfileControl()));

            var profileButton = CreateNavButton("Profile", null, () => ShowControl(new JobSeekerProfileControl()));

            toolStrip1.Items.Add(profileButton);

            if (Session.UserType == "JobSeeker")
            {
                toolStrip1.Items.Add(CreateNavButton("Job Postings", null,
                    () => ShowControl(new JobsControl())));

                toolStrip1.Items.Add(CreateNavButton("Saved Jobs", null,
                    () => ShowControl(new SavedJobsControl())));
            }
            else
            {
                toolStrip1.Items.Add(CreateNavButton("Posted Jobs", null,
                    () => ShowControl(new PostedJobsControl())));

                toolStrip1.Items.Add(CreateNavButton("Post a Job", null,
                    () =>
                    {
                        if (IsUserPartOfACompany())
                        {
                            ShowControl(new PostedJobsControl());
                        }
                        else
                        {
                            MessageBox.Show("You have to be part of a company to post a job!", "Cannot Post a Job", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
            }

            toolStrip1.Items.Add(new ToolStripSeparator()); 
            toolStrip1.Items.Add(CreateNavButton("Logout", null,
                Logout));
        }

        private bool IsUserPartOfACompany()
        {
            string connectionString = "Data Source=.;Initial Catalog=Recruitment;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getCompanyIdQuery = "SELECT company_id FROM [Employer] WHERE user_id = @userId";
                SqlCommand getCompanyIdCmd = new SqlCommand(getCompanyIdQuery, connection);
                getCompanyIdCmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                SqlDataReader reader = getCompanyIdCmd.ExecuteReader();
                if (reader.Read())
                {
                    bool hasCompany = !reader.IsDBNull(reader.GetOrdinal("company_id"));
                    if (hasCompany)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        private ToolStripButton CreateNavButton(string text, Image icon, Action onClick)
        {
            var button = new ToolStripButton
            {
                Text = text,
                Image = icon,
                TextImageRelation = TextImageRelation.ImageAboveText,
                AutoSize = false, 
                Size = new Size(170, 45), 
                Margin = new Padding(2, 5, 2, 5), 
                Padding = new Padding(5),
                TextAlign = ContentAlignment.MiddleCenter,
                ImageAlign = ContentAlignment.MiddleCenter 
            };

            button.Click += (s, e) => onClick();
            return button;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void ShowControl(UserControl control)
        {
            centralPanel.SuspendLayout();
            centralPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            centralPanel.Controls.Add(control);
            centralPanel.ResumeLayout();
        }

        private void navJobsBtn_Click(object sender, EventArgs e)
        {
            centralPanel.SuspendLayout();
            centralPanel.Controls.Clear();
            var jobsControl = new JobsControl();
            jobsControl.Dock = DockStyle.Fill;
            centralPanel.Controls.Add(jobsControl);
            centralPanel.ResumeLayout();
        }

        private void navSavedJobsBtn_Click(object sender, EventArgs e)
        {
            centralPanel.SuspendLayout();
            centralPanel.Controls.Clear();
            var savedJobsControl = new SavedJobsControl();
            savedJobsControl.Dock = DockStyle.Fill;
            centralPanel.Controls.Add(savedJobsControl);
            centralPanel.ResumeLayout();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.FormClosing -= Form_FormClosing;
                    form.Close();
                }
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void navLogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Logout();
            frmLogin loginForm = new frmLogin();
            this.Hide();
            loginForm.Show();
        }

        private void Logout()
        {
            Session.Logout();
            frmLogin loginForm = new frmLogin();
            this.Hide();
            loginForm.Show();
        }


        private void navProfileBtn_Click(object sender, EventArgs e)
        {
            centralPanel.SuspendLayout();
            centralPanel.Controls.Clear();
            var jobSeekerProfileControl = new JobSeekerProfileControl();
            jobSeekerProfileControl.Dock = DockStyle.Fill;
            centralPanel.Controls.Add(jobSeekerProfileControl);
            centralPanel.ResumeLayout();
        }
    }
}