using BlazorGQL.Model;
using BlazorGQL.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorGQL.Pages.Order
{
    public partial class CartList
    {
        [Inject]
        public IOrderService OrderService { get; set; }
        [Inject]
        public ICartService CartService { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }


        private IList<ProductModel> _items;
        private OrderModel _orderModel;


        protected override void OnInitialized()
        {
            _orderModel = OrderService.GetNewOrder();
            UpdateList();
        }

        private void UpdateList()
        {
            _items = CartService.CartList;
        }

        private async Task CreateOrder()
        {
            //Create the order
            _orderModel.LineItems = new List<OrderLineItemModel>();
            foreach (var item in _items)
            {
                var newItem = new OrderLineItemModel
                {
                    Sku = item.Sku,
                    Quantity = item.Quantity
                };
                _orderModel.LineItems.Add(newItem);
            }
            await OrderService.SaveOrder(_orderModel);
            CartService.ClearCart();
            NavigationManager.NavigateTo("cartfinished");
        }

        private void RemoveItem(ProductModel item)
        {
            CartService.RemoveFromCart(item);
        }
    }
}
