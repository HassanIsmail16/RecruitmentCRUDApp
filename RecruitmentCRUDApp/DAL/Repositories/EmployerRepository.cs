using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            return await context.Employers.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE user_id = {userId}").FirstOrDefaultAsync();
        }

        public async Task<List<JobApplication>> GetJobApplicationsForEmployerAsync(int employerId)
        {
            return await context.JobApplications.FromSqlInterpolated($"SELECT * FROM [ JobApplication ] WHERE employer_id = {employerId}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetVacanciesPostedByEmployerAsync(int employerId)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE employer_id = {employerId}").ToListAsync();
        }
    }
}
