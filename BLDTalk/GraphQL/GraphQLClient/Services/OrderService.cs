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
            return new OrderModel();
        }

        public async Task<IEnumerable<OrderModel>> GetOrders()
        {
            var results = await _client.GetOrdersAsync();
            results.EnsureNoErrors();
            return results.Data!.Orders.Select(x => new OrderModel()
            {
                OrderNumber = x.OrderNumber,
                DeliveryName = x.DeliveryName,
                DeliveryAddress1 = x.DeliveryAddress1,
                DeliveryAddress2 = string.Empty
            });
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
                DeliveryCountry = order.DeliveryCountry
            };

            var instance = await _client.AddOrderAsync(input);
            instance.EnsureNoErrors();
            order.OrderNumber = instance.Data.CreateOrder.OrderNumber;

            return order;
        }
    }
}
