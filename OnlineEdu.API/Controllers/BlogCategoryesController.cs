using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoryesController(IGenericService<BlogCategory> _blogCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = _blogCategoryService.TGetList();
            return Ok(value);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _blogCategoryService.TGetById(id);
            
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreatBlogCategoryDto creatBlogCategoryDto)
        {
            var blogCategory = _mapper.Map<BlogCategory>(creatBlogCategoryDto);
            _blogCategoryService.Tcreate(blogCategory);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateBlogCategoryDto updateBlogCategoryDto)
        {
            var blogCategory = _mapper.Map<BlogCategory>(updateBlogCategoryDto);
            _blogCategoryService.TUpdate(blogCategory);
            return Ok("Güncellendi");
        }
        [HttpDelete("{id}")]

        public IActionResult TDelete(int id)
        {
            
            _blogCategoryService.TDelete(id);
            return Ok("Silindi");
        }
    }
}
