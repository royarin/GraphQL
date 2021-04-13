using HotChocolate.Types;
using Order.API.Models;

namespace Order.API.GraphQL.SchemaTypes
{
    public class LineItemType : ObjectType<LineItem>
    {
        protected override void Configure(IObjectTypeDescriptor<LineItem> descriptor)
        {
            descriptor.Name("LineItem");
            descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
            descriptor.Field(x => x.SKU).Name("sku").Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Quantity).Type<NonNullType<IntType>>();
        }
    }
}