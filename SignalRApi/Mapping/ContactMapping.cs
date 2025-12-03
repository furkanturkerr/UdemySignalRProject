using AutoMapper;
using DTOLayer.ContactDTO;
using EntityLayer.Entities;

namespace SignalRApi.Mapping;

public class ContactMapping : Profile
{
    public ContactMapping()
    {
        CreateMap<Contact, ResultContactDto>().ReverseMap();
        CreateMap<Booking, UpdateContactDto>().ReverseMap();
        CreateMap<Booking, CreateContactDto>().ReverseMap();
        CreateMap<Booking, GetContactDto>().ReverseMap();
    }
}