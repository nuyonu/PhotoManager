namespace MyPhotosDatabase.Repositories
{
    class MediaRepository : Repository<Media>, IMediaRepository
    {
        private readonly MyPhotosContainer _context;
        public MediaRepository(MyPhotosContainer context) : base(context)
        {
            _context = context;
        }
    }
}
