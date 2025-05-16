using DAL.Interfaces;
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
        public JobApplicationRepository(RecruitmentContext context) : base(context)
        {
        }

        public async Task<IQueryable<JobApplication>> GetByJobSeekerIdAsync(int jobSeekerId)
        {
            return await Task.Run(() => 
            context.JobApplications
            .Where(ja => ja.JobseekerId == jobSeekerId)
            .AsQueryable());
        }

        public async Task<IQueryable<JobApplication>> GetByEmployerIdAsync(int employerId)
        {
            return await Task.Run(() =>
            context.JobApplications
            .Where(ja => ja.EmployerId == employerId)
            .AsQueryable());
        }

        public async Task<IQueryable<JobApplication>> GetByVacancyIdAsync(int vacancyId)
        {
            return await Task.Run(() =>
            context.JobApplications
            .Where(ja => ja.VacancyId == vacancyId)
            .AsQueryable());
        }

        public async Task<IQueryable<JobApplication>> GetByStatusAsync(string status)
        {
            return await Task.Run(() => 
            context.JobApplications
            .Where(ja => ja.Status == status)
            .AsQueryable());
        }

        public async Task<IQueryable<JobApplication>> GetApplicationsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(() => 
            context.JobApplications
            .Where(ja => ja.AppDate >= startDate && ja.AppDate <= endDate)
            .AsQueryable());
        }

        public async Task UpdateApplicationStatusAsync(int appId, string status)
        {
            var application = await context.JobApplications.FindAsync(appId);
            if (application != null)
            {
                application.Status = status;
                await UpdateAsync(application);
            }
        }
    }
}
