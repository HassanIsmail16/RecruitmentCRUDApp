using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EmployerRepository : Repository<Employer>, IEmployerRepository
    {
        public EmployerRepository(RecruitmentContext context) : base(context)
        {
        }

        public Task<Employer> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<JobApplication>> GetJobApplicationsForEmployerAsync(int employerId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetVacanciesPostedByEmployerAsync(int employerId)
        {
            throw new NotImplementedException();
        }
    }
}
