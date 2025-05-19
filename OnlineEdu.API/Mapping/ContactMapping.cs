using AutoMapper;
using OnlineEdu.DTO.DTOs.ContactDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping() 
        {
           CreateMap<CreatContactDto, Contact>().ReverseMap();
           CreateMap<UpdateContactDto, Contact>().ReverseMap();
        }
    }
}
