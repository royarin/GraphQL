using BlazorGQL.Api;
using BlazorGQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGQL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IApiClient _client;
        public OrderService(IApiClient client)
        {
            _client = client;
        }

        public OrderModel GetNewOrder()
        {
            var newOrder = new OrderModel
            {
                DeliveryCountry = "Netherlands"
            };
            return newOrder;
        }

        public async Task<IEnumerable<OrderModel>> GetOrders()
        {
            var result = await _client.GetOrders.ExecuteAsync();
            if (result.Data == null)
                return null;
            return result.Data!.Orders.Select(x => new OrderModel()
            {
                OrderNumber = x.OrderNumber,
                DeliveryName = x.DeliveryName,
                DeliveryAddress1 = x.DeliveryAddress1,
                DeliveryAddress2 = x.DeliveryAddress2,
                DeliveryPostCode = x.DeliveryPostCode,
                DeliveryCity = x.DeliveryCity,
                DeliveryCountry = x.DeliveryCountry,
                LineItems = x.LineItems.Select(x => new OrderLineItemModel() { Sku = x.Sku, Quantity = x.Quantity }).ToList()
            }); ;
        }

        public async Task<OrderModel> SaveOrder(OrderModel order)
        {
            var input = new CreateOrderInput
            {
                DeliveryName = order.DeliveryName,
                DeliveryAddress1 = order.DeliveryAddress1,
                DeliveryAddress2 = order.DeliveryAddress2,
                DeliveryPostCode = order.DeliveryPostCode,
                DeliveryCity = order.DeliveryCity,
                DeliveryCountry = order.DeliveryCountry,
                LineItems = order.LineItems.Select(x => new LineItemInput() { Sku = x.Sku, Quantity = x.Quantity }).ToList()
            };
            var result = await _client.AddOrder.ExecuteAsync(input);
            //    order.OrderNumber = instance.Data.CreateOrder.OrderNumber;

            if (result.Errors.Any())
            {
                throw new Exception("An error occurred");
            }

            return order;
        }
    }
}
