using CorpCosts.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CorpCosts.DAL
{
    public class UserRepository
    {
        IMongoCollection<User> _collection;
        public UserRepository(IMongoDatabase db)
        {
            _collection = db.GetCollection<User>(typeof(User).Name);
        }

        public User GetUserById(ObjectId id)
        {
            return _collection.Find(x => x._id == id).FirstOrDefault();
        }

        public bool CreateUser(User user)
        {
            _collection.InsertOne(user);
            return true;
        }
    }
}
