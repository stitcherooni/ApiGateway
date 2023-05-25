using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        public Task AddAsync(T entity);
        public Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}