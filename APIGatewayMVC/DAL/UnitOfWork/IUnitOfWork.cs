using DAL.Repository;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public Task SaveAsync();
        public IRepository<T> CreateRepository<T>() where T : class;
    }
}