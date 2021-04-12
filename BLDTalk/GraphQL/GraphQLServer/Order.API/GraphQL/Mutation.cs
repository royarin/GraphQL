using System.Reflection;
using System.Threading.Tasks;
using HotChocolate;
using Order.API.Data;
using Mapster;

namespace Order.API.GraphQL
{
    public class Mutation
    {
        public async Task<Models.Order> CreateOrder(CreateOrderInput createOrderInput, [ScopedService] OrderContext context){
            var newOrder=createOrderInput.Adapt<Models.Order>();

            await context.Orders.AddAsync(newOrder);
            await context.SaveChangesAsync();

            return newOrder;
        }
    }
}