using HotChocolate.Types;

namespace Inventory.API.GraphQL.SchemaTypes
{
    public class InventoryType : ObjectType<Models.Inventory>
    {
        protected override void Configure(IObjectTypeDescriptor<Models.Inventory> descriptor)
        {
            descriptor.Name("Inventory");
            descriptor.Field(x=>x.Id).Type<NonNullType<IdType>>();
            descriptor.Field(x=>x.SKU).Name("sku").Type<NonNullType<StringType>>();
            descriptor.Field(x=>x.Stock).Type<NonNullType<IntType>>();
        }
    }
}