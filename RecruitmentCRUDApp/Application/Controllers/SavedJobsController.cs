using DAL.Interfaces;
using DAL.Repositories;
using RecruitmentApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApplication.Controllers
{
    internal class SavedJobsController
    {
        private SavedJobsControl view;
        private ISavedJobRepository savedJobsRepo;

        public SavedJobsController(ISavedJobRepository savedJobsRepo)
        {
            this.savedJobsRepo = savedJobsRepo;
        }

        public void BindView(SavedJobsControl view)
        {
            this.view = view;
        }


    }
}
