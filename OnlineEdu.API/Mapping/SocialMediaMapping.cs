﻿using AutoMapper;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.DTO.DTOs.SocialMediaDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SocialMediaMapping :Profile
    {
      public SocialMediaMapping()
        {

            CreateMap<CreatSocialMediaDto, Message>().ReverseMap();
            CreateMap<UpdateSocialMediaDto, Message>().ReverseMap();
            
        }
    }
}
