using Microsoft.EntityFrameworkCore.Query;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Repository.DBRepository
{
    public interface IRepository<T> where T : class
    {
        public Task<T> AddAsync(T entity, CancellationToken cancellationToken);
        public Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        public Task<T> FindAsync(int id, CancellationToken cancellationToken);
        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        public Task DeleteAsync(T entity, CancellationToken cancellationToken);
        public Task<int> CountAllAsync(CancellationToken cancellationToken);
        public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);
        public Task<IList<T>> GetAllAsync(CancellationToken cancellationToken);
        public IQueryable<T> QueryableSelect(params Expression<Func<T, object>>[] includes);
        public IQueryable<T> QueryableSelect(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
    }
}