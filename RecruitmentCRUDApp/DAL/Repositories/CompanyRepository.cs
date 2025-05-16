using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public CompanyRepository(RecruitmentContext context) : base(context, "company_id")
        {
        }

        public async Task<List<Company>> GetCompaniesByManagerIdAsync(int managerId)
        {
            return await context.Companies.FromSqlInterpolated($"SELECT * FROM [ Company ] WHERE {managerId}").ToListAsync();
        }

        public async Task<List<Employer>> GetEmployersForCompanyAsync(int companyId)
        {
            return await context.Employers.FromSqlInterpolated($"SELECT * FROM [ Employer ] WHERE company_id == {companyId}").ToListAsync();
        }

        public async Task<List<Vacancy>> GetVacanciesForCompanyAsync(int companyId)
        {
            return await context.Vacancies.FromSqlInterpolated($"SELECT * FROM [ Vacancy ] WHERE company_id = {companyId}").ToListAsync();
        }
    }
}
