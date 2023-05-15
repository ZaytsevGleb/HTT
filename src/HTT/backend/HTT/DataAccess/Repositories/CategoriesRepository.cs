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

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        var dbQuery = _db.Categories
               .AsNoTracking()
               .AsQueryable();

        var categories = await dbQuery
            .ToListAsync();

        return categories;
    }
}
