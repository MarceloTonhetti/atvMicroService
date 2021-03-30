using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projApiProduct.Models
{
    public class CompanyProvider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}