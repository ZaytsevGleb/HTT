using BusinessLogic.Products.Models;

namespace BusinessLogic.Products.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetCategoriesProductsAsync();
    }
}
