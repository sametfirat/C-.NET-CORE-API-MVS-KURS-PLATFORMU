﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.BlogDtos
{
    public class CreatBlogDto
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; }
        public int BlogCategoryId { get; set; }
       
    }
}
