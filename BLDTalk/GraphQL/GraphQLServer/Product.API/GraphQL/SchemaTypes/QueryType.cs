using Common.GraphQL.Extensions;
using HotChocolate.Types;
using Product.API.Data;

namespace Product.API.GraphQL.SchemaTypes
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Name("Query");
            descriptor.Field(x => x.GetProducts(default)).Type<ListType<ProductType>>().UsePooledDbContext<ProductContext>();
            descriptor.Field(x => x.GetProduct(default, default)).Type<ProductType>()
                .Argument("id",x=>x.Type<NonNullType<IdType>>()).UsePooledDbContext<ProductContext>();
        }
    }
}