﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.RoomDto;

namespace WebUI.Controllers
{
   
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminBookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task <IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44313/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
//private readonly IHttpClientFactory _httpClientFactory;
//public AboutController(IHttpClientFactory httpClientFactory)
//{
//    _httpClientFactory = httpClientFactory;
//}
//public async Task<IActionResult> Index()
//{
//    var client = _httpClientFactory.CreateClient();
//    var responseMessage = await client.GetAsync("https://localhost:44313/api/About");
//    if (responseMessage.IsSuccessStatusCode)
//    {
//        var jsonData = await responseMessage.Content.ReadAsStringAsync();
//        var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
//        return View(values);
//    }
//    return View();
//}
