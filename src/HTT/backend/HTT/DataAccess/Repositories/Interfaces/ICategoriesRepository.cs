﻿using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces;

public interface ICategoriesRepository
{
    Task<IEnumerable<Category>> GetCategoriesWithPoruductsAsync();
}
