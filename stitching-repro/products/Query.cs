using System.Collections.Generic;
using HotChocolate;

namespace Demo.Products
{
    public class Query
    {
        public IEnumerable<Product> GetProducts([Service] ProductRepository repository) => repository.GetProducts();
        public IEnumerable<Product> GetTopProducts(
            int first,
            [Service] ProductRepository repository) =>
            repository.GetTopProducts(first);

        public Product GetProduct(
            int upc,
            [Service] ProductRepository repository) =>
            repository.GetProduct(upc);
    }
}