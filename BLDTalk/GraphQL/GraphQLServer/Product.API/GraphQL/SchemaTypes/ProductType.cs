using HotChocolate.Types;

namespace Product.API.GraphQL.SchemaTypes
{
    public class ProductType : ObjectType<Models.Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Models.Product> descriptor)
        {
            descriptor.Name("Product");
            descriptor.Field(x => x.Id).Type<NonNullType<IdType>>();
            descriptor.Field(x => x.Name).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.SKU).Name("sku").Type<StringType>();
            descriptor.Field(x => x.Description).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Color).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Size).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Price).Type<NonNullType<FloatType>>();
            descriptor.Field(x => x.Image).Type<NonNullType<StringType>>();
        }
    }
}