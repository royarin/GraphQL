using Common.GraphQL.Extensions;
using HotChocolate.Types;
using Order.API.Data;

namespace Order.API.GraphQL.SchemaTypes
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Name("Query");
            descriptor.Field(x => x.GetOrders(default)).Type<ListType<OrderType>>().UsePooledDbContext<OrderContext>();
            descriptor.Field(x => x.GetOrder(default, default))
                .Argument("orderNumber",x=>x.Type<NonNullType<IdType>>()).Type<OrderType>()
                .UsePooledDbContext<OrderContext>();
        }
    }
}