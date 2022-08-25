using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DbContexts
{
    public class AlphaStellarApiDbContext : DbContext
    {
        private IConfiguration _configuration;
        public AlphaStellarApiDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("MsComm");
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));
        }

    }
}
