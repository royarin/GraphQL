using BlazorGQL.Model;
using BlazorGQL.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorGQL.Pages.Order
{
    public partial class ProductList
    {
        [Inject]
        public IProductService ProductService { get; set; }

        private IEnumerable<ProductModel> _products;
       

        protected override async Task OnInitializedAsync()
        {
            await UpdateList();
        }

        private async Task UpdateList()
        {
            _products = await ProductService.GetProducts();
        }

    }
}
