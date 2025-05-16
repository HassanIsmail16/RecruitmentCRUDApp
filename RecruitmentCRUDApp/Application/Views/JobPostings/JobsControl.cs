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
    public partial class JobsControl : UserControl
    {
        public event Action OnRequestRefresh;
        public JobsControl()
        {
            InitializeComponent();
        }

        public void RenderVacancies(List<Vacancy> vacancies)
        {
            vacanciesPanel.Controls.Clear();
            foreach (var vacancy in vacancies)
            {
                var card = new JobCardControl(vacancy);
                vacanciesPanel.Controls.Add(card);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            OnRequestRefresh?.Invoke();
        }
    }
}
