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
    public class BoatService : IBoatService
    {
        private readonly IBoatRepository _repository;
        private readonly AlphaStellarApiDbContext _context;
        private IMapper _mapper;
        public BoatService(IBoatRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public IEnumerable<Boat> GetByColor(BoatColorDTO color)
        {
            var entity = _mapper.Map<Boat>(color);
            return _repository.Get(entity);

        }
    }
}
