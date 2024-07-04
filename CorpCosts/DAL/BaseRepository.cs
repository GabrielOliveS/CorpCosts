using CorpCosts.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CorpCosts.DAL
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected IMongoCollection<T> _collection;
        public List<T> GetAll()
        {
            return _collection.AsQueryable().ToList();
        }

        public T? GetById(ObjectId id)
        {
            return _collection.AsQueryable().FirstOrDefault(x => x._id == id);
        }

        public bool Create(T obj)
        {
            _collection.InsertOne(obj);
            return true;
        }

        public bool Delete(ObjectId id)
        {
            _collection.DeleteOne(x => x._id == id);
            return true;
        }

        public virtual bool Edit(ObjectId id, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
