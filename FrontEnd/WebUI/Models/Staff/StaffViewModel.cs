using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Staff
{
    public class StaffViewModel
    {
        [Key]
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    
    }
}
