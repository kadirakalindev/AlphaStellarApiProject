using Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarRepository
    {
        public void Update(Car car);
        public IEnumerable<Car> Get(Car car);
        public void Delete(Car car);
        public Car GetId(int id);
    }
}
