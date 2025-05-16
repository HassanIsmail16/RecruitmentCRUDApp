using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
        Task<List<User>> GetByUserTypeAsync(string userType);
        Task<List<User>> GetBySignupDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<bool> IsEmailUniqueAsync(string email);
        Task UpdatePasswordAsync(int userId, string password);

        Task<bool> IsPasswordCorrect(string email, string password);
    }
}
