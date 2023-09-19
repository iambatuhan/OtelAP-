using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutUsID { get; set; }
        public String Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustumerCount { get; set; }
    }
}
