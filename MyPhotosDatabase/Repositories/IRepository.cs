using System;
using System.Collections.Generic;

namespace MyPhotosDatabase.Repositories
{
    public interface IRepository<T> where T:class
    {
        T GetById(Guid id);
        void Add(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Func<T, bool> func);
        T FirstOrDefault(Func<T, bool> func);
        void Remove(T entity);
    }
}
