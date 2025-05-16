using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class JobSeekerRepository : Repository<JobSeeker>, IJobSeekerRepository
    {
        public Task<JobSeeker> AddAsync(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobApplication>> GetApplicationsForJobSeekerAsync(int jobSeekerId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobSeeker>> GetByInterestsAsync(string interests)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobSeeker>> GetByPreferredLocationAsync(string location)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobSeeker>> GetBySkillsAsync(string skills)
        {
            throw new NotImplementedException();
        }

        public Task<JobSeeker> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<SavedJob>> GetSavedJobsForJobSeekerAsync(int jobSeekerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateResumeAsync(int jobSeekerId, byte[] resume)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<JobSeeker>> IRepository<JobSeeker>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<JobSeeker> IRepository<JobSeeker>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
