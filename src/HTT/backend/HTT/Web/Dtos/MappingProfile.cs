using AutoMapper;
using BusinessLogic.Categories.Models;
using BusinessLogic.Products.Models;

namespace WebApi.Dtos;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductModel, ProductDto>();
        CreateMap<CategoryModel, CategoryDto>();
    }
}
