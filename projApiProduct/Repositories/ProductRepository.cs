using System.Collections.Generic;
using MongoDB.Driver;
using projApiProduct.Models;
using projApiProduct.Utils;


namespace projApiProduct.Repositories
{
    public class ProductRepository
    {
        private readonly IMongoCollection<projApiProduct.Models.Product> _products;
        private readonly IMongoCollection<CompanyProvider> _companyProvider;
        public ProductRepository(IProjApiProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

        }
    }
}