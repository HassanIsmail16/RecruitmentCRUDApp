using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IVacancyRepository : IRepository<Vacancy>
    {
        Task<List<Vacancy>> GetByCompanyIdAsync(int companyId);
        Task<List<Vacancy>> GetByEmployerIdAsync(int employerId);
        Task<List<Vacancy>> GetByStatusAsync(string status);
        Task<List<Vacancy>> GetByExperienceLevelAsync(string experienceLevel);
        Task<List<Vacancy>> GetByWorkModeAsync(string workMode);
        Task<List<Vacancy>> GetByJobTypeAsync(string jobType);
        Task<List<Vacancy>> GetByDeadlineRangeAsync(DateTime startDate, DateTime endDate);
        Task<List<Vacancy>> GetBySkillsRequiredAsync(string skills);
        Task<List<JobApplication>> GetApplicationsForVacancyAsync(int vacancyId);
        Task<List<SavedJob>> GetSavedJobsForVacancyAsync(int vacancyId);
        Task UpdateStatusAsync(int vacancyId, string status);
    }
}
