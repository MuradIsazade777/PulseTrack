using System;
namespace PulseTrack.Models
{
    public class HeartRate
    {
        public int Id { get; set; }
        public int BPM { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
