using BlazorGQL.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorGQL.Pages.Product
{
    public partial class ProductCard
    {
        [Parameter]
        public ProductModel Product { get; set; }

        private int _stockThresHold = 100;
    }
}
