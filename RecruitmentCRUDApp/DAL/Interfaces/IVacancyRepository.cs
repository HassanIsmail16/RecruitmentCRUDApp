using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IVacancyRepository
    {
        Task<IQueryable<Vacancy>> GetByCompanyIdAsync(int companyId);
        Task<IQueryable<Vacancy>> GetByEmployerIdAsync(int employerId);
        Task<IQueryable<Vacancy>> GetByStatusAsync(string status);
        Task<IQueryable<Vacancy>> GetByExperienceLevelAsync(string experienceLevel);
        Task<IQueryable<Vacancy>> GetByWorkModeAsync(string workMode);
        Task<IQueryable<Vacancy>> GetByJobTypeAsync(string jobType);
        Task<IQueryable<Vacancy>> GetByDeadlineRangeAsync(DateTime startDate, DateTime endDate);
        Task<IQueryable<Vacancy>> GetBySkillsRequiredAsync(string skills);
        Task<IQueryable<JobApplication>> GetApplicationsForVacancyAsync(int vacancyId);
        Task<IQueryable<SavedJob>> GetSavedJobsForVacancyAsync(int vacancyId);
        Task UpdateStatusAsync(int vacancyId, string status);
    }
}
