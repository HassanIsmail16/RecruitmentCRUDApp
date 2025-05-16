using DAL.Interfaces;
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
        public Task<IQueryable<SavedJob>> GetByJobSeekerIdAsync(int jobSeekerId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<SavedJob>> GetBySaveDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<SavedJob>> GetByVacancyIdAsync(int vacancyId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsSavedByJobSeekerAsync(int jobSeekerId, int vacancyId)
        {
            throw new NotImplementedException();
        }
    }
}
