using DataAccess.Entities;

namespace DataAccess.Repositories;

public interface IRepository
{
    Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
}
