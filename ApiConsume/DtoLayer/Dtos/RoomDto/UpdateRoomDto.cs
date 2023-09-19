using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.RoomDto
{
  public   class UpdateRoomDto
    {
       
        public int RoomID { get; set; }
     
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lutfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Baslıgı Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak bilgisi giriniz")]
        public string Bath { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısını Giriniz")]
        public string BathCount { get; set; }
    }
}

