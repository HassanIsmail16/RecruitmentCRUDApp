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
            return await context.JobSeekers.FirstOrDefaultAsync(js => js.UserId == userId);
        }

        // TODO: consider removing this if it's useless
        public async Task<List<JobSeeker>> GetBySkillsAsync(string skills)
        {
            return await Task.Run(() =>
            context.JobSeekers
            .Where(js => js.Skills.ToLower().Contains(skills.ToLower()))
            .AsQueryable());
        }

        public async Task<List<JobSeeker>> GetByPreferredLocationAsync(string location)
        {
            return await Task.Run(() =>
            context.JobSeekers
            .Where(js => js.PreferredLoc.ToLower() == location.ToLower())
            .AsQueryable());
        }

        public async Task<List<JobSeeker>> GetByInterestsAsync(string interests)
        {
            return await Task.Run(() =>
            context.JobSeekers
            .Where(js => js.Interests.ToLower().Contains(interests.ToLower()))
            .AsQueryable());
        }

        public async Task<List<JobApplication>> GetApplicationsForJobSeekerAsync(int jobSeekerId)
        {
            return await Task.Run(() =>
            context.JobApplications
            .Where(ja => ja.JobseekerId == jobSeekerId)
            .AsQueryable());
        }

        public async Task<List<SavedJob>> GetSavedJobsForJobSeekerAsync(int jobSeekerId)
        {
            return await Task.Run(() =>
            context.SavedJobs
            .Where(sj => sj.JobseekerId == jobSeekerId)
            .AsQueryable());
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