using AutoMapper;
using DataAccess.Entities;

namespace BusinessLogic.Products.Models;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductModel, ProductDto>();
        CreateMap<Product, ProductModel>();
    }
}

