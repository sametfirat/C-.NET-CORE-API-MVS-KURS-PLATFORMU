using AutoMapper;
using OnlineEdu.DTO.DTOs.TestiminolDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class TestimonalMapping: Profile
    {
        public TestimonalMapping()
        {
            CreateMap<CreatTestiminolDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestiminalDto, Testimonial>().ReverseMap();
        }
    }
   
}
