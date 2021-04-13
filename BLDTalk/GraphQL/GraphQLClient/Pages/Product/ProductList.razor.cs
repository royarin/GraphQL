using BlazorGQL.Model;
using BlazorGQL.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorGQL.Pages.Product
{
    public partial class ProductList
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public ICartService CartService { get; set; }

        private IEnumerable<ProductModel> _products;

        protected override async Task OnInitializedAsync()
        {
            await UpdateList();
        }

        private async Task UpdateList()
        {
            _products = await ProductService.GetProducts();
        }

        private void AddToCart(ProductModel product)
        {
            CartService.AddToCart(product);
        }

    }
}
