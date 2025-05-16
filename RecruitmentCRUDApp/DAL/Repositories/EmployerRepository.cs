using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EmployerRepository : Repository<Employer>, IEmployerRepository
    {
        public EmployerRepository(RecruitmentContext context) : base(context, "user_id")
        {
        }

        public async Task<Employer> GetByUserIdAsync(int userId)
        {
            return await context.Employers.FirstOrDefaultAsync(e => e.UserId == userId);
        }

        public async Task<List<JobApplication>> GetJobApplicationsForEmployerAsync(int employerId)
        {
            return await Task.Run(() =>
            context.JobApplications.Where(ja => ja.EmployerId == employerId)
            .AsQueryable());
        }

        public async Task<List<Vacancy>> GetVacanciesPostedByEmployerAsync(int employerId)
        {
            return await Task.Run(() =>
            context.Vacancies.Where(v => v.EmployerId == employerId)
            .AsQueryable());
        }
    }
}
