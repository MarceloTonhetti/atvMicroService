namespace projApiCliente.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MotherName { get; set; }
        public  Address Address { get; set; }
    }
}