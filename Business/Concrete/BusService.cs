using AutoMapper;
using Business.Abstract;
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
    public class BusService : IBusService
    {
        private readonly IBusRepository _repository;
        private readonly AlphaStellarApiDbContext _context;
        private IMapper _mapper;
        public BusService(IBusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<Bus> GetByColor(BusColorDto color)
        {
          
                var entity = _mapper.Map<Bus>(color);
                return _repository.Get(entity);
            
        }
    }
}
