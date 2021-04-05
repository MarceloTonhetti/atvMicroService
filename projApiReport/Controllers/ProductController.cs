using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projApiReport.Dto;
using projApiReport.Services;

namespace projApiReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _service;

        public ProductController()
        {
            _service = new ProductService();
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetProductAsync()
        {
            return await _service.GetProductAsync();
        }
    }
}