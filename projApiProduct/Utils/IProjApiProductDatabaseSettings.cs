namespace projApiProduct.Utils
{
    public interface IProjApiProductDatabaseSettings
    {
        string ProductCollectionName { get; set;}
        string CompanyProviderCollectionName { get; set; }
        string  ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}