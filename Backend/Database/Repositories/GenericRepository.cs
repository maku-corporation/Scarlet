using Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace Database.Repositories
{
    /// <summary>
    /// Build a repository for a specified POCO class and a DbContext
    /// </summary>
    /// <typeparam name="TEntity">The entity to be accessed, must be present in the DbContext</typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private IApplicationContext _dbContext;
        private DbSet<TEntity> _entities;

        public DbSet<TEntity> Entities
        {
            get { return _entities; }
        }

        public GenericRepository(IApplicationContext dbContext)
        {
            if (dbContext == null)
            {
                throw new RapositoryNullException("dbContext");
            }

            _dbContext = dbContext;
            _entities = dbContext.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                 .Single(p => p.PropertyType == typeof(DbSet<TEntity>))
                                 .GetValue(dbContext) as DbSet<TEntity>;
        }

        #region repo methods

        public virtual TEntity[] GetAll()
        {
            return _entities.ToArray();
        }

        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public virtual TEntity GetSingle(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.SingleOrDefault(predicate);
        }

        public virtual void Create(TEntity entity)
        {
            Add(entity);
            Persist();
        }

        public virtual void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbContext.Attach(entity);
            }
            _entities.Remove(entity);
        }

        public virtual void Delete(int ID)
        {
            TEntity entity = _entities.Find(ID);
            Delete(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _entities.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual int Persist()
        {
            return _dbContext.SaveChanges();
        }

        #endregion

        public virtual void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
            GC.SuppressFinalize(this);
        }

    }
}
