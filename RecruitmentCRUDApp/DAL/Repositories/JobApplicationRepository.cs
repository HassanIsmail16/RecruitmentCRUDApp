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

        public Task<IQueryable<JobApplication>> GetApplicationsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobApplication>> GetByEmployerIdAsync(int employerId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobApplication>> GetByJobSeekerIdAsync(int jobSeekerId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobApplication>> GetByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobApplication>> GetByVacancyIdAsync(int vacancyId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateApplicationStatusAsync(int appId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
