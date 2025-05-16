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
    public class SavedJobRepository : Repository<SavedJob>, ISavedJobRepository
    {
        public SavedJobRepository(RecruitmentContext context) : base(context, "saved_job_id")
        {
        }

        public async Task<List<SavedJob>> GetByJobSeekerIdAsync(int jobSeekerId)
        {
            return await context.SavedJobs.FromSqlInterpolated($"SELECT * FROM [ SavedJob ] WHERE saved_job_id = {jobSeekerId}").ToListAsync();
        }

        public async Task<List<SavedJob>> GetByVacancyIdAsync(int vacancyId)
        {
            return await context.SavedJobs.FromSqlInterpolated($"SELECT * FROMM [ SavedJob ] WHERE vacancy_id = {vacancyId}").ToListAsync();
        }

        public async Task<List<SavedJob>> GetBySaveDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await context.SavedJobs.FromSqlInterpolated($"SELECT * FROM [ SavedJob ] WHERE save_date BETWEEN {startDate} AND {endDate}").ToListAsync();
        }

        public async Task<bool> IsSavedByJobSeekerAsync(int jobSeekerId, int vacancyId)
        {
            return await context.SavedJobs.FromSqlInterpolated($"SELECT * FROM [ JobSeeker ] WHERE jobseeker_id = {jobSeekerId} AND vacancy_id = {vacancyId}").FirstOrDefaultAsync() != null;
        }
    }
}
