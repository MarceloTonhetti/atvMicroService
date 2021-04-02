using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projApiProduct.Models;
using projApiProduct.Services;

namespace projApiProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService productService)
        {
            _service = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() =>
            _service.Get();

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        public ActionResult<Product> Get(string id)
        {
            var product = _service.Get(id);

            if(product == null)
                return NotFound();

            return product;
        }

        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            _service.Create(product);
            return CreatedAtRoute("GetProduct", new {id = product.Id.ToString() }, product);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Product productIn)
        {
            var product = _service.Get(id);

            if(product == null)
                return NotFound();

            _service.Update(id, productIn);
            
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public ActionResult<long> Delete(string id)
        {
            var product = _service.Get(id);

            if(product == null)
                return NotFound();

            return _service.Remove(product.Id);
        }
        
    }
}