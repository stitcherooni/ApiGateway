using System.Linq.Expressions;

namespace DAL.Repository.DBRepository
{
    public interface IRepository<T> where T : class
    {
        public Task AddAsync(T entity);
        public Task<int> CountAsync(Expression<Func<T, bool>> predicate);
        public Task<T> FindAsync(int id);
    }
}