﻿using AutoMapper;
using OnlineEdu.DTO.DTOs.BannerDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<CreatBannerDto,Banner>().ReverseMap();
            CreateMap<UpdateBannerDto,Banner>().ReverseMap();
        }
    }
}
