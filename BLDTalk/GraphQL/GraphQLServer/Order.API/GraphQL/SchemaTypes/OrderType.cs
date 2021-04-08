using HotChocolate.Types;

namespace Order.API.GraphQL.SchemaTypes
{
    public class OrderType:ObjectType<Models.Order>
    {
        protected override void Configure(IObjectTypeDescriptor<Models.Order> descriptor)
        {
            descriptor.Name("Order");
            descriptor.Field(x=>x.OrderNumber).Type<NonNullType<UuidType>>();
            descriptor.Field(x=>x.DeliveryName).Type<StringType>();
            descriptor.Field(x=>x.DeliveryAddress1).Type<StringType>();
            descriptor.Field(x=>x.DeliveryAddress2).Type<StringType>();
            descriptor.Field(x=>x.DeliveryCity).Type<StringType>();
            descriptor.Field(x=>x.DeliveryPostCode).Type<StringType>();
            descriptor.Field(x=>x.DeliveryCountry).Type<StringType>();
            descriptor.Field(x=>x.LineItems).Type<ListType<LineItemType>>();
        }
    }
}