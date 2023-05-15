using BusinessLogic.Categories.Services;
using BusinessLogic.Products.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BusinessLogic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogicDependencies(this IServiceCollection services)
        {
            services
                .AddAutoMapper(Assembly.GetExecutingAssembly());

            services
                .AddScoped<ICategoriesService, CategoriesService>()
                .AddScoped<IProductsService, ProductsService>();

            return services;
        }
    }
}
