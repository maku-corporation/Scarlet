using System.Linq.Expressions;

namespace Interfaces.Persistence
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity[] GetAll();
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate);
        TEntity GetSingle(Expression<Func<TEntity, bool>> predicate);

        void Create(TEntity entity);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int ID);
        void Update(TEntity entity);
        int Persist();

    }
}
