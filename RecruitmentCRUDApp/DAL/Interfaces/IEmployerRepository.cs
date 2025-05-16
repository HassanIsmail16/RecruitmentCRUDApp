using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEmployerRepository : IRepository<Employer>
    {
        Task<Employer> GetByUserIdAsync(int userId);
        Task<IQueryable<JobApplication>> GetJobApplicationsForEmployerAsync(int employerId);
        Task<IQueryable<Vacancy>> GetVacanciesPostedByEmployerAsync(int employerId);
    }
}
