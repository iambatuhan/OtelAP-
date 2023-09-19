using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.Dtos.AboutDto;

namespace WebUI.ViewComponents
{
    public class AboutPartial:ViewComponent
    {
       
        public  IViewComponentResult Invoke()
        {
            
            return View();

        }
    }
}
