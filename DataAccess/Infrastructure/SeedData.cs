using DataAccess.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Infrastructure
{
    public static class SeedData
    {
        public static async Task AddSeedDataAsync(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetRequiredService<ApplicationDbContext>();

            if (db.Categories.Any()) return;

            await CreateCategories(db);
        }

        private static async Task CreateCategories(ApplicationDbContext db)
        {

            var fruitCategory = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Fruits",
                CreatedDate = DateTime.Now,
                Products = new List<Product>()
            };
            var vegetableCategory = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Vegetables",
                CreatedDate = DateTime.Now,
                Products = new List<Product>()
            };
            var berriesCategory = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Berries",
                CreatedDate = DateTime.Now,
                Products = new List<Product>()
            };

            var fruits = new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Apple",
                    Price = 30,
                    CategoryId = fruitCategory.Id,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Banana",
                    Price = 40,
                    CategoryId = fruitCategory.Id,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Peach",
                    Price = 50,
                    CategoryId = fruitCategory.Id,
                    CreatedDate = DateTime.Now
                },
            };

            var vegetables = new List<Product>
            {
                 new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Tomato",
                    Price = 20,
                    CategoryId = vegetableCategory.Id,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Cucumber",
                    Price = 15,
                    CategoryId = vegetableCategory.Id,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Onion",
                    Price = 7,
                    CategoryId = vegetableCategory.Id,
                    CreatedDate = DateTime.Now
                }
            };

            var berries = new List<Product>
            {
                   new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Strawberry",
                    Price = 40,
                    CategoryId = berriesCategory.Id,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Raspberry",
                    Price = 45,
                    CategoryId = berriesCategory.Id,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Blueberries",
                    Price = 55,
                    CategoryId = berriesCategory.Id,
                    CreatedDate = DateTime.Now
                }
            };

            fruitCategory.Products = fruits;
            vegetableCategory.Products = vegetables;
            berriesCategory.Products = berries;

            db.Categories.AddRange(fruitCategory, vegetableCategory, berriesCategory);
            db.Products.AddRange(fruits);
            await db.SaveChangesAsync();
        }

    }
}
