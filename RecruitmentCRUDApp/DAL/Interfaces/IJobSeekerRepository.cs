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
        Task<List<JobSeeker>> GetBySkillsAsync(string skills);
        Task<List<JobSeeker>> GetByPreferredLocationAsync(string location);
        Task<List<JobSeeker>> GetByInterestsAsync(string interests);
        Task<List<JobApplication>> GetApplicationsForJobSeekerAsync(int jobSeekerId);
        Task<List<SavedJob>> GetSavedJobsForJobSeekerAsync(int jobSeekerId);
        Task UpdateResumeAsync(int jobSeekerId, byte[] resume);
    }
}
