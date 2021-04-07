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
        private readonly InventoryContext _context;
        
        public InventoryController(InventoryContext context)
        {
            _context = context;
        }
        
        [HttpGet("sku")]
        public async Task<IActionResult> GetInventory(string sku)
        {
            return new OkObjectResult(await _context.Inventory.Where(x=>x.SKU == sku).FirstOrDefaultAsync());
        }
    }
}
