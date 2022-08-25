using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BusRepository : IBusRepository
    {
        private readonly AlphaStellarApiDbContext _context;
        public BusRepository(AlphaStellarApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bus> Get(Bus bus)
        {
            return _context.Buses
                      .Where(c => c.Color == bus.Color).ToList();
        }
    }
}
