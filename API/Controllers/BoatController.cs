using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _service;
        public BoatController(IBoatService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult GetByColor(BoatColorDTO color)
        {
            var data = _service.GetByColor(color);
            return Ok(data);
        }
    }
}
