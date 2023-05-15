using AutoMapper;
using BusinessLogic.Products.Models;
using DataAccess.Repositories.Interfaces;

namespace BusinessLogic.Products.Services;

internal sealed class ProductsService : IProductsService
{
    private readonly IProductsRepository _productsRepository;
    private readonly IMapper _mapper;

    public ProductsService(
        IProductsRepository productsRepository,
        IMapper mapper)
    {
        _productsRepository = productsRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<ProductModel>> GetProductsAsync()
    {
        var categories = await _productsRepository.GetAllAsync();
        var models = categories.Select(_mapper.Map<ProductModel>);

        return models;
    }
}

