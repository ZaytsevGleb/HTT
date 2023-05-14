using AutoMapper;
using DataAccess.Entities;

namespace BusinessLogic.Products.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryModel, CategoryDto>()
                .ForMember(x => x.Products, p => p.MapFrom(x => x.Products));

            CreateMap<Category, CategoryModel>()
                .ForMember(x => x.Products, p => p.MapFrom(x => x.Products));
        }
    }
}
