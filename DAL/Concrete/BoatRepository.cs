using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BoatRepository : IBoatRepository
    {
        private readonly AlphaStellarApiDbContext _context;
        public BoatRepository(AlphaStellarApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Boat> Get(Boat boat)
        {
            return _context.Boats
                      .Where(c => c.Color == boat.Color).ToList();
        }
    }
}
