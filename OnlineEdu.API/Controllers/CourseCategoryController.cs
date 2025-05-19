using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.CourseCategory;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController(IGenericService<CourseCategory> _courseCategoryService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseCategoryService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseCategoryService.TGetById(id);
        
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = _courseCategoryService.TGetById(id);
           
            _courseCategoryService.TDelete(id);
            return Ok("Silindi");
        }
        [HttpPost]
        public IActionResult Create(CrateCourseCategoryDto  crateCourseCategoryDto)
        {
            var value = mapper.Map<CourseCategory>(crateCourseCategoryDto);
            _courseCategoryService.Tcreate(value);
            return Ok("Yeni KURS Alanı Oluşturuldu");

        }
        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var value = mapper.Map<CourseCategory>(updateCourseCategoryDto);
            _courseCategoryService.TUpdate(value);
            return Ok("KURS Alanı Güncellendi");
        }
    }
}
