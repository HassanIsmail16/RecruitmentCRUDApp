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
        public MainForm()
        {
            InitializeComponent();
            navigation = new Navigation(centralPanel);

            navigation.RegisterView<JobsControl, JobsController>(
                () => new JobsController(new VacancyRepository()));

            navigation.NavigateTo<JobsControl>();
        }

        private void navJobsBtn_Click(object sender, EventArgs e)
        {
            navigation.NavigateTo<JobsControl>();
        }
    }
}
