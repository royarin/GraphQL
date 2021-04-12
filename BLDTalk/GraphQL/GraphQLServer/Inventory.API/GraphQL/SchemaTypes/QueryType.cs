using Common.GraphQL.Extensions;
using HotChocolate.Types;
using Inventory.API.Data;


namespace Inventory.API.GraphQL.SchemaTypes
{
    public class QueryType:ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Name("Query");
            descriptor.Field(x=>x.GetInventory(default,default)).Type<InventoryType>()
                .Argument("sku",x=>x.Type<NonNullType<StringType>>()).UsePooledDbContext<InventoryContext>();
        }
    }
}