using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

internal sealed class Repository : IRepository
{
    private readonly ApplicationDbContext _db;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Category>> GetCategoriesWithProductsAsync()
    {
        var categories = await _db.Categories
            .Include(c => c.Products)
            .ToListAsync();

        return categories;
    }
}
