using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
       
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Bath { get; set; }
        public string BathCount { get; set; }
        public string Description { get; set; }

    }
}
