using BlazorGQL.Api;
using BlazorGQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGQL.Services
{
    public class ProductService : IProductService
    {
        private readonly IApiClient _client;
        public ProductService(IApiClient client)
        {
            _client = client;
        }

        public OrderModel GetNewOrder()
        {
            return new OrderModel();
        }

        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            var result = await _client.GetProducts.ExecuteAsync();
            return result.Data!.Products.Select(x => new ProductModel()
            {
                Name = x.Name,
                Description = x.Description,
                Sku = x.Sku,
                Color = x.Color,
                Size = x.Size,
                Price = x.Price,
                Image = x.Image,
                Stock = x.Inventory.Stock
            }); ;
        }
    }
}
