using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly RecruitmentContext context;

        public Repository(RecruitmentContext context)
        {
            this.context = context;
        }

        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            return await Task.Run(() => context.Set<TEntity>().AsQueryable());
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();

        }
        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                context.Set<TEntity>().Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await GetByIdAsync(id) != null;
        }
    }
}
