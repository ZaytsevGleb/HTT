using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

internal sealed class ProductsRepository : IProductsRepository
{
    private readonly ApplicationDbContext _db;

    public ProductsRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var dbQuery = _db.Products
            .AsNoTracking()
            .AsQueryable();

        var products = await dbQuery
            .ToListAsync();

        return products;
    }
}
