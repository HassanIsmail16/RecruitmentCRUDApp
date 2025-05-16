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
        public VacancyRepository(RecruitmentContext context) : base(context)
        {
        }

        public async Task<IQueryable<Vacancy>> GetByCompanyIdAsync(int companyId)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.CompanyId == companyId)
            .AsQueryable());
        }

        public async Task<IQueryable<Vacancy>> GetByEmployerIdAsync(int employerId)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.EmployerId == employerId)
            .AsQueryable());
        }

        public async Task<IQueryable<Vacancy>> GetByStatusAsync(string status)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.Status.ToLower() == status.ToLower())
            .AsQueryable());
        }

        public async Task<IQueryable<Vacancy>> GetByExperienceLevelAsync(string experienceLevel)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.ExperienceLevel.ToLower() == experienceLevel.ToLower())
            .AsQueryable());
        }

        public async Task<IQueryable<Vacancy>> GetByWorkModeAsync(string workMode)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.WorkMode.ToLower() == workMode.ToLower())
            .AsQueryable());
        }

        public async Task<IQueryable<Vacancy>> GetByJobTypeAsync(string jobType)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.JobType.ToLower() == jobType.ToLower())
            .AsQueryable());
        }

        public async Task<IQueryable<Vacancy>> GetByDeadlineRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.Deadline >= startDate && v.Deadline <= endDate)
            .AsQueryable());
        }

        // TODO: consider removing this if it's useless
        public async Task<IQueryable<Vacancy>> GetBySkillsRequiredAsync(string skills)
        {
            return await Task.Run(() => 
            context.Vacancies
            .Where(v => v.Skills.ToLower().Contains(skills.ToLower()))
            .AsQueryable());
        }

        public async Task<IQueryable<JobApplication>> GetApplicationsForVacancyAsync(int vacancyId)
        {
            return await Task.Run(() => 
            context.JobApplications
            .Where(ja => ja.VacancyId == vacancyId)
            .AsQueryable());
        }

        public async Task<IQueryable<SavedJob>> GetSavedJobsForVacancyAsync(int vacancyId)
        {
            return await Task.Run(() => 
            context.SavedJobs
            .Where(sj => sj.VacancyId == vacancyId)
            .AsQueryable());
        }

        public async Task UpdateStatusAsync(int vacancyId, string status)
        {
            var vacancy = await context.Vacancies.FindAsync(vacancyId);
            if (vacancy != null)
            {
                vacancy.Status = status;
                await context.SaveChangesAsync();
            }
        }
    }
}
