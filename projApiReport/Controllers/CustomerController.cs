using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projApiReport.Dto;
using projApiReport.Services;

namespace projApiReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController
    {
        private CustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> GetCustomerAsync()
        {
            return await _service.GetCustomerAsync();
        }
    }
}