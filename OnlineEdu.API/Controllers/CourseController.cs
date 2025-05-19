using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(IGenericService<Course> _corseService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = _corseService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _corseService.TGetById(id);
            
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = _corseService.TGetById(id);
            
            _corseService.TDelete(id);
            return Ok("Silindi");
        }
        [HttpPost]
        public IActionResult Create(CreatCourseDto creatCourseDto)
        {
            var newValue = mapper.Map<Course>(creatCourseDto);
            _corseService.Tcreate(newValue);
            return Ok("Yeni KURS Alanı Oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(CreatCourseDto creatCourseDto)
        {
            var VALUE = mapper.Map<Course>(creatCourseDto);
            _corseService.TUpdate(VALUE);
            return Ok("KURS Alanı Güncellendi");
        }

    }
}
