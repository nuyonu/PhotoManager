using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MyPhotosDatabase.Repositories
{
    class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> entities;

        public Repository(DbContext context)
        {
            this.entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            entities.Add(entity);
        }

        public T FirstOrDefault(Func<T, bool> func)
        {
            return entities.FirstOrDefault(func);
        }

        public IEnumerable<T> GetAll()
        {
            return entities;
        }

        public IEnumerable<T> GetAll(Func<T, bool> func)
        {
            return entities.Where(func);
        }

        public T GetById(Guid id)
        {
            return entities.Find(id);
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
        }
    }
}
