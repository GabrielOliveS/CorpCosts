using CorpCosts.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Operations;

namespace CorpCosts.DAL
{
    public class UserRepository
    {
        IMongoCollection<User> _collection;
        public UserRepository(IMongoDatabase db)
        {
            _collection = db.GetCollection<User>(typeof(User).Name);
        }

        public List<User> GetAll()
        {
            return _collection.AsQueryable().ToList();
        }

        public User? GetUserById(ObjectId id)
        {
            return _collection.AsQueryable().FirstOrDefault(x => x._id == id);
        }

        public bool CreateUser(User user)
        {
            _collection.InsertOne(user);
            return true;
        }

        public bool EditUser(ObjectId id, User user)
        {
            var builder = new UpdateDefinitionBuilder<User>();
            var update = builder.Set(x => x.Email, user.Email);

            _collection.UpdateOne(x => x._id == id, update);
            return true;
        }

        public bool DeleteUser(ObjectId id)
        {
            _collection.DeleteOne(x => x._id == id);
            return true;
        }
    }
}
