using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.DTO.DTOs.BannerDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _bannerService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = _bannerService.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _bannerService.TDelete(id);
            return Ok("Banner Silindi");

        }
        [HttpPost]
        public IActionResult Create(CreatBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.Tcreate(newValue);
            return Ok("Yeni Banner Oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {


            var updatedValuer = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(updatedValuer);
            return Ok("Hakkımızda Alanı Güncellendi");

        }
    }
    }

