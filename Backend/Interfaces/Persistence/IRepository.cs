using System.Linq.Expressions;

namespace Interfaces.Persistence
{
    // https://medium.com/@mxcmxc/unit-of-work-with-repository-pattern-boilerplate-518726e4beb7
    public interface IRepository
    {
        Task<TEntity?> GetByIdAsync<TEntity>(params object[] id) where TEntity : class;
        Task<IEnumerable<TEntity?>> GetAllAsync<TEntity>() where TEntity : class;
        IQueryable<TEntity> FindQueryable<TEntity>(Expression<Func<TEntity, bool>> expression, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null) where TEntity : class;
        Task<List<TEntity>> FindListAsync<TEntity>(Expression<Func<TEntity, bool>>? expression, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, CancellationToken cancellationToken = default) where TEntity : class;
        Task<List<TEntity>> FindAllAsync<TEntity>(CancellationToken cancellationToken) where TEntity : class;
        Task<TEntity?> SingleOrDefaultAsync<TEntity>(Expression<Func<TEntity, bool>> expression, string includeProperties) where TEntity : class;
        TEntity Add<TEntity>(TEntity entity) where TEntity : class;
        void Update<TEntity>(TEntity entity) where TEntity : class;
        void UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        void Delete<TEntity>(TEntity entity) where TEntity : class;

    }
}
