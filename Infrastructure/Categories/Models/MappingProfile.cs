using AutoMapper;
using DataAccess.Entities;

namespace BusinessLogic.Categories.Models;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CategoryModel, CategoryDto>();
        CreateMap<Category, CategoryModel>();
    }
}
