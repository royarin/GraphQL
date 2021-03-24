using HotChocolate.Types;

namespace Products
{
    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Name("Product");
            descriptor.Field(x => x.Id).Type<IdType>();
            descriptor.Field(x => x.Name).Type<StringType>();
            descriptor.Field(x => x.Price).Type<FloatType>().Authorize();
            descriptor.Field(x => x.Weight).Type<IntType>();
        }
    }
}