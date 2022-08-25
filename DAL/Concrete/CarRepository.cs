using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CarRepository : ICarRepository
    {
        private readonly AlphaStellarApiDbContext _context;
        public CarRepository(AlphaStellarApiDbContext context)
        {
            _context = context;
        }

        public void Delete(Car car)
        {
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }

        public IEnumerable<Car> Get(Car car)
        {
            //return _context.Cars.Where(c => c.Color == color).FirstOrDefault();
            return _context.Cars
                 .Where(c => c.Color == car.Color).ToList();
            
        }

        public Car GetId(int id)
        {
            return _context.Cars.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Car car)
        {
            _context.Update(car);
            _context.SaveChanges();
        }
    }
}
