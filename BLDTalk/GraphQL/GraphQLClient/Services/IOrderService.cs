using BlazorGQL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorGQL.Services
{
    public interface IOrderService
    {
        OrderModel GetNewOrder();
        Task<IEnumerable<OrderModel>> GetOrders();
        Task<OrderModel> SaveOrder(OrderModel order);
    }
}
