using RecruitmentApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Diagnostics;
using DAL.Interfaces;

namespace RecruitmentApplication.Controllers
{
    internal class JobsController
    {
        private JobsControl view;
        private readonly IVacancyRepository vacancyRepository;

        public JobsController(IVacancyRepository vacancyRepository)
        {
            this.vacancyRepository = vacancyRepository;
        }

        public void BindView(JobsControl view)
        {
            this.view = view;
            this.view.OnRequestRefresh += LoadVacancies;
            LoadVacancies();
        }

        public async void LoadVacancies()
        {
            var vacancies = await vacancyRepository.GetAllAsync();
            view.RenderVacancies(vacancies.ToList());
        }
    }
}
