using DAL.Interfaces;
using DAL.Repositories;
using Models;
using RecruitmentApplication.Controllers;
using RecruitmentApplication.Core.Navigation;
using RecruitmentApplication.Views.Auth;
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
        private readonly INavigation navigation;
        private readonly RecruitmentContext context;

        public MainForm()
        {
            try
            {
                InitializeComponent();

                if (Session.CurrentUser == null)
                {
                    MessageBox.Show("No user is logged in. Please login first.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context = new RecruitmentContext();

                navigation = new Navigation(centralPanel);

                RegisterViews();

                navigation.NavigateTo<JobsControl>();

                this.FormClosing += MainForm_FormClosing;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing MainForm: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        public void RegisterViews()
        {
            navigation.RegisterView<JobsControl, JobsController>(
                () => new JobsController(new VacancyRepository(context)));

            navigation.RegisterView<SavedJobsControl, SavedJobsController>(
                () => new SavedJobsController(new SavedJobRepository(context)));
        }

        private void navJobsBtn_Click(object sender, EventArgs e)
        {
            navigation.NavigateTo<JobsControl>();
        }

        private void navSavedJobsBtn_Click(object sender, EventArgs e)
        {
            navigation.NavigateTo<SavedJobsControl>();
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
    }
}