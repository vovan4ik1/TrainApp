using Microsoft.EntityFrameworkCore;
using TrainApp.Models;

namespace TrainApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Trains> Trains { get; set; }
        public DbSet<Stations> Stations { get; set; }
        public DbSet<TrainRoute> TrainRoute { get; set; }
        public DbSet<DestinationStations> DestinationStations { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Delay> delays { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
}
