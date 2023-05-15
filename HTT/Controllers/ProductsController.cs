using AutoMapper;
using BusinessLogic.Products.Models;
using BusinessLogic.Products.Services;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace WebApi.Controllers;

[ApiController]
[Produces("application/json")]
[Route("api/products")]
public sealed class casd : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IProductsService _productsService;

    public casd(
        IMapper mapper,
        IProductsService productsService)
    {
        _mapper = mapper;
        _productsService = productsService;
    }

    [HttpGet(Name = "GetProducts")]
    [ProducesResponseType(Status200OK, Type = typeof(IEnumerable<ProductDto>))]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetAsync()
    {
        var products = await _productsService.GetProductsAsync();

        return Ok(products.Select(_mapper.Map<ProductDto>));
    }
}
