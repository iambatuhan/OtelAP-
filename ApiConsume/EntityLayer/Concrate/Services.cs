﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Services
    {
        [Key]
        public int ServicesRoom { get; set; }
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get;set; }


    }
}