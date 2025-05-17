using DAL.Interfaces;
using DAL.Repositories;
using Models;
using RecruitmentApplication.Controllers;
using RecruitmentApplication.Core.Navigation;
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
        private INavigation navigation;
        private RecruitmentContext context;
        public MainForm()
        {
            InitializeComponent();
            navigation = new Navigation(centralPanel);

            context = new RecruitmentContext();

            RegisterViews();

            navigation.NavigateTo<JobsControl>();
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

        }
    }
}
