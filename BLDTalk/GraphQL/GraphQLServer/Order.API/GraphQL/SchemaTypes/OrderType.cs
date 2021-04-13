using HotChocolate.Types;

namespace Order.API.GraphQL.SchemaTypes
{
    public class OrderType:ObjectType<Models.Order>
    {
        protected override void Configure(IObjectTypeDescriptor<Models.Order> descriptor)
        {
            descriptor.Name("Order");
            descriptor.Field(x=>x.OrderNumber).Type<NonNullType<IdType>>();
            descriptor.Field(x=>x.DeliveryName).Type<NonNullType<StringType>>();
            descriptor.Field(x=>x.DeliveryAddress1).Type<NonNullType<StringType>>();
            descriptor.Field(x=>x.DeliveryAddress2).Type<StringType>();
            descriptor.Field(x=>x.DeliveryCity).Type<NonNullType<StringType>>();
            descriptor.Field(x=>x.DeliveryPostCode).Type<NonNullType<StringType>>();
            descriptor.Field(x=>x.DeliveryCountry).Type<NonNullType<StringType>>();
            descriptor.Field(x=>x.LineItems).Type<NonNullType<ListType<NonNullType<LineItemType>>>>();
        }
    }
}