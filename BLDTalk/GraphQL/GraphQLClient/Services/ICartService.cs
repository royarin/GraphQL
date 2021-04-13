using BlazorGQL.Model;
using System.Collections.Generic;

namespace BlazorGQL.Services
{
    public interface ICartService
    {
        void AddToCart(ProductModel product);
        void RemoveFromCart(ProductModel product);
        void ClearCart();

        public IList<ProductModel> CartList { get; }
    }
}
