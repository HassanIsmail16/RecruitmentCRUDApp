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
    public class JobSeekerRepository : Repository<JobSeeker>, IJobSeekerRepository
    {
        public JobSeekerRepository(RecruitmentContext context) : base(context, "used_id")
        {
        }

        public async Task<JobSeeker> GetByUserIdAsync(int userId)
        {
            return await context.JobSeekers.FromSqlInterpolated($"SELECT * FROM [ JobSeeker ] WHERE user_id = {userId}").FirstOrDefaultAsync();
        }

        // TODO: consider removing this if it's useless
        public async Task<List<JobSeeker>> GetBySkillsAsync(string skills)
        {
            return await context.JobSeekers.FromSqlInterpolated($"SELECT * FROM [ JobSeeker ] WHERE skills LIKE {skills}").ToListAsync();
        }

        public async Task<List<JobSeeker>> GetByPreferredLocationAsync(string location)
        {
            return await context.JobSeekers.FromSqlInterpolated($"SELECT * FROM [ JobSeeker ] WHERE preferred_loc LIKE {location}").ToListAsync();
        }

        public async Task<List<JobSeeker>> GetByInterestsAsync(string interests)
        {
            return await context.JobSeekers.FromSqlInterpolated($"SELECT * FROM [ JobSeeker ] WHERE interests LIKE {interests}").ToListAsync();
        }

        public async Task<List<JobApplication>> GetApplicationsForJobSeekerAsync(int jobSeekerId)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE jobseeker_id = {jobSeekerId}").ToListAsync();
        }

        public async Task<List<SavedJob>> GetSavedJobsForJobSeekerAsync(int jobSeekerId)
        {
            return await context.SavedJobs.FromSqlInterpolated($"SELECT * FROM [ SavedJob ] WHERE jobseeker_id = {jobSeekerId}").ToListAsync();
        }

        public async Task UpdateResumeAsync(int jobSeekerId, byte[] resume)
        {
            var jobSeeker = await GetByIdAsync(jobSeekerId);
            if (jobSeeker != null)
            {
                jobSeeker.Resume = resume;
                await UpdateAsync(jobSeeker);
            }

        }
    }
}