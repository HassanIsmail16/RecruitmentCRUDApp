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
        Task<List<Company>> GetCompaniesByManagerIdAsync(int managerId);
        Task<List<Employer>> GetEmployersForCompanyAsync(int companyId);
        Task<List<Vacancy>> GetVacanciesForCompanyAsync(int companyId);
    }
}
