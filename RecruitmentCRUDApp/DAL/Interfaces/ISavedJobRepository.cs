using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISavedJobRepository : IRepository<SavedJob>
    {
        Task<IQueryable<SavedJob>> GetByJobSeekerIdAsync(int jobSeekerId);
        Task<IQueryable<SavedJob>> GetByVacancyIdAsync(int vacancyId);
        Task<IQueryable<SavedJob>> GetBySaveDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<bool> IsSavedByJobSeekerAsync(int jobSeekerId, int vacancyId);
    }
}
