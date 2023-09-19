using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadı Alanı Gereklidir")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Alanı Gereklidir")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail Alanı gereklidir")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre Alanı gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    


}
}
