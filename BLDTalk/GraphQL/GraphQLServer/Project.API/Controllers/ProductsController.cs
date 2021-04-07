using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;

namespace Project.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductContext _context;
        public ProductsController(ProductContext context)
        {
            _context = context;
        }

        [Route("Products")]
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return new OkObjectResult(await _context.Products.ToListAsync());
        }

        [Route("Products/Top/{first}")]
        [HttpGet]
        public async Task<IActionResult> GetTopProducts(int first)
        {
            return new OkObjectResult(await _context.Products.Take(first).ToListAsync());
        }

        [Route("Products/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            return new OkObjectResult(await _context.Products.FindAsync(id));
        }
    }
}
