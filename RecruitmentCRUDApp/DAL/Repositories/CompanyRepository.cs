using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(RecruitmentContext context) : base(context)
        {
        }

        public async Task<IQueryable<Company>> GetCompaniesByManagerIdAsync(int managerId)
        {
            return await Task.Run(() => context.Companies.Where(c => c.ManagerId == managerId).AsQueryable());
        }

        public async Task<IQueryable<Employer>> GetEmployersForCompanyAsync(int companyId)
        {
            return await Task.Run(() => context.Employers.Where(e => e.CompanyId == companyId).AsQueryable());
        }

        public async Task<IQueryable<Vacancy>> GetVacanciesForCompanyAsync(int companyId)
        {
            return await Task.Run(() => context.Vacancies.Where(v => v.CompanyId == companyId).AsQueryable());
        }
    }
}
