using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Interfaces.Persistence
{
    public interface IApplicationContext : IDisposable
    {
        ChangeTracker ChangeTracker { get; }

        EntityEntry Attach(object entity);
        EntityEntry Entry(object entity);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        int SaveChanges();
    }
}


// 'Database.Repository<Interfaces.Core.ICoupon>'
// 'Interfaces.DataInterfaces.IRepository<TEntity>'
