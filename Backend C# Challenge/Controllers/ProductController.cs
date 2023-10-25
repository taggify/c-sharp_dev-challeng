using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend_C_Challenge.Models;
using Backend_C__Challenge.Services;

namespace Backend_C__Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _productservice.GetAllProducts());
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(long id)
        {
            var product = await _productservice.GetProduct(id);

            if (product == null)
            {
            return NotFound();
            }

            return product;
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, Product product)
        {   
            if (id != product.Id)
            {
            return BadRequest();
            }

            var result = await _productservice.UpdateProduct(id, product);

            if (result == Result.NotFound)
            {
                return NotFound();
            }
            else if (result == Result.Success)
            {
                return NoContent();
            }
            else
            {
                return StatusCode(500, "Error en la actualización");            
            }     
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {
            return Ok(await _productservice.CreateProduct(product));
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            return Ok(await _productservice.DeleteProduct(id));
        }
    }
}
