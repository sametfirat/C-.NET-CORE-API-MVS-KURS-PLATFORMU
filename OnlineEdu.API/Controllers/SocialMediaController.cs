using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.SocialMediaDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController(IGenericService<SocialMedia> socialMediaService , IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = socialMediaService.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = socialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = socialMediaService.TGetById(id);
            
            socialMediaService.TDelete(id);
            return Ok("Silindi");
        }
        [HttpPost]
        public IActionResult Create(CreatSocialMediaDto socialMediaDto)
        {
            var newValue = mapper.Map<SocialMedia>(socialMediaDto);
            socialMediaService.Tcreate(newValue);
            return Ok("Yeni Sosyal Medya Alanı Oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var updatedValue = mapper.Map<SocialMedia>(updateSocialMediaDto);
            socialMediaService.TUpdate(updatedValue);
            return Ok("Sosyal Medya Alanı Güncellendi");
        }
        }
}
