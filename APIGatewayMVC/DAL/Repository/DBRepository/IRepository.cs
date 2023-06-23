using Models;
using System.Linq.Expressions;

namespace DAL.Repository.DBRepository
{
    public interface IRepository<T> where T : class
    {
        public Task<T> AddAsync(T entity, CancellationToken cancellationToken);
        public Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        public Task DeleteAsync(T entity, CancellationToken cancellationToken);
    }
}