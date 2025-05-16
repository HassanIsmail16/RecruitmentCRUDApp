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
        public SavedJobRepository(RecruitmentContext context) : base(context)
        {
        }

        public async Task<IQueryable<SavedJob>> GetByJobSeekerIdAsync(int jobSeekerId)
        {
            return await Task.Run(() => 
            context.SavedJobs
            .Where(sj => sj.JobseekerId == jobSeekerId)
            .AsQueryable());
        }

        public async Task<IQueryable<SavedJob>> GetByVacancyIdAsync(int vacancyId)
        {
            return await Task.Run(() => 
            context.SavedJobs
            .Where(sj => sj.VacancyId == vacancyId)
            .AsQueryable());
        }

        public async Task<IQueryable<SavedJob>> GetBySaveDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(() => 
            context.SavedJobs
            .Where(sj => sj.SaveDate >= startDate && sj.SaveDate <= endDate)
            .AsQueryable());
        }

        public async Task<bool> IsSavedByJobSeekerAsync(int jobSeekerId, int vacancyId)
        {
            return await context.SavedJobs.AnyAsync(sj => sj.JobseekerId == jobSeekerId && sj.VacancyId == vacancyId);
        }
    }
}
