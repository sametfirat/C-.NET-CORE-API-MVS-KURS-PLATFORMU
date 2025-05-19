using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.TestiminolDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonalController(IGenericService<Testimonial> testiminalService ,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = testiminalService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var value = testiminalService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = testiminalService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            testiminalService.TDelete(id);
            return Ok("Silindi");

        }
        [HttpPut]
        public IActionResult Update(UpdateTestiminalDto updateTestimonialDto)
        {
            var updatedValue = mapper.Map<Testimonial>(updateTestimonialDto);
            testiminalService.TUpdate(updatedValue);
            return Ok("Güncellendi");
        }
        [HttpPost]
        public IActionResult Creat(CreatTestiminolDto creatTestiminolDto)
        {
            var newValue = mapper.Map<Testimonial>(creatTestiminolDto);
            testiminalService.Tcreate(newValue);
            return Ok("Yeni Testimonial Oluşturuldu");
        }

    }
}
