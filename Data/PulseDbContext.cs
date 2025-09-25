using Microsoft.EntityFrameworkCore;
using PulseTrack.Models;

namespace PulseTrack.Data
{
    public class PulseDbContext : DbContext
    {
        public PulseDbContext(DbContextOptions<PulseDbContext> options) : base(options) { }

        public DbSet<HeartRate> HeartRates { get; set; }
        public DbSet<StepCount> StepCounts { get; set; }
    }
}
