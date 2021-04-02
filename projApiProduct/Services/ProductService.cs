using System.Collections.Generic;
using MongoDB.Driver;
using projApiProduct.Models;
using projApiProduct.Repositories;
using projApiProduct.Utils;

namespace projApiProduct.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _products;
        public ProductService(IProjApiProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _products = database.GetCollection<Product>(settings.ProductCollectionName);
        }

        public List<Product> Get() =>
            _products.Find(product => true).ToList();
        
        public Product Get(string id) =>
            _products.Find<Product>(product => product.Id == id).FirstOrDefault();

        public Product Create(Product product)
        {
            _products.InsertOne(product);
            return product;
        }

        public void Update(string id, Product productIn) =>
            _products.ReplaceOne(product => product.Id == id, productIn);

        public long Remove(string id)
        {
            return _products.DeleteOne(product => product.Id == id).DeletedCount;
        }
    }
}