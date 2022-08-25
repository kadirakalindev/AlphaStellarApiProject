using Business.Configs.Response;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IEnumerable<Car> GetByColor(CarColorDto color);
        public CommandResponse LightsOnOff(CarLightsDTO light);
        public CommandResponse Delete(Car car);
    }
}
