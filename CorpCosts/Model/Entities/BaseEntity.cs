using MongoDB.Bson;

namespace CorpCosts.Model.Entities
{
    public abstract class BaseEntity
    {
        public ObjectId _id { get; set; }
        public string IdString => _id.ToString();

    }
}
