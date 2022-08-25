using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public  class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Color { get; set; }
    }
}
