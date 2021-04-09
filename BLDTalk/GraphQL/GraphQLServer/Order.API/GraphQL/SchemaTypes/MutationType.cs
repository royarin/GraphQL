using System.ComponentModel.DataAnnotations;
using HotChocolate.Types;

namespace Order.API.GraphQL.SchemaTypes
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Name("Mutation");
            descriptor.Field(x => x.CreateOrder(default, default))
                .Type<NonNullType<OrderType>>()
                .Argument("createOrderInput", x => x.Type<NonNullType<CreateOrderInputType>>());
        }
    }
}