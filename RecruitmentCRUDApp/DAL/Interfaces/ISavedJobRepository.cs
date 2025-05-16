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
        Task<List<SavedJob>> GetByJobSeekerIdAsync(int jobSeekerId);
        Task<List<SavedJob>> GetByVacancyIdAsync(int vacancyId);
        Task<List<SavedJob>> GetBySaveDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<bool> IsSavedByJobSeekerAsync(int jobSeekerId, int vacancyId);
    }
}
