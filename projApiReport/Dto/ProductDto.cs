namespace projApiReport.Dto
{
    public class ProductDto
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CompanyProviderDto CompanyProvider { get; set; }
    }
}