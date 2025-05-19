using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> aboutService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = aboutService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = aboutService.TGetById(id);

            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = aboutService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }   
            aboutService.TDelete(id);
            return Ok("Hakkımızda Alanı Silindi");
        }
        [HttpPost]
        public IActionResult Create( CreateAboutDto createAboutDto)
        {
            var newValue = mapper.Map<About>(createAboutDto);
            aboutService.Tcreate(newValue);
            return Ok("Yeni Hakımızzda Alanı Oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            
           
            var updatedValue = mapper.Map<About>(updateAboutDto);
            aboutService.TUpdate(updatedValue);
            return Ok("Hakkımızda Alanı Güncellendi");
        }

    }

}
