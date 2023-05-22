using Interfaces.Persistence;

namespace Database.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IScarletContext _databaseContext;
        private bool _disposed;

        public UnitOfWork(IScarletContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository Repository()
        {
            return new Repository(_databaseContext);
        }

        public Task<int> CommitAsync(CancellationToken cancellationToken)
        {
            return _databaseContext.SaveChangesAsync(cancellationToken);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _databaseContext.Dispose();

            _disposed = true;
        }
    }
}
