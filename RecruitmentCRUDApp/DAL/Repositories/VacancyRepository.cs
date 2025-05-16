using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class VacancyRepository : Repository<Vacancy>, IVacancyRepository
    {
        public VacancyRepository(RecruitmentContext context) : base(context, "vacancy_id")
        {
        }

        public async Task<List<Vacancy>> GetByCompanyIdAsync(int companyId)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE company_id = {companyId}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetByEmployerIdAsync(int employerId)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE employer_id = {employerId}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetByStatusAsync(string status)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE status = {status}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetByExperienceLevelAsync(string experienceLevel)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE experience_level = {experienceLevel}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetByWorkModeAsync(string workMode)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE work_mode = {workMode}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetByJobTypeAsync(string jobType)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE job_type = {jobType}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetByDeadlineRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE deadline BETWEEN {startDate} AND {endDate}").ToListAsync();
        }

        // TODO: consider removing this if it's useless
        public async Task<List<Vacancy>> GetBySkillsRequiredAsync(string skills)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE skills LIKE {skills}").ToListAsync();
        }

        public async Task<List<JobApplication>> GetApplicationsForVacancyAsync(int vacancyId)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE vacancy_id = {vacancyId}").ToListAsync();
        }

        public async Task<List<SavedJob>> GetSavedJobsForVacancyAsync(int vacancyId)
        {
            return await context.SavedJobs.FromSqlInterpolated($"SELECT * FROM [ SavedJob ] WHERE vacancy_id = {vacancyId}").ToListAsync();
        }

        public async Task UpdateStatusAsync(int vacancyId, string status)
        {
            var vacancy = await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE vacancy_id = {vacancyId}").FirstOrDefaultAsync();
            if (vacancy != null)
            {
                vacancy.Status = status;
                await context.Database.ExecuteSqlInterpolatedAsync($"UPDATE [ Vacancy ] SET status = {status} WHERE vacancy_id = {vacancyId}");
            }
        }
    }
}
