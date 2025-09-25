using System.Collections.Generic;
using System.Linq;
using PulseTrack.Models;
using PulseTrack.Data;

namespace PulseTrack.Services
{
    public class MetricsService
    {
        private readonly PulseDbContext _context;

        public MetricsService(PulseDbContext context)
        {
            _context = context;
        }

        public void AddHeartRate(HeartRate hr)
        {
            _context.HeartRates.Add(hr);
            _context.SaveChanges();
        }

        public IEnumerable<HeartRate> GetAllHeartRates()
        {
            return _context.HeartRates.ToList();
        }
    }
}
