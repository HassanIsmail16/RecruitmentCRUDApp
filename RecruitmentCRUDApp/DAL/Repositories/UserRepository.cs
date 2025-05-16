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
        public UserRepository(RecruitmentContext context) : base(context)
        {
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
        }

        public async Task<IQueryable<User>> GetByUserTypeAsync(string userType)
        {
            return await Task.Run(() => 
            context.Users
            .Where(u => u.UserType.ToLower() == userType.ToLower())
            .AsQueryable());
        }

        public async Task<IQueryable<User>> GetBySignupDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(() => 
            context.Users
            .Where(u => u.SignupDate >= startDate && u.SignupDate <= endDate)
            .AsQueryable());
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
        {
            return !await context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
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
            return await context.Users.FromSqlInterpolated($"SELECT * FROM [User] WHERE email = {email} AND password = {password}").AnyAsync();
        }
    }
}
