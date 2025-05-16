using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IJobSeekerRepository : IRepository<JobSeeker>
    {
        Task<JobSeeker> GetByUserIdAsync(int userId);
        Task<IQueryable<JobSeeker>> GetBySkillsAsync(string skills);
        Task<IQueryable<JobSeeker>> GetByPreferredLocationAsync(string location);
        Task<IQueryable<JobSeeker>> GetByInterestsAsync(string interests);
        Task<IQueryable<JobApplication>> GetApplicationsForJobSeekerAsync(int jobSeekerId);
        Task<IQueryable<SavedJob>> GetSavedJobsForJobSeekerAsync(int jobSeekerId);
        Task UpdateResumeAsync(int jobSeekerId, byte[] resume);
    }
}
