using AutoMapper;
using BusinessLogic.Products.Models;
using BusinessLogic.Products.Services;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace WebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/products")]
    public sealed class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public ProductsController(
            IMapper mapper,
            ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet(Name = "GetProductsWithCategories")]
        [ProducesResponseType(Status200OK, Type = typeof(IEnumerable<CategoryDto>))]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> GetProductAsync()
        {
            var products = await _categoryService.GetCategoriesProductsAsync();

            return Ok(products.Select(_mapper.Map<CategoryDto>));
        }
    }
}
    