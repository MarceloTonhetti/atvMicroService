namespace projApiReport.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public AddressDto Address { get; set; }
    }
}