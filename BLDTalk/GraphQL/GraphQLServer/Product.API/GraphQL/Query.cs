using System.Collections.Generic;
using System.Threading.Tasks;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using Product.API.Data;

namespace Product.API.GraphQL
{
    public class Query
    {
        public async Task<IEnumerable<Models.Product>> GetProducts([ScopedService] ProductContext context)
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Models.Product> GetProduct(int id, [ScopedService] ProductContext context)
        {
            return await context.Products.FindAsync(id);
        }
    }
}