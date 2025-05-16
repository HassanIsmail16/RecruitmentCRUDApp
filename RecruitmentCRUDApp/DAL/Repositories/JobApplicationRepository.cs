using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class JobApplicationRepository : Repository<JobApplication>, IJobApplicationRepository
    {
        public JobApplicationRepository(RecruitmentContext context) : base(context, "app_id")
        {
        }

        public async Task<List<JobApplication>> GetByJobSeekerIdAsync(int jobSeekerId)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE jobseeker_id = {jobSeekerId}").ToListAsync():
        }

        public async Task<List<JobApplication>> GetByEmployerIdAsync(int employerId)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE employer_id = {employerId}").ToListAsync();
        }

        public async Task<List<JobApplication>> GetByVacancyIdAsync(int vacancyId)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE vacancy_id = {vacancyId}").ToListAsync();
        }

        public async Task<List<JobApplication>> GetByStatusAsync(string status)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE status = {status}").ToListAsync();
        }

        public async Task<List<JobApplication>> GetApplicationsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM JobApplication WHERE app_date BETWEEN {startDate} AND {endDate}").ToListAsync();
        }

        public async Task UpdateApplicationStatusAsync(int appId, string status)
        {
            await context.Database.ExecuteSqlRawAsync("UPDATE JobApplication SET status = {0} WHERE app_id = {1}", status, appId);
        }
    }
}
