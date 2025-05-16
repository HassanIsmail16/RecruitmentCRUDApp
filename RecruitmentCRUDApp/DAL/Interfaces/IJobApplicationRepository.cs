using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces
{
    public interface IJobApplicationRepository : IRepository<JobApplication>
    {
        Task<IQueryable<JobApplication>> GetByJobSeekerIdAsync(int jobSeekerId);
        Task<IQueryable<JobApplication>> GetByVacancyIdAsync(int vacancyId);
        Task<IQueryable<JobApplication>> GetByEmployerIdAsync(int employerId);
        Task<IQueryable<JobApplication>> GetByStatusAsync(string status);
        Task<IQueryable<JobApplication>> GetApplicationsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task UpdateApplicationStatusAsync(int appId, string status);
    }
}
