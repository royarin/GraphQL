using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using Order.API.Data;

namespace Order.API.GraphQL
{
    public class Query
    {
        public async Task<IEnumerable<Models.Order>> GetOrders([Service] OrderContext context){
            return await context.Orders.ToListAsync();
        }

        public async Task<Models.Order> GetOrder(int orderNumber, [Service] OrderContext context){
            return await context.Orders.Include(x=>x.LineItems).FirstOrDefaultAsync(x=>x.OrderNumber == orderNumber);
        }
    }
}