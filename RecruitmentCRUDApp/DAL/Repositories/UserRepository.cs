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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(RecruitmentContext context) : base(context, "user_id")
        {
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await context.Users.FromSqlInterpolated($"SELECT * FROM [ User ] WHERE email = {email}").FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetByUserTypeAsync(string userType)
        {
            return await context.Users.FromSqlInterpolated($"SELECT * FROM [ User ] WHERE user_type = {userType}").ToListAsync();
        }

        public async Task<List<User>> GetBySignupDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await context.Users.FromSqlInterpolated($"SELECT * FROM [ User ] WHERE signup_date BETWEEN {startDate} AND {endDate}").ToListAsync();
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            return await context.Users.FromSqlInterpolated($"SELECT * FROM [ User ] WHERE email = {email}").FirstOrDefaultAsync() == null;
        }

        public async Task UpdatePasswordAsync(int userId, string password)
        {
            var user = await GetByIdAsync(userId);
            if (user != null)
            {
                user.Password = password;
                await UpdateAsync(user);
            }
        }

        public async Task<bool> IsPasswordCorrect(string email, string password)
        {
            return await context.Users.FromSqlInterpolated($"SELECT * FROM [ User ] WHERE email = {email} AND password = {password}").AnyAsync();
        }
    }
}
