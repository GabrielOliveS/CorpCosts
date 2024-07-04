using CorpCosts.Model.Entities;
using MongoDB.Bson;

namespace CorpCosts.DAL
{
    public interface IRepository<T>
    {
        bool Create(T obj);
        bool Delete(ObjectId id);
        bool Edit(ObjectId id, T obj);
        List<T> GetAll();
        T? GetById(ObjectId id);
    }
}
