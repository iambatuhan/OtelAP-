using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialServices _testimonialServices;
        public TestimonialController(ITestimonialServices testimonialServices)
        {
            _testimonialServices = testimonialServices;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialServices.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonialcs testimonialcs)
        {
            _testimonialServices.TInsert(testimonialcs);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonialcs(int id)
        {
            var values = _testimonialServices.TGetByID(id);
            _testimonialServices.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonialcs testimonialcs)
        {
            _testimonialServices.TUpdate(testimonialcs);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _testimonialServices.TGetByID(id);
            return Ok(values);
        }
        
    }
}
