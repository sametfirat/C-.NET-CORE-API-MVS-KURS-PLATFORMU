using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesagesController(IGenericService <Message> _massageSerice,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = _massageSerice.TGetList();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _massageSerice.TGetById(id);

            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = _massageSerice.TGetById(id);
            if (value == null)
            {
                return NotFound();
            }
            _massageSerice.TDelete(id);
            return Ok("mesaj Alanı Silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var newValue = mapper.Map<Message>(createAboutDto);
            _massageSerice.Tcreate(newValue);
            return Ok("Yeni Mesaj Alanı Oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateMessageDto updateMessageDto)
        {


            var updatedValue = mapper.Map<Message>(updateMessageDto);
            _massageSerice.TUpdate(updatedValue);
            return Ok("mesaj Alanı Güncellendi");
        }
    }
}
