using CorpCosts.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CorpCosts.DAL
{
    public class UserRepository : BaseRepository<User>, IUserRepository 
    {
        public UserRepository(IMongoDatabase db)
        {
            _collection = db.GetCollection<User>(typeof(User).Name);
        }
        public override bool Edit(ObjectId id, User user)
        {
            var builder = new UpdateDefinitionBuilder<User>();
            var update = builder.Set(x => x.Email, user.Email);

            _collection.UpdateOne(x => x._id == id, update);
            return true;
        }
    }
}
