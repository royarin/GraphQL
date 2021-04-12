using System;
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
        private readonly IDbContextFactory<ProductContext> _contextFactory;
        public ProductsController(IDbContextFactory<ProductContext> contextFactory)
        {
            _contextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
        }

        
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return new OkObjectResult(await context.Products.ToListAsync());
            }
        }

        
        [HttpGet("Products/Top/{first}")]
        public async Task<IActionResult> GetTopProducts(int first)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return new OkObjectResult(await context.Products.Take(first).ToListAsync());
            }
        }


        [HttpGet("Products/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return new OkObjectResult(await context.Products.FindAsync(id));
            }
        }
    }
}
