using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost]
        public IActionResult GetByColor(CarColorDto color)
        {
            var data = _carService.GetByColor(color);
            return Ok(data);
        }
        [HttpPut]
        public IActionResult LightsOnOff(CarLightsDTO light)
        {
            var response = _carService.LightsOnOff(light);
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult DeleteCar (Car car)
        {
            var response = _carService.Delete(car);
            return Ok(response);
        }
    }
}
