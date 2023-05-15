using BusinessLogic.Categories.Models;

namespace BusinessLogic.Categories.Services;

public interface ICategoriesService
{
    Task<IEnumerable<CategoryModel>> GetCategoriesAsync();
}
