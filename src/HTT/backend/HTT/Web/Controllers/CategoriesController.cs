using AutoMapper;
using BusinessLogic.Categories.Models;
using BusinessLogic.Categories.Services;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace WebApi.Controllers;

[ApiController]
[Produces("application/json")]
[Route("api/categories")]
public sealed class CategoriesController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ICategoriesService _categoryService;

    public CategoriesController(
        IMapper mapper,
        ICategoriesService categoryService)
    {
        _mapper = mapper;
        _categoryService = categoryService;
    }

    [HttpGet(Name = "GetCategories")]
    [ProducesResponseType(Status200OK, Type = typeof(IEnumerable<CategoryDto>))]
    public async Task<ActionResult<IEnumerable<CategoryModel>>> GetAsync()
    {
        var categories = await _categoryService.GetCategoriesAsync();

        return Ok(categories.Select(_mapper.Map<CategoryDto>));
    }
}


