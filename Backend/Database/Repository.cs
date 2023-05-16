using Interfaces.DataInterfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace Database
{
    /// <summary>
    /// Build a repository for a specified POCO class and a DbContext
    /// </summary>
    /// <typeparam name="T">The entity to be accessed, must be present in the DbContext</typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {

        private DbContext _dbContext;
        private DbSet<T> _entities;

        public DbSet<T> Entities
        {
            get { return _entities; }
        }

        public Repository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            _entities = dbContext.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                 .Single(p => p.PropertyType == typeof(DbSet<T>))
                                 .GetValue(dbContext) as DbSet<T>;
        }

        #region repo methods

        public T[] GetAll()
        {
            return _entities.ToArray();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _entities.SingleOrDefault(predicate);
        }

        public void Create(T entity)
        {
            Add(entity);
            Persist();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public int Persist()
        {
            return _dbContext.SaveChanges();
        }

        #endregion

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
            GC.SuppressFinalize(this);
        }

    }
}
