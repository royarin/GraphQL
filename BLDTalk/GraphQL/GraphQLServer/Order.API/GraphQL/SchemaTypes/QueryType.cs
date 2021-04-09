using HotChocolate.Types;

namespace Order.API.GraphQL.SchemaTypes
{
    public class QueryType:ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Name("Query");
            descriptor.Field(x=>x.GetOrders(default)).Type<ListType<OrderType>>();
            descriptor.Field(x=>x.GetOrder(default,default)).Type<OrderType>();
        }
    }
}