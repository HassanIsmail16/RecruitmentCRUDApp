using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Models;

namespace DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public Task<User> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<User>> GetBySignupDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<User>> GetByUserTypeAsync(string userType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEmailUniqueAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePasswordAsync(int userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
