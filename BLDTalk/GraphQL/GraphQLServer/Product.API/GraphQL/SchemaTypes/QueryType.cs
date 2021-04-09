using HotChocolate.Types;

namespace Product.API.GraphQL.SchemaTypes
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Name("Query");
            descriptor.Field(x => x.GetProducts(default)).Type<ListType<ProductType>>();
            descriptor.Field(x => x.GetProduct(default, default)).Type<ProductType>();
        }
    }
}