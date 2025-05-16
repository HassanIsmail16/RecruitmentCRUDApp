using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly RecruitmentContext context;

        public UserRepository(RecruitmentContext context)
        {
            this.context = context;
        }

        public async Task Add(User user)
        {
            await context.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await context.Users.AnyAsync(u => u.UserId == id);
        }

        public IQueryable<User> GetAll()
        {
            return context.Users.AsQueryable();
        }

        public async Task<User> GetByEmail(string email)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetById(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task Remove(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user != null)
            {
                context.Remove(user);
                await context.SaveChangesAsync();
            }
        }

        public async Task Update(User user)
        {
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
