using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class VacancyRepository : Repository<Vacancy>, IVacancyRepository
    {
        public Task<IQueryable<JobApplication>> GetApplicationsForVacancyAsync(int vacancyId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetByCompanyIdAsync(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetByDeadlineRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetByEmployerIdAsync(int employerId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetByExperienceLevelAsync(string experienceLevel)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetByJobTypeAsync(string jobType)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetBySkillsRequiredAsync(string skills)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetByWorkModeAsync(string workMode)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<SavedJob>> GetSavedJobsForVacancyAsync(int vacancyId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStatusAsync(int vacancyId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
