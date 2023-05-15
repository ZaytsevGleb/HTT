using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
