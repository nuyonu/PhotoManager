using MyPhotosDatabase.Repositories;
using System;

namespace MyPhotosDatabase
{
    public interface IUnitOfWork : IDisposable
    {
        IMediaRepository Media { get; }
        int Complete();
    }
}
