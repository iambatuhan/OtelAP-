using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class AddUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string city { get; set; }
    }
}
