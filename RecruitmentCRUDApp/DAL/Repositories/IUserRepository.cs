using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
        Task<User> GetByEmail(string email);
        IQueryable<User> GetAll();
        Task Add(User user);
        Task Update(User user);
        Task Remove(int id);
        Task<bool> Exists(int id);
    }
}
