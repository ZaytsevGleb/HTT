using AutoMapper;
using DataAccess.Entities;

namespace BusinessLogic.Categories.Models;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryModel>();
    }
}