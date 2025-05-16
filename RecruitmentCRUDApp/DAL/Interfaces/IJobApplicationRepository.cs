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
        Task<List<JobApplication>> GetByJobSeekerIdAsync(int jobSeekerId);
        Task<List<JobApplication>> GetByVacancyIdAsync(int vacancyId);
        Task<List<JobApplication>> GetByEmployerIdAsync(int employerId);
        Task<List<JobApplication>> GetByStatusAsync(string status);
        Task<List<JobApplication>> GetApplicationsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task UpdateApplicationStatusAsync(int appId, string status);
    }
}
