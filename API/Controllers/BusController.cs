using Business.Abstract;
using Business.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _service;
        public BusController(IBusService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult GetByColor(BusColorDto color)
        {
            var data = _service.GetByColor(color);
            return Ok(data);
        }
    }
}
