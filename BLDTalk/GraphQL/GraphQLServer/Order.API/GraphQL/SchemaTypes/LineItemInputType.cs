using System.ComponentModel.DataAnnotations;
using HotChocolate.Types;

namespace Order.API.GraphQL.SchemaTypes
{
    public class LineItemInputType:InputObjectType<LineItemInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<LineItemInput> descriptor)
        {
            descriptor.Name("LineItemInput");
            descriptor.Field(x => x.SKU).Name("sku").Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Quantity).Type<NonNullType<IntType>>();
        }
    }
}