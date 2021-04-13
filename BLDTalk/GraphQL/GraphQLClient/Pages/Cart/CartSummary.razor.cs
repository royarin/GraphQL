using BlazorGQL.Services;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace BlazorGQL.Pages.Cart
{
    public partial class CartSummary
    {
        [Inject]
        public ICartService CartService { get; set; }

        private int ItemCount { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var service = CartService as CartService;
            if (service != null)
            {
                service.CartHasChangedEvent -= Service_CartHasChangedEvent;
                service.CartHasChangedEvent += Service_CartHasChangedEvent;
            }

        }

        private void Service_CartHasChangedEvent()
        {
            ItemCount = CartService.CartList.Sum(x => x.Quantity);
            InvokeAsync(() => this.StateHasChanged());
        }
    }
}
