using System;
using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using HotChocolate.Execution;

namespace Products
{
    public class ProductRepository
    {
        private readonly Dictionary<int, Product> _products;

        public ProductRepository()
        {
            _products = new Product[]
            {
                new Product(1, "Table", 899.99, 100),
                new Product(2, "Couch", 1299.56, 1000),
                new Product(3, "Chair", 54, 50)
            }.ToDictionary(t => t.Id);
        }

        public IEnumerable<Product> GetProducts() => _products.Values;
        
        public IEnumerable<Product> GetTopProducts(int first) => 
            _products.Values.OrderBy(t => t.Id).Take(first);

        public Product GetProduct(int id) => _products[id];

    }
}