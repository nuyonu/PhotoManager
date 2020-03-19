using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotosDatabase
{
    public static class MyPhotosAPI
    {
        //C
        public static void SaveMedia(Media media)
        {
            using (var unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                unitOfWork.Media.Add(media);
                unitOfWork.Complete();
            }
        }
        //R
        public static Media GetMediaById(Guid id) 
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                return unitOfWork.Media.GetById(id);
            }
        }
        public static List<Media> GetAll()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                return unitOfWork.Media.GetAll().ToList();
            }
        }
        public static List<Media> GetAll(Func<Media, bool> predicate)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                return unitOfWork.Media.GetAll(predicate).ToList();
            }
        }
        //U
        public static void UpdateMedia(Guid id, Media media)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                var entity = unitOfWork.Media.FirstOrDefault(item => item.Id == id);
                entity.Name = media.Name;
                entity.Event = media.Event;
                entity.People = media.People;
                entity.Tags = media.Tags;
                entity.Location = media.Location;
                entity.Description = media.Description;
                unitOfWork.Complete();
            }
        }
        //D
        public static void DeleteMedia(Media media)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                var entity = unitOfWork.Media.FirstOrDefault(item => item.Id == media.Id);
                entity.Deleted = true;
                unitOfWork.Complete();
            }
        }

        public static void DeleteMediaById(Guid id)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                var entity = unitOfWork.Media.FirstOrDefault(item => item.Id == id);
                entity.Deleted = true;
                unitOfWork.Complete();
            }
        }
        //ANOTHERS
        public static bool AlreadyInDatabaseAndNotDeleted(string path)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(new MyPhotosContainer()))
            {
                var entity = unitOfWork.Media.FirstOrDefault(item => item.Path == path && item.Deleted == false);
                if (entity != null)
                    return true;
                return false;
            }
        }
    }
}
