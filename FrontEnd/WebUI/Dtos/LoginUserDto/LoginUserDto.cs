using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Dtos.LoginUserDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre Alanı gereklidir")]
        public string Password { get; set; }

    }
}
