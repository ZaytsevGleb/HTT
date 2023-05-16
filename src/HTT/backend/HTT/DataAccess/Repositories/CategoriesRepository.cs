using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

internal sealed class CategoriesRepository : ICategoriesRepository
{
    private readonly ApplicationDbContext _db;

    public CategoriesRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Category>> GetCategoriesWithPoruductsAsync()
    {
        var dbQuery = _db.Categories
               .AsNoTracking()
               .AsQueryable();

        var categories = await dbQuery
            .Include(x => x.Products)
            .OrderBy(x => x.Name)
            .ToListAsync();

        return categories;
    }
}
