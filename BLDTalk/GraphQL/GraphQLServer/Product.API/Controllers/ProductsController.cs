using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product.API.Data;

namespace Product.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductContext _context;
        public ProductsController(ProductContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return new OkObjectResult(await _context.Products.ToListAsync());
        }

        
        [HttpGet("Products/Top/{first}")]
        public async Task<IActionResult> GetTopProducts(int first)
        {
            return new OkObjectResult(await _context.Products.Take(first).ToListAsync());
        }


        [HttpGet("Products/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            return new OkObjectResult(await _context.Products.FindAsync(id));
        }
    }
}
