using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class GenaricRepository<T>:IGenaricRepository<T> where T : class
    {
        private readonly MVCDbContextRoute _dbContext;
        public GenaricRepository(MVCDbContextRoute dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(T item)
        {
            await _dbContext.Set<T>().AddAsync(item);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(T item)
        {
            _dbContext.Set<T>().Remove(item);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            if (typeof(T) == typeof(Employee))
                return (IEnumerable<T>) await _dbContext.Set<Employee>().Include(E => E.Department).ToListAsync();
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            //return _dbContext.Set<T>().Where(x => x.Id == id).FirstOrDefault();
            return  await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<int> Update(T item)
        {
            _dbContext.Set<T>().Update(item);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
