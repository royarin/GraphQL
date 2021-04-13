using BlazorGQL.Model;
using System.Collections.Generic;
using System.Linq;

namespace BlazorGQL.Services
{
    public class CartService : ICartService
    {
        private IList<ProductModel> _cartList = new List<ProductModel>();
        public delegate void CartHasChanged();
        public event CartHasChanged CartHasChangedEvent;

        public void AddToCart(ProductModel product)
        {
            var exists = _cartList.FirstOrDefault(x => x.Sku == product.Sku);
            if (exists == null)
            {
                product.Quantity = 1;
                _cartList.Add(product);
            }
            else
            {
                exists.Quantity++;
               
            }
            FireCartHasChanged();
        }

        private void FireCartHasChanged()
        {
            if (CartHasChangedEvent != null)
                CartHasChangedEvent();
        }

        public void RemoveFromCart(ProductModel product)
        {
            var currentItem = _cartList.FirstOrDefault(x => x.Sku == product.Sku);
            if (currentItem != null)
            {
                if (currentItem.Quantity == 1)
                    _cartList.Remove(product);
                else currentItem.Quantity--;
            }
            FireCartHasChanged();
        }

        public void ClearCart()
        {
            _cartList.Clear();
            FireCartHasChanged();
        }

        public IList<ProductModel> CartList => _cartList;

    }
}
