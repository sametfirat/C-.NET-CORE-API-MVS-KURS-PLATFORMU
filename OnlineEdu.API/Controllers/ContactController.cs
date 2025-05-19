using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstrac;
using OnlineEdu.DTO.DTOs.ContactDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController(IGenericService<Contact> _contactService, IMapper mapper) : ControllerBase
    {
        [HttpGet] 
        public IActionResult GetContact()
        {
            var contact = _contactService.TGetList();
            return Ok(contact);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok("Silindi");
        }
        [HttpPut]
         public IActionResult Update(UpdateContactDto updateContactDto)
        {
            var value= mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(value);
            return Ok("Güncellendi");
        }
        [HttpPost]
        public IActionResult Create(CreatContactDto creatContactDto)
        {
            var contact = mapper.Map<Contact>(creatContactDto);
            _contactService.Tcreate(contact);
            return Ok("Eklendi");
        }

    }
}
