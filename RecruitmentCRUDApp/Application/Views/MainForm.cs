using DAL.Interfaces;
using DAL.Repositories;
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
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
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