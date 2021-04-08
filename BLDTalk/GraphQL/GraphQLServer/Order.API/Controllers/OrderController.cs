using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Order.API.Data;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext _context;

        public OrderController(OrderContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            return new OkObjectResult(await _context.Orders.ToListAsync());
        }

        [HttpGet("{orderNumber}")]
        public async Task<IActionResult> GetOrder(int orderNumber)
        {
            return new ObjectResult(await _context.Orders.Include(x=>x.LineItems).FirstOrDefaultAsync(x=>x.OrderNumber == orderNumber));
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Models.Order newOrder)
        {
            await _context.Orders.AddAsync(newOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrder), new { orderNumber = newOrder.OrderNumber }, newOrder);
        }
    }
}
