using MongoDB.Bson;

namespace CorpCosts.Model.Entities
{
    public class User 
    {
        public ObjectId _id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public string IdString => _id.ToString();
    }
}
