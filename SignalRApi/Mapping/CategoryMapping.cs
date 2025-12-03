using AutoMapper;
using DTOLayer.CategoryDTO;
using EntityLayer.Entities;

namespace SignalRApi.Mapping;

public class CategoryMapping : Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, ResultCategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        CreateMap<Category, GetCategoryDeto>().ReverseMap();
    }
}