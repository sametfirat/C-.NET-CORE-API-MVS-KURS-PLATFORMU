using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.SubScribeDtos
{
    public class CreatSubscribeDto
    {
        
        public string Email { get; set; }
        private bool IsActive { get => false; }
    }
}
