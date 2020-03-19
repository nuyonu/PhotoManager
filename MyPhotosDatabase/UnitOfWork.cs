using MyPhotosDatabase.Repositories;

namespace MyPhotosDatabase
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyPhotosContainer _context;
        public UnitOfWork(MyPhotosContainer context)
        {
            _context = context;
            Media = new MediaRepository(_context);
        }

        public IMediaRepository Media { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
