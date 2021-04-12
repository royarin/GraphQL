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
        private readonly IDbContextFactory<OrderContext> _contextFactory;

        public OrderController(IDbContextFactory<OrderContext> contextFactory)
        {
            _contextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return new OkObjectResult(await context.Orders.Include(x => x.LineItems).ToListAsync());
            }
        }

        [HttpGet("{orderNumber}")]
        public async Task<IActionResult> GetOrder(int orderNumber)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return new ObjectResult(await context.Orders.Include(x => x.LineItems)
                    .FirstOrDefaultAsync(x => x.OrderNumber == orderNumber));
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Models.Order newOrder)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                await context.Orders.AddAsync(newOrder);
                await context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetOrder), new {orderNumber = newOrder.OrderNumber}, newOrder);
            }
        }
    }
}
