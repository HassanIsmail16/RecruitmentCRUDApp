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
        public Task<IQueryable<Company>> GetCompaniesByManagerIdAsync(int managerId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Employer>> GetEmployersForCompanyAsync(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Vacancy>> GetVacanciesForCompanyAsync(int companyId)
        {
            throw new NotImplementedException();
        }
    }
}
