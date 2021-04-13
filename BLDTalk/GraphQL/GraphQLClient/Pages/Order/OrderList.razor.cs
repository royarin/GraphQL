using BlazorGQL.Model;
using BlazorGQL.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorGQL.Pages.Order
{
    public partial class OrderList
    {
        [Inject]
        public IOrderService OrderService { get; set; }

        private IEnumerable<OrderModel> _orders;
     
        protected override async Task OnInitializedAsync()
        {
            await UpdateList();
        }

        private async Task UpdateList()
        {
            _orders = await OrderService.GetOrders();
        }
    }
}
