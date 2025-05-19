using AutoMapper;
using OnlineEdu.DTO.DTOs.SubScribeDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SubscribeMapping :Profile
    { public SubscribeMapping()
        {
            CreateMap<CreatSubscribeDto, Subscriber>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscriber>().ReverseMap();
        }
    }
    

    
}
