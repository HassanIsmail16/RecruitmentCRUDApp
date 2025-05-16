using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<IQueryable<Company>> GetCompaniesByManagerIdAsync(int managerId);
        Task<IQueryable<Employer>> GetEmployersForCompanyAsync(int companyId);
        Task<IQueryable<Vacancy>> GetVacanciesForCompanyAsync(int companyId);
    }
}
