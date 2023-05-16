using System.Linq.Expressions;

namespace Interfaces.DataInterfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T[] GetAll();
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);
        T GetSingle(Expression<Func<T, bool>> predicate);

        void Create(T entity);
        void Add(T entity);
        void Delete(T entity);
        int Persist();

    }
}
