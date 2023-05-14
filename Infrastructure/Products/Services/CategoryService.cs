using AutoMapper;
using BusinessLogic.Products.Models;
using DataAccess.Repositories;

namespace BusinessLogic.Products.Services
{
    internal sealed class CategoryService : ICategoryService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(
            IRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryModel>> GetCategoriesProductsAsync()
        {
            var categories = await _repository.GetCategoriesWithProductsAsync();
            var models = categories.Select(_mapper.Map<CategoryModel>); 

            return models;
        }
    }
}
