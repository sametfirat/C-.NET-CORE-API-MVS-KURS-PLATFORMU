using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.BlogDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IGenericService<Blog> _blogService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var blogs = _blogService.TGetList();
            return Ok(blogs);
        }
        [HttpGet("{id}")]
        public IActionResult GetBlogById(int id)
        {
            var blog = _blogService.TGetById(id);
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }
        [HttpPost]
        public IActionResult CreateBlog(CreatBlogDto creatBlogDto)
        {
           
            var blog = mapper.Map<Blog>(creatBlogDto);
            _blogService.Tcreate(blog);
            return Ok("Blog Alanı Eklendi");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            var blog = mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(blog);
            return Ok("Blog Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Alanı Silindi");
        }
    }
}
