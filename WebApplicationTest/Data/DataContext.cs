using Microsoft.EntityFrameworkCore;

namespace WebApplicationTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
