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

        public void LoadVacancies()
        {
            var vacancies = new List<Vacancy>
            {
                new Vacancy(),
                new Vacancy(),
                new Vacancy(),
                new Vacancy(),
                new Vacancy(),
                new Vacancy(),
                new Vacancy()
            }; // TODO: fetch real data from repository
            view.RenderVacancies(vacancies);
        }
    }
}
