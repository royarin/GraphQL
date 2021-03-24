using System.Collections.Generic;
using HotChocolate.Types;
using Microsoft.AspNetCore.Authorization;

namespace Products
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(x => x.GetProducts(default))
                .Type<ListType<ProductType>>();

            descriptor.Field(x => x.GetTopProducts(default, default))
                .Type<ListType<ProductType>>();

            descriptor.Field(x => x.GetProduct(default, default))
            .Type<NonNullType<ProductType>>();
        }
    }
}