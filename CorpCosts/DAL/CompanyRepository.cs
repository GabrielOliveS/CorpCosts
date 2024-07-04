using CorpCosts.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CorpCosts.DAL
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(IMongoDatabase db)
        {
            _collection = db.GetCollection<Company>(nameof(Company));
        }
        public override bool Edit(ObjectId id, Company obj)
        {
            var builder = new UpdateDefinitionBuilder<Company>();
            var update = builder.Combine(builder.Set(x => x.Cnpj, obj.Cnpj),
                                         builder.Set(x => x.NomeFantasia, obj.NomeFantasia),
                                         builder.Set(x => x.RazaoSocial, obj.RazaoSocial) );

            _collection.UpdateOne(x => x._id == id, update);
            return true;
        }
    }
}
