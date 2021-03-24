using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Products
{
    public class ProductRepository
    {
        private readonly Dictionary<int, Product> _products;

        public ProductRepository()
        {
            _products = new Product[]
            {
                new Product(1, "Shoe", 899, 43, new List<string>
                {
                    "https://images-na.ssl-images-amazon.com/images/I/41Leu3gBUFL.jpg",
                    "https://images-na.ssl-images-amazon.com/images/I/71efs-3%2BTwL._UX695_.jpg"

                }),
                new Product(2, "Slippers", 1299, 44,new List<string>
                {
                    "https://m.media-amazon.com/images/I/71nCv50HVsL._AC_UL320_.jpg",
                    "https://images-na.ssl-images-amazon.com/images/I/41j2C4iVgqL.jpg"

                }),
                new Product(3, "Polo Shirt", 354, 40,new List<string>
                {
                    "https://images-na.ssl-images-amazon.com/images/I/81o1anyNSzL._AC_UY1000_.jpg",
                    "https://images-na.ssl-images-amazon.com/images/I/71WQx0Q9f1L._AC_UL1500_.jpg"

                })
            }.ToDictionary(t => t.Upc);
        }

        public IEnumerable<Product> GetProducts() => _products.Values;
        
        public IEnumerable<Product> GetTopProducts(int first) => 
            _products.Values.OrderBy(t => t.Upc).Take(first);

        public Product GetProduct   (int upc) => _products[upc];
    }
}