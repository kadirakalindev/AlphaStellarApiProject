using AutoMapper;
using Business.Abstract;
using Business.Configs.Response;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;
        private readonly AlphaStellarApiDbContext _context;
        private IMapper _mapper;
        public CarService(ICarRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CommandResponse Delete(Car car)
        {
           _repository.Delete(car);
            return new CommandResponse
            {
                Status = true,
                Message = "Araç Silindi"
            };

        }

        public IEnumerable<Car> GetByColor(CarColorDto color)
        {
           
            var entity = _mapper.Map<Car>(color);
            return _repository.Get(entity);
        }

        public CommandResponse LightsOnOff(CarLightsDTO light)
        {
            var entity = _repository.GetId(light.Id);
            if (entity == null)
            {
                return new CommandResponse
                {
                    Status = false,
                    Message = "KAYIT BULUNAMADI"
                };
            }
            var mapped = _mapper.Map(light, entity);
            _repository.Update(mapped);
            return new CommandResponse
            {
                Status = true,
                Message = "Far durumu güncellendi."
            };

        }
    }
}
