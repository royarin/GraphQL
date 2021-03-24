using System.Collections.Generic;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;


namespace Products
{
    public class Query
    {
        public IEnumerable<Product> GetProducts([Service] ProductRepository repository) => 
        repository.GetProducts();

        public IEnumerable<Product> GetTopProducts(
            int first,
            [Service] ProductRepository repository) =>
            repository.GetTopProducts(first);


        public Product GetProduct(
            int id,
            [Service] ProductRepository repository) =>
            repository.GetProduct(id);
    }
}