using AutoMapper;
using BusinessLogic.Categories.Models;
using DataAccess.Repositories.Interfaces;

namespace BusinessLogic.Categories.Services;

internal sealed class CategoriesService : ICategoriesService
{
    private readonly ICategoriesRepository _repository;
    private readonly IMapper _mapper;

    public CategoriesService(
        ICategoriesRepository repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryModel>> GetCategoriesAsync()
    {
        var categories = await _repository.GetAllAsync();
        var models = categories.Select(_mapper.Map<CategoryModel>);

        return models;
    }
}
