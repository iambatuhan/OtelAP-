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
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        [HttpGet]
        public IActionResult ServicesList() {
            var values = _serviceService.TGetList();
            return Ok(values);
        
        }
        [HttpPost]
        public IActionResult AddServices(Services service) {
            _serviceService.TInsert(service);
            return Ok();
        
        
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteServices(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Services services)
        {
            _serviceService.TUpdate(services);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetServices(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok(values);
        }
        
    }
}
