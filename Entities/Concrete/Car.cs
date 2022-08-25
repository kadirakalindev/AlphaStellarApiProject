using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:Vehicle
    {
        public string Headlights { get; set; }
        public string HeadlightStatus { get; set; }
        public string Wheels { get; set; }
    }
}
