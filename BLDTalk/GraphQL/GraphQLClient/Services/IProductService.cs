using BlazorGQL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorGQL.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetProducts();
    }
}
