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
        var products = await _productsRepository.GetAllAsync();

        return products.Select(_mapper.Map<ProductModel>);
    }
}

