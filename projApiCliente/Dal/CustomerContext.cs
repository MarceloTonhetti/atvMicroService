using Microsoft.EntityFrameworkCore;
using projApiCliente.Models;

namespace projApiCliente.Dal
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {   
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}