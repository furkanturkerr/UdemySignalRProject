using AutoMapper;
using DTOLayer.CategoryDTO;
using EntityLayer.Entities;

namespace SignalRApi.Mapping;

public class BookingMapping : Profile
{
    public BookingMapping()
    {
        CreateMap<Booking, ResultCategoryDto>().ReverseMap();
        CreateMap<Booking, CreateCategoryDto>().ReverseMap();
        CreateMap<Booking, UpdateCategoryDto>().ReverseMap();
        CreateMap<Booking, GetCategoryDeto>().ReverseMap();
    }
}