using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.Models.Testimonial;

namespace WebUI.ViewComponents
{
    public class TestimonialPartial:ViewComponent
    {
        //public class RoomPartial : ViewComponent
        //{
        //    private readonly IHttpClientFactory _httpClientFactory;
        //    public RoomPartial(IHttpClientFactory httpClientFactory)
        //    {
        //        _httpClientFactory = httpClientFactory;
        //    }
        //    public async Task<IViewComponentResult> InvokeAsync()
        //    {
        //        var client = _httpClientFactory.CreateClient();
        //        var responseMessage = await client.GetAsync("https://localhost:44313/api/Room");
        //        if (responseMessage.IsSuccessStatusCode)
        //        {
        //            var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //            var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
        //            return View(values);
        //        }
        //        return View();
        //    }
        private readonly IHttpClientFactory _httpClientFactory;
        public TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44313/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);
                return View(values);
            }
            return View();
              }
    }
}
