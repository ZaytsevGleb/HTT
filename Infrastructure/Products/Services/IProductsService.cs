using BusinessLogic.Products.Models;

namespace BusinessLogic.Products.Services;

public interface IProductsService
{
    Task<IEnumerable<ProductModel>> GetProductsAsync();
}
