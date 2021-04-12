using BlazorGQL.Model;
using BlazorGQL.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorGQL.Pages.Order
{
    public partial class OrderList
    {
        [Inject]
        public IOrderService OrderService { get; set; }

        private IEnumerable<OrderModel> _orders;
        private bool _modalShow = false;
        private OrderModel _currentOrder;

        protected override async Task OnInitializedAsync()
        {
            await UpdateList();
        }

        private async Task UpdateList()
        {
            _orders = await OrderService.GetOrders();
        }

        private void NewOrder()
        {
            _currentOrder = OrderService.GetNewOrder();
            _modalShow = true;
        }

        private async Task SaveOrder(bool result)
        {
            _modalShow = false;
            if (result)
            {
                try
                {
                    await OrderService.SaveOrder(_currentOrder);
                }
                catch (Exception ex)
                {

                }
                await UpdateList();
            }
        }
    }
}
