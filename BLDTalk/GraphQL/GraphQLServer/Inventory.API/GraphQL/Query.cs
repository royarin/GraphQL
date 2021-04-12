using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using Inventory.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.GraphQL
{
    public class Query
    {
        public async Task<Models.Inventory> GetInventory(string sku, [ScopedService] InventoryContext context)
        {
            return await context.Inventory.Where(x => x.SKU == sku).FirstOrDefaultAsync();
        }
    }
}