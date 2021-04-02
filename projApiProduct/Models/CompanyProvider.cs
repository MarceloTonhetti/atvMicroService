using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projApiProduct.Models
{
    public class CompanyProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}