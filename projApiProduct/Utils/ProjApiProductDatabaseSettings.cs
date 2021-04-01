namespace projApiProduct.Utils
{
    public class ProjApiProductDatabaseSettings : IProjApiProductDatabaseSettings
    {
        public string ProductCollectionName { get; set; }
        public string CompanyProviderCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}