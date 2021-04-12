using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IDbContextFactory<InventoryContext> _contextFactory;

        public InventoryController(IDbContextFactory<InventoryContext> contextFactory)
        {
            _contextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
        }

        [HttpGet("sku")]
        public async Task<IActionResult> GetInventory(string sku)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                return new OkObjectResult(
                    await context.Inventory.Where(x => x.SKU == sku).FirstOrDefaultAsync());
            }
        }
    }
}
