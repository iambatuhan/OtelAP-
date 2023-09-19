using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Dtos.ServicesDto
{
    public class UpdateServiceDto
    {
        public int ServicesRoom { get; set; }
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlıgı giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet başlıgı giriniz")]
        public string Description { get; set; }
    }
}
