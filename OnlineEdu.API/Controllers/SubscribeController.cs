using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.SubScribeDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController(IGenericService<Subscriber> subscribeService,IMapper  mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var volue = subscribeService.TGetList();
            return Ok(volue);
        }
        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var volue = subscribeService.TGetById(id);
           
            return Ok(volue);
        }
        [HttpPost]
        public IActionResult Creat(CreatSubscribeDto creatSubscribeDto)
        {
            var newValue = mapper.Map<Subscriber>(creatSubscribeDto);
            subscribeService.Tcreate(newValue);
            return Ok("Yeni Abone Oluşturuldu");

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           subscribeService.TDelete(id);
            return Ok("Abone Silindi");
        }
        [HttpPut]
        public IActionResult Update(UpdateSubscribeDto updateSubscribeDto)
        {
            var updatedValue = mapper.Map<Subscriber>(updateSubscribeDto);
            subscribeService.TUpdate(updatedValue);
            return Ok("Abone Güncellendi");
        }
    }
}
