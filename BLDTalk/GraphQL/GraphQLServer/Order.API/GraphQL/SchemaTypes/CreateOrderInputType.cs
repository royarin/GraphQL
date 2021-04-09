using HotChocolate.Types;

namespace Order.API.GraphQL.SchemaTypes
{
    public class CreateOrderInputType : InputObjectType<CreateOrderInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<CreateOrderInput> descriptor)
        {
            descriptor.Name("CreateOrderInput");
            descriptor.Field(x => x.DeliveryName).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.DeliveryAddress1).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.DeliveryAddress2).Type<StringType>();
            descriptor.Field(x => x.DeliveryCity).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.DeliveryPostCode).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.DeliveryCountry).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.LineItems).Type<NonNullType<ListType<NonNullType<LineItemInputType>>>>();
        }
    }
}